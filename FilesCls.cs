/***
 *     ▄▄▄       ██ ▄█▀ ██▓ ██▓    
 *    ▒████▄     ██▄█▒ ▓██▒▓██▒    
 *    ▒██  ▀█▄  ▓███▄░ ▒██▒▒██░    
 *    ░██▄▄▄▄██ ▓██ █▄ ░██░▒██░    
 *     ▓█   ▓██▒▒██▒ █▄░██░░██████▒
 *     ▒▒   ▓▒█░▒ ▒▒ ▓▒░▓  ░ ▒░▓  ░
 *      ▒   ▒▒ ░░ ░▒ ▒░ ▒ ░░ ░ ▒  ░
 *      ░   ▒   ░ ░░ ░  ▒ ░  ░ ░   
 *          ░  ░░  ░    ░      ░  ░
 *          
 *     For code updates visit repository on https://github.com/sutaj
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace found.Recovery
{
    /*
     * using code from https://github.com/mjolka/filetypes 
     * check it out!
     */

    internal partial class FileTypeChecker
    {
        internal FileType GetFileType(Stream fileContent)
        {
            return GetFileTypes(fileContent).FirstOrDefault() ?? FileType.Unknown;
        }

        internal IEnumerable<FileType> GetFileTypes(Stream stream)
        {
            return FileSignatures.Where(fileType => fileType.Matches(stream));
        }
    }

    internal class FileType
    {
        private static readonly FileType unknown = new FileType("unknown", string.Empty, null);
        private readonly string name;
        private readonly string extension;
        private readonly FileTypeMatcher fileTypeMatcher;

        internal string Name { get { return name; } }
        internal string Extension { get { return extension; } }
        internal static FileType Unknown { get { return unknown; } }

        internal FileType(string name, string extension, FileTypeMatcher ftMatcher)
        {
            this.name = name;
            this.extension = extension;
            this.fileTypeMatcher = ftMatcher;
        }

        internal bool Matches(Stream stream)
        {
            return this.fileTypeMatcher == null || this.fileTypeMatcher.Matches(stream);
        }
    }

    internal class RangeFileTypeMatcher : FileTypeMatcher
    {
        internal readonly FileTypeMatcher matcher;
        internal readonly int maximumStartLocation;

        internal RangeFileTypeMatcher(FileTypeMatcher ftMacher, int maximumStartLocation)
        {
            this.matcher = ftMacher;
            this.maximumStartLocation = maximumStartLocation;
        }

        protected override bool MatchesPrivate(Stream stream)
        {
            for (int i = 0; i < this.maximumStartLocation; i++)
            {
                stream.Position = i;
                if (matcher.Matches(stream, resetPosition: false))
                {
                    return true;
                }
            }
            return false;
        }
    }

    internal class FuzzyFileTypeMatcher : FileTypeMatcher
    {
        private readonly byte?[] bytes;

        internal FuzzyFileTypeMatcher(IEnumerable<byte?> bytes)
        {
            this.bytes = bytes.ToArray();
        }

        protected override bool MatchesPrivate(Stream stream)
        {
            foreach (var item in this.bytes)
            {
                var _rb = stream.ReadByte();
                if (_rb == -1 || (item.HasValue && _rb != item.Value))
                {
                    return false;
                }
            }
            return true;
        }
    }

    internal abstract class FileTypeMatcher
    {
        internal bool Matches(Stream stream, bool resetPosition = true)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            if (!stream.CanRead || (stream.Position != 0 && !stream.CanSeek))
            {
                throw new ArgumentException("File contents must be a readable stream", "stream");
            }
            if (stream.Position != 0 && resetPosition)
            {
                stream.Seek(0, SeekOrigin.Begin);
            }
            return MatchesPrivate(stream);
        }
        protected abstract bool MatchesPrivate(Stream stream);
    }

    internal class ExactFileTypeMatcher : FileTypeMatcher
    {
        private readonly byte[] bytes;

        internal ExactFileTypeMatcher(IEnumerable<byte> bytes)
        {
            this.bytes = bytes.ToArray();
        }

        protected override bool MatchesPrivate(Stream stream)
        {
            foreach (var item in bytes)
            {
                if (stream.ReadByte() != item)
                {
                    return false;
                }
            }
            return true;
        }
    }

}

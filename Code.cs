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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace found.Recovery
{
    internal static class Code
    {
        private static string unknownDirName = @"Unidentified\";
        private static string sourceFolder;
        private static long scanSize = 0;
        private static string[] fileScanResult;
        private static string destinationFolder;

        internal static string UnknownDirName { get => unknownDirName; set => unknownDirName = value; }
        internal static string SourceFolder { get => sourceFolder; set => sourceFolder = value; }
        internal static string DestinationFolder { get => destinationFolder; set => destinationFolder = value; }
        internal static long ScanSize { get => scanSize; set => scanSize = value; }
        internal static string[] FileScanResult { get => fileScanResult; set => fileScanResult = value; }
        internal static Stopwatch _sw = new Stopwatch();
        internal static long TimeElpased { get => _sw.ElapsedMilliseconds; }
        //internal static Thread bgThread;

        internal static void ScanDirectory(string directory)
        {
            scanSize = 0;
            _sw.Reset();
            _sw.Start();

            sourceFolder = !directory.EndsWith(@"\") ? $@"{directory}\" : directory;

            fileScanResult = Directory.GetFiles(sourceFolder, "*.chk", SearchOption.TopDirectoryOnly);
            foreach (string item in fileScanResult)
            {
                FileInfo fl = new FileInfo(item);
                scanSize += fl.Length;
            }
            _sw.Stop();
        }

        internal static string ParseFileSizes(long sizeToParse)
        {
            string _ret = string.Empty;

            if(sizeToParse > 1024 && sizeToParse < 1048576)
            {
                decimal decSize = decimal.Round((decimal)sizeToParse / 1024, 2);
                _ret = $"{decSize} kB";
            }
            if(sizeToParse > 1048576 && sizeToParse < 1073741824)
            {
                decimal decSize = decimal.Round((decimal)sizeToParse / 1048576, 2);
                _ret = $"{decSize} MB";
            }
            if (sizeToParse > 1073741824 && sizeToParse < 1099511627776)
            {
                decimal decSize = decimal.Round((decimal)sizeToParse / 1073741824, 2);
                _ret = $"{decSize} GB";
            }
            if (sizeToParse > 1099511627776 && sizeToParse < 1125899906842624)
            {
                decimal decSize = decimal.Round((decimal)sizeToParse / 1099511627776, 2);
                _ret = $"{decSize} TB";
            }

            return _ret;
        }

        internal static bool CopyFile(string src, string dest, bool isUnknown = false)
        {
            bool _ret;
            try
            {
                if (!isUnknown)
                {
                    File.Copy(src, dest, false);
                }
                else
                {
                    string _f, _d, _df, _dd;
                    _f = Path.GetFileName(src);
                    _d = Path.GetDirectoryName(src);
                    _df = Path.GetFileName(dest);
                    _dd = Path.GetDirectoryName(dest);
                    if (!Directory.Exists(Path.Combine(_dd, unknownDirName)))
                    {
                        Directory.CreateDirectory(Path.Combine(_dd, unknownDirName));
                    }
                    File.Copy(src, $"{Path.Combine(_dd, unknownDirName, _df)}", true);
                }
                _ret = true;
            }
            catch
            {
                _ret = false;
            }
            return _ret;
        }

        internal static bool MoveFile(string src, string dest, bool isUnknown = false) // there is error with "file is used by another process right now. In main form there is temp fix.
        {
            bool _ret;
            try
            {
                if (!isUnknown)
                {
                    File.Move(src, dest);
                }
                else
                {
                    string _f, _d, _df, _dd;
                    _f = Path.GetFileName(src);
                    _d = Path.GetDirectoryName(src);
                    _df = Path.GetFileName(dest);
                    _dd = Path.GetDirectoryName(dest);
                    if (!Directory.Exists(Path.Combine(_dd, unknownDirName)))
                    {
                        Directory.CreateDirectory(Path.Combine(_dd, unknownDirName));
                    }
                    File.Move(src, $"{Path.Combine(_dd, unknownDirName, _df)}");
                }
                _ret = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                _ret = false;
            }
            return _ret;
        }

        internal static int CalculateProgresPercentage(int filesProcessed, int filesTotal)
        {
            double _ret = (double)(filesProcessed * 100) / filesTotal;
            if (_ret > 100)
            {
                _ret = 100;
            }
            return (int)_ret;
        }

        internal static double CalculateETA(TimeSpan timeTaken, int filesProcessed, int filesRemaining)
        {
            double _ret;
            _ret = (timeTaken.TotalSeconds / filesProcessed) * filesRemaining;
            return _ret - timeTaken.TotalSeconds;
        }

        internal static string PrintTS()
        {
            DateTime _dt = DateTime.Now;
            return $"{_dt.Year}-{_dt.Month, 00}-{_dt.Day, 00} {_dt.Hour, 00}:{_dt.Minute, 00}:{_dt.Second, 00}:  ";
        }

        internal static Image SpinnMeAround(float angle)
        {
            Image _img = new Bitmap(Properties.Resources.iconfinder_spin_118606, 56, 64);
            Bitmap _bmp = new Bitmap((_img.Width * 2), (_img.Height * 2));
            Graphics _g = Graphics.FromImage(_bmp);

            _g.TranslateTransform((float)_bmp.Width / 2, (float)_bmp.Height / 2);
            _g.RotateTransform(angle);
            _g.TranslateTransform(-(float)_bmp.Width / 2, -(float)_bmp.Height / 2);
            _g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            _g.DrawImage(_img, new PointF((_img.Width / 2), (_img.Height / 2)));
            _g.Dispose();
            return _bmp;
        }

    }

}

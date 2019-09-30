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
using System.Collections.Generic;

namespace found.Recovery
{
    internal partial class FileTypeChecker
    {
        internal static readonly IList<FileType> FileSignatures = new List<FileType>
        {
            new FileType("3GPP multimedia files", ".3gp", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70})),
            new FileType("3GPP2 multimedia files", ".3gp", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0x00, 0x20, 0x66, 0x74, 0x79, 0x70})),
            new FileType("MPEG-4 video files", ".3gp5", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0x00, 0x18, 0x66, 0x74, 0x79, 0x70})),
            new FileType("7-Zip compressed file", ".7z", new ExactFileTypeMatcher(
                new byte[] {0x37, 0x7A, 0xBC, 0xAF, 0x27, 0x1C})),
            new FileType("Microsoft Access 2007", ".accdb", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61,
                    0x72, 0x64, 0x20, 0x41, 0x43, 0x45, 0x20, 0x44, 0x42})),
            new FileType("Access project file", ".adp", new ExactFileTypeMatcher(
                new byte[] {0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1})),
            new FileType("Windows animated cursor", ".ani", new ExactFileTypeMatcher(
                new byte[] {0x52, 0x49, 0x46, 0x46})),
            new FileType("FreeArc compressed file", ".arc", new ExactFileTypeMatcher(
                new byte[] {0x41, 0x72, 0x43, 0x01})),
            new FileType("LH archive (old vers. type 1)", ".arc", new ExactFileTypeMatcher(
                new byte[] {0x1A, 0x02})),
            new FileType("LH archive (old vers. type 2)", ".arc", new ExactFileTypeMatcher(
                new byte[] {0x1A, 0x03})),
            new FileType("LH archive (old vers. type 3)", ".arc", new ExactFileTypeMatcher(
                new byte[] {0x1A, 0x04})),
            new FileType("LH archive (old vers. type 4)", ".arc", new ExactFileTypeMatcher(
                new byte[] {0x1A, 0x08})),
            new FileType("LH archive (old vers. type 5)", ".arc", new ExactFileTypeMatcher(
                new byte[] {0x1A, 0x09})),
            new FileType("ARJ Compressed archive file", ".arj", new ExactFileTypeMatcher(
                new byte[] {0x60, 0xEA})),
            new FileType("Windows Media Audio/Video File", ".asf", new ExactFileTypeMatcher(
                new byte[] {0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11})),
            new FileType("Audacity audio file", ".au", new ExactFileTypeMatcher(
                new byte[] {0x64, 0x6E, 0x73, 0x2E})),
            new FileType("Resource Interchange File Format", ".avi", new ExactFileTypeMatcher(
                new byte[] {0x52, 0x49, 0x46, 0x46})),
            new FileType("MS Answer Wizard", ".aw", new ExactFileTypeMatcher(
                new byte[] {0x8A, 0x01, 0x09, 0x00, 0x00, 0x00, 0xE1, 0x08})),
            new FileType("MS Publisher", ".bdr", new ExactFileTypeMatcher(
                new byte[] {0x58, 0x54})),
            new FileType("Bitmap image", ".bmp", new ExactFileTypeMatcher(
                new byte[] {0x42, 0x4D})),
            new FileType("bzip2 compressed archive", ".bz2", new ExactFileTypeMatcher(
                new byte[] {0x42, 0x5A, 0x68})),
            new FileType("Install Shield compressed file", ".cab", new ExactFileTypeMatcher(
                new byte[] {0x49, 0x53, 0x63, 0x28})),
            new FileType("Microsoft cabinet file", ".cab", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x53, 0x43, 0x46})),
            new FileType("Windows calendar", ".cal", new ExactFileTypeMatcher(
                new byte[] {0xB5, 0xA2, 0xB0, 0xB3, 0xB3, 0xB0, 0xA5, 0xB5})),
            new FileType("Packet sniffer files", ".cap", new ExactFileTypeMatcher(
                new byte[] {0x58, 0x43, 0x50, 0x00})),
            new FileType("CorelDraw document", ".cdr", new ExactFileTypeMatcher(
                new byte[] {0x52, 0x49, 0x46, 0x46})),
            new FileType("Flight Simulator Aircraft Configuration", ".cfg", new ExactFileTypeMatcher(
                new byte[] {0x5B, 0x66, 0x6C, 0x74, 0x73, 0x69, 0x6D, 0x2E})),
            new FileType("MS Compiled HTML Help File", ".chi", new ExactFileTypeMatcher(
                new byte[] {0x49, 0x54, 0x53, 0x46})),
            new FileType("Java bytecode", ".class", new ExactFileTypeMatcher(
                new byte[] {0xCA, 0xFE, 0xBA, 0xBE})),
            new FileType("Windows executable file", ".exe", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x5A})),
            new FileType("Corel color palette", ".cpl", new ExactFileTypeMatcher(
                new byte[] {0xDC, 0xDC})),
            new FileType("Corel Photopaint file_1", ".cpt", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x50, 0x54, 0x37, 0x46, 0x49, 0x4C, 0x45})),
            new FileType("Corel Photopaint file_2", ".cpt", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x50, 0x54, 0x46, 0x49, 0x4C, 0x45})),
            new FileType("Crush compressed archive", ".cru", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x52, 0x55, 0x53, 0x48, 0x20, 0x76})),
            new FileType("Canon RAW file", ".crw", new ExactFileTypeMatcher(
                new byte[] {0x49, 0x49, 0x1A, 0x00, 0x00, 0x00, 0x48, 0x45})),
            new FileType("Photoshop Custom Shape", ".csh", new ExactFileTypeMatcher(
                new byte[] {0x63, 0x75, 0x73, 0x68, 0x00, 0x00, 0x00, 0x02})),
            new FileType("Visual Basic User-defined Control file", ".ctl", new ExactFileTypeMatcher(
                new byte[] {0x56, 0x45, 0x52, 0x53, 0x49, 0x4F, 0x4E, 0x20})),
            new FileType("Windows cursor", ".cur", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0x02, 0x00})),
            new FileType("Video CD MPEG movie", ".dat", new ExactFileTypeMatcher(
                new byte[] {0x52, 0x49, 0x46, 0x46})),
            new FileType("IE History file", ".dat", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x6C, 0x69, 0x65, 0x6E, 0x74, 0x20, 0x55})),
            new FileType("Win9x registry hive", ".dat", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x52, 0x45, 0x47})),
            new FileType("WinNT registry file", ".dat", new ExactFileTypeMatcher(
                new byte[] {0x72, 0x65, 0x67, 0x66})),
            new FileType("MSWorks database file", ".db", new ExactFileTypeMatcher(
                new byte[] {0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1})),
            new FileType("SQLite database file", ".db", new ExactFileTypeMatcher(
                new byte[] {0x53, 0x51, 0x4C, 0x69, 0x74, 0x65, 0x20, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x20, 0x33, 0x00})),
            new FileType("Thumbs.db subheader", ".db", new ExactFileTypeMatcher(
                new byte[] {0xFD, 0xFF, 0xFF, 0xFF})),
            new FileType("Skype user data file", ".dbb", new ExactFileTypeMatcher(
                new byte[] {0x6C, 0x33, 0x33, 0x6C})),
            new FileType("PCX bitmap", ".dcx", new ExactFileTypeMatcher(
                new byte[] {0xB1, 0x68, 0xDE, 0x3A})),
            new FileType("Microsoft Office document", ".doc", new ExactFileTypeMatcher(
                new byte[] {0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1})),
            new FileType("DeskMate Document", ".doc", new ExactFileTypeMatcher(
                new byte[] {0x0D, 0x44, 0x4F, 0x43})),
            new FileType("Perfect Office document", ".doc", new ExactFileTypeMatcher(
                new byte[] {0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1, 0x00})),
            new FileType("Word 2.0 file", ".doc", new ExactFileTypeMatcher(
                new byte[] {0xDB, 0xA5, 0x2D, 0x00})),
            new FileType("MS Office Open XML Format Document", ".docx", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00})),
            new FileType("Microsoft Office document", ".dot", new ExactFileTypeMatcher(
                new byte[] {0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1})),
            new FileType("MS Developer Studio project file", ".dsp", new ExactFileTypeMatcher(
                new byte[] {0x23, 0x20, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73})),
            new FileType("MS Visual Studio workspace file", ".dsw", new ExactFileTypeMatcher(
                new byte[] {0x64, 0x73, 0x77, 0x66, 0x69, 0x6C, 0x65})),
            new FileType("Sony Compressed Voice File", ".dvf", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x53, 0x5F, 0x56, 0x4F, 0x49, 0x43, 0x45})),
            new FileType("Generic AutoCAD drawing", ".dwg", new ExactFileTypeMatcher(
                new byte[] {0x41, 0x43, 0x31, 0x30})),
            new FileType("Generic e-mail_1", ".eml", new ExactFileTypeMatcher(
                new byte[] {0x52, 0x65, 0x74, 0x75, 0x72, 0x6E, 0x2D, 0x50})),
            new FileType("Generic e-mail_2", ".eml", new ExactFileTypeMatcher(
                new byte[] {0x46, 0x72, 0x6F, 0x6D})),
            new FileType("Adobe encapsulated PostScript", ".eps", new ExactFileTypeMatcher(
                new byte[] {0xC5, 0xD0, 0xD3, 0xC6})),
            new FileType("Encapsulated PostScript file", ".eps", new ExactFileTypeMatcher(
                new byte[] {0x25, 0x21, 0x50, 0x53, 0x2D, 0x41, 0x64, 0x6F})),
            new FileType("Windows Event Viewer file", ".evt", new ExactFileTypeMatcher(
                new byte[] {0x30, 0x00, 0x00, 0x00, 0x4C, 0x66, 0x4C, 0x65})),
            new FileType("Windows Vista event log", ".evtx", new ExactFileTypeMatcher(
                new byte[] {0x45, 0x6C, 0x66, 0x46, 0x69, 0x6C, 0x65, 0x00})),
            new FileType("Portable Document Format", ".pdf", new RangeFileTypeMatcher(new ExactFileTypeMatcher(
                new byte[] { 0x25, 0x50, 0x44, 0x46 }), 1019)),
            new FileType("Free Lossless Audio Codec file", ".flac", new ExactFileTypeMatcher(
                new byte[] {0x66, 0x4C, 0x61, 0x43, 0x00, 0x00, 0x00, 0x22})),
            new FileType("Flash video file", ".flv", new ExactFileTypeMatcher(
                new byte[] {0x46, 0x4C, 0x56})),
            new FileType("Adobe FrameMaker", ".fm", new ExactFileTypeMatcher(
                new byte[] {0x3C, 0x4D, 0x61, 0x6B, 0x65, 0x72, 0x46, 0x69})),
            new FileType("True Type Font File", ".ttf", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x01, 0x00, 0x00, 0x00, 0x12, 0x01, 0x00, 0x00, 0x04, 0x00, 0x20, 0x44, 0x53, 0x49, 0x47})),
            new FileType("Graphics Interchange Format", ".gif", new ExactFileTypeMatcher(
                new byte[] {0x47, 0x49, 0x46, 0x38, 0x37, 0x61})),
            new FileType("Graphics Interchange Format", ".gif", new ExactFileTypeMatcher(
                new byte[] {0x47, 0x49, 0x46, 0x38, 0x39, 0x61})),
            new FileType("GZIP archive file", ".gz", new ExactFileTypeMatcher(
                new byte[] {0x1F, 0x8B, 0x08})),
            new FileType("Install Shield compressed file", ".hdr", new ExactFileTypeMatcher(
                new byte[] {0x49, 0x53, 0x63, 0x28})),
            new FileType("Radiance High Dynamic Range image file", ".hdr", new ExactFileTypeMatcher(
                new byte[] {0x23, 0x3F, 0x52, 0x41, 0x44, 0x49, 0x41, 0x4E})),
            new FileType("Windows Help file_1", ".hlp", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF})),
            new FileType("Windows Help file_2", ".hlp", new ExactFileTypeMatcher(
                new byte[] {0x3F, 0x5F, 0x03, 0x00})),
            new FileType("Windows help file_3", ".hlp", new ExactFileTypeMatcher(
                new byte[] {0x4C, 0x4E, 0x02, 0x00})),
            new FileType("BinHex 4 Compressed Archive", ".hqx", new ExactFileTypeMatcher(
                new byte[] {0x28, 0x54, 0x68, 0x69, 0x73, 0x20, 0x66, 0x69})),
            new FileType("Windows icon|printer spool file", ".ico", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0x01, 0x00})),
            new FileType("DVD info file", ".ifo", new ExactFileTypeMatcher(
                new byte[] {0x44, 0x56, 0x44})),
            new FileType("ChromaGraph Graphics Card Bitmap", ".img", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x49, 0x43, 0x54, 0x00, 0x08})),
            new FileType("GEM Raster file", ".img", new ExactFileTypeMatcher(
                new byte[] {0xEB, 0x3C, 0x90, 0x2A})),
            new FileType("Img Software Bitmap", ".img", new ExactFileTypeMatcher(
                new byte[] {0x53, 0x43, 0x4D, 0x49})),
            new FileType("ISO-9660 CD Disc Image", ".iso", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x44, 0x30, 0x30, 0x31})),
            new FileType("RealPlayer video file (V11+)", ".ivr", new ExactFileTypeMatcher(
                new byte[] {0x2E, 0x52, 0x45, 0x43})),
            new FileType("Java archive_1", ".jar", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x4B, 0x03, 0x04})),
            new FileType("Jar archive", ".jar", new ExactFileTypeMatcher(
                new byte[] {0x5F, 0x27, 0xA8, 0x89})),
            new FileType("JARCS compressed archive", ".jar", new ExactFileTypeMatcher(
                new byte[] {0x4A, 0x41, 0x52, 0x43, 0x53, 0x00})),
            new FileType("Java archive_2", ".jar", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x08, 0x00})),
            new FileType("JPEG IMAGE", ".jfif", new ExactFileTypeMatcher(
                new byte[] {0xFF, 0xD8, 0xFF, 0xE0})),
            new FileType("MS Windows journal", ".jnt", new ExactFileTypeMatcher(
                new byte[] {0x4E, 0x42, 0x2A, 0x00})),
            new FileType("JPEG2000 image files", ".jp2", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0x00, 0x0C, 0x6A, 0x50, 0x20, 0x20})),
            new FileType("JPEG IMAGE exif", ".jpg", new FuzzyFileTypeMatcher(
                new byte?[] {0xFF, 0xD8, 0xFF, 0xE1, null, null, 0x45, 0x78, 0x69, 0x66})),
            new FileType("JPEG IMAGE", ".jpg", new FuzzyFileTypeMatcher(
                new byte?[] {0xFF, 0xD8, 0xFF, 0xE0, null, null, 0x4A, 0x46, 0x49, 0x46, 0x00})),
            new FileType("MS Windows journal", ".jtp", new ExactFileTypeMatcher(
                new byte[] {0x4E, 0x42, 0x2A, 0x00})),
            new FileType("KWord document", ".kwd", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x4B, 0x03, 0x04})),
            new FileType("Compressed archive", ".lha", new ExactFileTypeMatcher(
                new byte[] {0x2D, 0x6C, 0x68})),
            new FileType("Apple audio and video files", ".m4a", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0x00, 0x20, 0x66, 0x74, 0x79, 0x70, 0x4D, 0x34, 0x41})),
            new FileType("Windows Visual Stylesheet", ".manifest", new ExactFileTypeMatcher(
                new byte[] {0x3C, 0x3F, 0x78, 0x6D, 0x6C, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x3D})),
            new FileType("MAr compressed archive", ".mar", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x41, 0x72, 0x30, 0x00})),
            new FileType("Microsoft Access", ".mdb", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x20,
                    0x4A, 0x65, 0x74, 0x20, 0x44, 0x42})),
            new FileType("SQL Data Base", ".mdf", new ExactFileTypeMatcher(
                new byte[] {0x01, 0x0F, 0x00, 0x00})),
            new FileType("Matroska stream file", ".mkv", new ExactFileTypeMatcher(
                new byte[] {0x1A, 0x45, 0xDF, 0xA3, 0x93, 0x42, 0x82, 0x88})),
            new FileType("Microsoft Money file", ".mny", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x01, 0x00, 0x00, 0x4D, 0x53, 0x49,
                    0x53, 0x41, 0x4D, 0x20, 0x44, 0x61, 0x74, 0x61, 0x62, 0x61, 0x73, 0x65})),
            new FileType("QuickTime movie", ".mov", new ExactFileTypeMatcher(
                new byte[] {0x6D, 0x6F, 0x6F, 0x76})),
            new FileType("QuickTime movie", ".mov", new ExactFileTypeMatcher(
                new byte[] {0x66, 0x72, 0x65, 0x65})),
            new FileType("QuickTime movie", ".mov", new ExactFileTypeMatcher(
                new byte[] {0x6D, 0x64, 0x61, 0x74})),
            new FileType("QuickTime movie", ".mov", new ExactFileTypeMatcher(
                new byte[] {0x77, 0x69, 0x64, 0x65})),
            new FileType("QuickTime movie", ".mov", new ExactFileTypeMatcher(
                new byte[] {0x70, 0x6E, 0x6F, 0x74})),
            new FileType("QuickTime movie", ".mov", new ExactFileTypeMatcher(
                new byte[] {0x73, 0x6B, 0x69, 0x70})),
            new FileType("MP3 audio file", ".mp3", new ExactFileTypeMatcher(
                new byte[] {0x49, 0x44, 0x33, 0x03, 0x00, 0x00, 0x00, 0x00, 0x10, 0x74, 0x54, 0x53, 0x53, 0x45})),
            new FileType("DVD video file", ".mpg", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0x01, 0xBA})),
            new FileType("MPEG video file", ".mpg", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x00, 0x01, 0xB3})),
            new FileType("Microsoft Common Console Document", ".msc", new ExactFileTypeMatcher(
                new byte[] {0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1})),
            new FileType("Microsoft Installer package", ".msi", new ExactFileTypeMatcher(
                new byte[] {0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00})),
            new FileType("Nero CD compilation", ".nri", new ExactFileTypeMatcher(
                new byte[] {0x0E, 0x4E, 0x65, 0x72, 0x6F, 0x49, 0x53, 0x4F})),
            new FileType("VMware BIOS state file", ".nvram", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x52, 0x56, 0x4E})),
            new FileType("Ogg Vorbis Codec compressed file", ".ogg", new ExactFileTypeMatcher(
                new byte[] {0x4F, 0x67, 0x67, 0x53, 0x00, 0x02, 0x00, 0x00})),
            new FileType("Quake archive file", ".pak", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x41, 0x43, 0x4B})),
            new FileType("GIMP pattern file", ".pat", new ExactFileTypeMatcher(
                new byte[] {0x47, 0x50, 0x41, 0x54})),
            new FileType("Visual C PreCompiled header", ".pch", new ExactFileTypeMatcher(
                new byte[] {0x56, 0x43, 0x50, 0x43, 0x48, 0x30})),
            new FileType("MS C++ debugging symbols file", ".pdb", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73,
                    0x6F, 0x66, 0x74, 0x20, 0x43, 0x2F, 0x43, 0x2B, 0x2B, 0x20})),
            new FileType("PGP disk image", ".pgd", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x47, 0x50, 0x64, 0x4D, 0x41, 0x49, 0x4E})),
            new FileType("Photoshop image", ".psd", new ExactFileTypeMatcher(
                new byte[] {0x38, 0x42, 0x50, 0x53, 0x00, 0x01, 0x00})),
            new FileType("Corel Paint Shop Pro image", ".psp", new ExactFileTypeMatcher(
                new byte[] {0x7E, 0x42, 0x4B, 0x00})),
            new FileType("Win98 password file", ".pwl", new ExactFileTypeMatcher(
                new byte[] {0xE3, 0x82, 0x85, 0x96})),
            new FileType("Win95 password file", ".pwl", new ExactFileTypeMatcher(
                new byte[] {0xB0, 0x4D, 0x46, 0x43})),
            new FileType("RealAudio streaming media", ".ra", new ExactFileTypeMatcher(
                new byte[] {0x2E, 0x72, 0x61, 0xFD, 0x00})),
            new FileType("RealAudio file", ".ra", new ExactFileTypeMatcher(
                new byte[] {0x2E, 0x52, 0x4D, 0x46, 0x00, 0x00, 0x00, 0x12})),
            new FileType("RealMedia metafile", ".ram", new ExactFileTypeMatcher(
                new byte[] {0x72, 0x74, 0x73, 0x70, 0x3A, 0x2F, 0x2F})),
            new FileType("WinRAR compressed archive", ".rar", new ExactFileTypeMatcher(
                new byte[] {0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x01, 0x00})),
            new FileType("WinRAR compressed archive ver 4", ".rar", new ExactFileTypeMatcher(
                new byte[] {0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x00, 0xCF})),
            new FileType("Windows registry file", ".reg", new ExactFileTypeMatcher(
                new byte[] {0xFF, 0xFE, 0x57, 0x00, 0x69, 0x00, 0x6E, 0x00, 0x64, 0x00, 0x6F, 0x00, 0x77, 0x00, 0x73, 0x00})),
            new FileType("RealMedia streaming media", ".rmvb", new ExactFileTypeMatcher(
                new byte[] {0x2E, 0x52, 0x4D, 0x46, 0x00, 0x00, 0x00, 0x12})),
            new FileType("RedHat Package Manager", ".rpm", new ExactFileTypeMatcher(
                new byte[] {0xED, 0xAB, 0xEE, 0xDB})),
            new FileType("RTF file", ".rtf", new ExactFileTypeMatcher(
                new byte[] {0x7B, 0x5C, 0x72, 0x74, 0x66, 0x31})),
            new FileType("SmartDraw Drawing file", ".sdr", new ExactFileTypeMatcher(
                new byte[] {0x53, 0x4D, 0x41, 0x52, 0x54, 0x44, 0x52, 0x57})),
            new FileType("Win2000 XP printer spool file", ".shd", new ExactFileTypeMatcher(
                new byte[] {0x67, 0x49, 0x00, 0x00})),
            new FileType("Win9x printer spool file", ".shd", new ExactFileTypeMatcher(
                new byte[] {0x48, 0x49, 0x00, 0x00})),
            new FileType("WinNT printer spool file", ".shd", new ExactFileTypeMatcher(
                new byte[] {0x66, 0x49, 0x00, 0x00})),
            new FileType("Win Server 2003 printer spool file", ".shd", new ExactFileTypeMatcher(
                new byte[] {0x68, 0x49, 0x00, 0x00})),
            new FileType("StuffIt compressed archive", ".sit", new ExactFileTypeMatcher(
                new byte[] {0x53, 0x74, 0x75, 0x66, 0x66, 0x49, 0x74, 0x20})),
            new FileType("StuffIt archive", ".sit", new ExactFileTypeMatcher(
                new byte[] {0x53, 0x49, 0x54, 0x21, 0x00})),
            new FileType("Visual Studio solution file", ".sln", new ExactFileTypeMatcher(
                new byte[] {0xEF, 0xBB, 0xBF, 0x0D, 0x0A, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74})),
            new FileType("Visual Studio project file", ".csproj", new ExactFileTypeMatcher(
                new byte[] {0xEF, 0xBB, 0xBF, 0x3C})),
            new FileType("Visual Studio Solution subheader", ".suo", new ExactFileTypeMatcher(
                new byte[] {0xFD, 0xFF, 0xFF, 0xFF, 0x04})),
            new FileType("Shockwave Flash player file", ".swf", new ExactFileTypeMatcher(
                new byte[] {0x46, 0x57, 0x53})),
            new FileType("Shockwave Flash player file", ".swf", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x57, 0x53})),
            new FileType("Tape Archive", ".tar", new ExactFileTypeMatcher(
                new byte[] {0x75, 0x73, 0x74, 0x61, 0x72})),
            new FileType("bzip2 compressed archive", ".tar.bz2", new ExactFileTypeMatcher(
                new byte[] {0x42, 0x5A, 0x68})),
            new FileType("TIFF file", ".tif", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x4D, 0x00, 0x2A})),
            new FileType("TIFF file", ".tif", new ExactFileTypeMatcher(
                new byte[] {0x49, 0x49, 0x2A, 0x00})),
            new FileType("TIFF file", ".tif", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x4D, 0x00, 0x2B})),
            new FileType("TIFF file", ".tif", new ExactFileTypeMatcher(
                new byte[] {0x49, 0x49, 0x2A, 0x00})),
            new FileType("VMware 4 Virtual Disk", ".vmdk", new ExactFileTypeMatcher(
                new byte[] {0x23, 0x20, 0x44, 0x69, 0x73, 0x6B, 0x20, 0x44})),
            new FileType("VMware 3 Virtual Disk", ".vmdk", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x4F, 0x57, 0x44})),
            new FileType("ZIP archive", ".zip", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x4B, 0x03, 0x04})),
            new FileType("Resource Interchange File Format", ".wav", new ExactFileTypeMatcher(
                new byte[] {0x52, 0x49, 0x46, 0x46})),
            new FileType("Blender file", ".blend", new ExactFileTypeMatcher(
                new byte[] {0x42, 0x4C, 0x45, 0x4E, 0x44, 0x45, 0x52})),
            new FileType("XML file", ".xml", new ExactFileTypeMatcher(
                new byte[] {0x3C, 0x3F, 0x78, 0x6D, 0x6C})),
            new FileType("Php MyAdmin dump file", ".sql", new ExactFileTypeMatcher(
                new byte[] {0x2D, 0x2D, 0x20, 0x70, 0x68, 0x70, 0x4D, 0x79, 0x41,
                    0x64, 0x6D, 0x69, 0x6E, 0x20, 0x53, 0x51, 0x4C, 0x20, 0x44, 0x75, 0x6D, 0x70})),
            new FileType("Oracle VM Virtual Disk", ".vdi", new ExactFileTypeMatcher(
                new byte[] {0x3C, 0x3C, 0x3C, 0x20, 0x4F, 0x72, 0x61, 0x63})),
            new FileType("Steam app manifest file", ".acf", new ExactFileTypeMatcher(
                new byte[] {0x22, 0x41, 0x70, 0x70, 0x53, 0x74, 0x61, 0x74, 0x65, 0x22})),
            new FileType("Steam install script", ".vdf", new ExactFileTypeMatcher(
                new byte[] {0x22, 0x69, 0x6E, 0x73, 0x74, 0x61, 0x6C, 0x6C, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x22, 0x0A})),
            new FileType("Unity editor pak file", ".pak", new ExactFileTypeMatcher(
                new byte[] {0x04, 0x00, 0x00, 0x00})),
            new FileType("Linux shell script", ".sh", new ExactFileTypeMatcher(
                new byte[] {0x23, 0x21, 0x2F, 0x62, 0x69, 0x6E, 0x2F})),
            new FileType("Google Chrome extension", ".crx", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x72, 0x32, 0x34})),
            new FileType("PNG Image", ".png", new ExactFileTypeMatcher(
                new byte[] {0x89, 0x50, 0x4e, 0x47})),
            new FileType("RSA public key", ".RSAkey", new RangeFileTypeMatcher(
                new ExactFileTypeMatcher(
                    new byte[] { 0x2D, 0x2D, 0x45, 0x4E, 0x44, 0x20, 0x52, 0x53,
                        0x41, 0x20, 0x50, 0x55, 0x42, 0x4C, 0x49, 0x43 }), 512)),
            new FileType("Windows Disk Image file", ".tbi", new ExactFileTypeMatcher(
                new byte[] { 0x00, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00})),
            new FileType("OpenFlight 3D file", ".flt", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x01, 0x01})),
            new FileType("BIOS details in RAM images", string.Empty,
                new FuzzyFileTypeMatcher(new byte?[] {0x00, 0x14, 0x00, 0x00, 0x01, 0x02, null, null, 0x03})),
            new FileType("Netscape Communicator (v4) mail folder", ".snm", new ExactFileTypeMatcher(
                new byte[] {0x00, 0x1E, 0x84, 0x90, 0x00, 0x00, 0x00, 0x00})),
            new FileType("Mujahideen Secrets 2 encrypted file", ".enc", new ExactFileTypeMatcher(
                new byte[] { 0x00, 0x5C, 0x41, 0xB1, 0xFF })),
            new FileType("PowerPoint presentation subheader", ".ppt", new RangeFileTypeMatcher(
                new ExactFileTypeMatcher(
                    new byte[] { 0x00, 0x6E, 0x1E, 0xF0 }), 512)),
            new FileType("Adobe Flash shared object file", ".sol", new ExactFileTypeMatcher(
                new byte[] {0x00, 0xBF})),
            new FileType("Alcohol 120% CD image", ".mdf", new ExactFileTypeMatcher(
                new byte[] {0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x02, 0x00, 0x01})),
            new FileType("Micrografx vector graphic file", ".drw", new ExactFileTypeMatcher(
                new byte[] {0x01, 0xFF, 0x02, 0x04, 0x03, 0x02})),
            new FileType("Adobe InDesign document", ".indd", new ExactFileTypeMatcher(
                new byte[] {0x06, 0x06, 0xED, 0xF5, 0xD8, 0x1D, 0x46, 0xE5, 0xBD, 0x31, 0xEF, 0xE7, 0xFE, 0x74, 0xB7, 0x1D})),
            new FileType("SkinCrafter skin file", ".skf", new ExactFileTypeMatcher(
                new byte[] {0x07, 0x53, 0x4B, 0x46})),
            new FileType("MultiBit Bitcoin wallet file", ".wallet", new ExactFileTypeMatcher(
                new byte[] {0x0A, 0x16, 0x6F, 0x72, 0x67, 0x2E, 0x62, 0x69, 0x74, 0x63, 0x6F, 0x69, 0x6E, 0x2E, 0x70, 0x72})),
            new FileType("Adobe encapsulated PostScript file", ".eps", new ExactFileTypeMatcher(
                new byte[] {0x25, 0x21, 0x50, 0x53, 0x2D, 0x41, 0x64, 0x6F, 0x62, 0x65, 0x2D, 0x33, 0x2E,
                    0x30, 0x20, 0x45, 0x50, 0x53, 0x46, 0x2D, 0x33, 0x20, 0x30})),
            new FileType("vCard file", ".vcf", new ExactFileTypeMatcher(
                new byte[] {0x42, 0x45, 0x47, 0x49, 0x4E, 0x3A, 0x56, 0x43, 0x41, 0x52, 0x44, 0x0D, 0x0A})),
            new FileType("RagTime document file", ".rtd", new ExactFileTypeMatcher(
                new byte[] {0x43, 0x23, 0x2B, 0x44, 0xA4, 0x43, 0x4D, 0xA5, 0x48, 0x64, 0x72})),
            new FileType("Inno Setup Uninstall Log file", ".dat", new ExactFileTypeMatcher(
                new byte[] {0x49, 0x6E, 0x6E, 0x6F, 0x20, 0x53, 0x65, 0x74, 0x75, 0x70,
                    0x20, 0x55, 0x6E, 0x69, 0x6E, 0x73, 0x74, 0x61, 0x6C, 0x6C, 0x20,
                    0x4C, 0x6F, 0x67, 0x20, 0x28, 0x62, 0x29})),
            new FileType("KGB archive", ".kgb", new ExactFileTypeMatcher(
                new byte[] {0x4B, 0x47, 0x42, 0x5F, 0x61, 0x72, 0x63, 0x68, 0x20, 0x2D})),
            new FileType("Mozilla archive", ".mar", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x41, 0x52, 0x31, 0x00})),
            new FileType("Visual Studio .NET Solution file", ".sln", new ExactFileTypeMatcher(
                new byte[] {0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x56, 0x69, 0x73,
                    0x75, 0x61, 0x6C, 0x20, 0x53, 0x74, 0x75, 0x64, 0x69, 0x6F, 0x20, 0x53, 0x6F, 0x6C,
                    0x75, 0x74, 0x69, 0x6F, 0x6E, 0x20, 0x46, 0x69, 0x6C, 0x65})),
            new FileType("TomTom traffic data file", ".dat", new ExactFileTypeMatcher(
                new byte[] {0x4E, 0x41, 0x56, 0x54, 0x52, 0x41, 0x46, 0x46, 0x49, 0x43})),
            new FileType("NES Sound file", ".nsf", new ExactFileTypeMatcher(
                new byte[] {0x4E, 0x45, 0x53, 0x4D, 0x1A, 0x01})),
            new FileType("OpenType font file", ".otf", new ExactFileTypeMatcher(
                new byte[] {0x4F, 0x54, 0x54, 0x4F, 0x00})),
            new FileType("Windows 64-bit memory dump", ".dmp", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x41, 0x47, 0x45, 0x44, 0x55, 0x36, 0x34})),
            new FileType("Windows memory dump", ".dmp", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x41, 0x47, 0x45, 0x44, 0x55, 0x4D, 0x50})),
            new FileType("PAX password protected bitmap", ".pax", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x41, 0x58})),
            new FileType("Open Publication Structure eBook file", ".epub",
                new FuzzyFileTypeMatcher(new byte?[] {
                    0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x16, 0x08, 0x00, 0x00, 
                    null, null, null, null, null, null, null, null, null, null,
                    null, null, null, null, null, null, null, null, null, null,
                    0x6D, 0x69, 0x6D, 0x65, 0x74, 0x79, 0x70, 0x65, 0x61, 0x70,
                    0x70, 0x6C, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x2F, 
                    0x65, 0x70, 0x75, 0x62, 0x2B, 0x7A, 0x69, 0x70, 0x50, 0x4B})),
            new FileType("Norton Disk Doctor undo file", ".dat", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x4E, 0x43, 0x49, 0x55, 0x4E, 0x44, 0x4F})),
            new FileType("Microsoft® Windows® User State Migration Tool", ".dat", new ExactFileTypeMatcher(
                new byte[] {0x50, 0x4D, 0x4F, 0x43, 0x43, 0x4D, 0x4F, 0x43})),
            new FileType("Outlook/Exchange message subheader", ".msg", new RangeFileTypeMatcher(
                new ExactFileTypeMatcher(
                    new byte[] { 0x52, 0x00, 0x6F, 0x00, 0x6F, 0x00, 0x74, 0x00, 0x20, 0x00, 0x45,
                        0x00, 0x6E, 0x00, 0x74, 0x00, 0x72, 0x00, 0x79, 0x00 }), 512)),
            new FileType("Shareaza thumbnail", ".dat", new ExactFileTypeMatcher(
                new byte[] {0x52, 0x41, 0x5A, 0x41, 0x54, 0x44, 0x42, 0x31})),
            new FileType("Google WebP image file", ".webp",
                new FuzzyFileTypeMatcher(new byte?[] {
                    0x52, 0x49, 0x46, 0x46, null, null, null, null, 0x57, 0x45, 0x42, 0x50})),
            new FileType("ZOO compressed archive", ".zoo", new ExactFileTypeMatcher(
                new byte[] {0x5A, 0x4F, 0x4F, 0x20})),
            new FileType("Dial-up networking file", ".dun", new ExactFileTypeMatcher(
                new byte[] {0x5B, 0x50, 0x68, 0x6F, 0x6E, 0x65, 0x5D})),
            new FileType("Apple Core Audio File", ".caf", new ExactFileTypeMatcher(
                new byte[] {0x63, 0x61, 0x66, 0x66})),
            new FileType("Macintosh encrypted Disk image (v1)", ".dmg", new ExactFileTypeMatcher(
                new byte[] {0x63, 0x64, 0x73, 0x61, 0x65, 0x6E, 0x63, 0x72})),
            new FileType("Virtual PC Virtual HD image", ".vhd", new ExactFileTypeMatcher(
                new byte[] {0x63, 0x6F, 0x6E, 0x65, 0x63, 0x74, 0x69, 0x78})),
            new FileType("Macintosh encrypted Disk image (v2)", ".dmg", new ExactFileTypeMatcher(
                new byte[] {0x65, 0x6E, 0x63, 0x72, 0x63, 0x64, 0x73, 0x61})),
            new FileType("GIMP image file", ".xcf", new ExactFileTypeMatcher(
                new byte[] {0x67, 0x69, 0x6d, 0x70, 0x20, 0x78, 0x63, 0x66, 0x20})),
            new FileType("MultiBit Bitcoin wallet information file", ".info", new ExactFileTypeMatcher(
                new byte[] {0x6D, 0x75, 0x6C, 0x74, 0x69, 0x42, 0x69, 0x74, 0x2E, 0x69, 0x6E, 0x66, 0x6F})),
            new FileType("1Password 4 Cloud Keychain encrypted data", string.Empty, new ExactFileTypeMatcher(
                new byte[] {0x6F, 0x70, 0x64, 0x61, 0x74, 0x61, 0x30, 0x31})),
            new FileType("PowerBASIC Debugger Symbols file", ".pdb", new ExactFileTypeMatcher(
                new byte[] {0x73, 0x7A, 0x65, 0x7A})),
            new FileType("eXtensible ARchive file", ".xar", new ExactFileTypeMatcher(
                new byte[] {0x78, 0x61, 0x72, 0x21})),
            new FileType("Windows application log", ".lgc", new ExactFileTypeMatcher(
                new byte[] {0x7B, 0x0D, 0x0A, 0x6F, 0x20})),
            new FileType("Microsoft Windows Mobile personal note file", ".pwi", new ExactFileTypeMatcher(
                new byte[] {0x7B, 0x5C, 0x70, 0x77, 0x69})),
            new FileType("Kodak Cineon image file", ".cin", new ExactFileTypeMatcher(
                new byte[] {0x80, 0x2A, 0x5F, 0xD7})),
            new FileType("Acronis True Image file (early versions)", ".tib", new ExactFileTypeMatcher(
                new byte[] {0xB4, 0x6E, 0x68, 0x44})),
            new FileType("Acronis True Image file (current versions)", ".tib", new ExactFileTypeMatcher(
                new byte[] {0xCE, 0x24, 0xB9, 0xA2, 0x20, 0x00, 0x00, 0x00})),
            new FileType("Norton Anti-Virus quarantined virus file", string.Empty, new ExactFileTypeMatcher(
                new byte[] {0xCD, 0x20, 0xAA, 0xAA, 0x02, 0x00, 0x00, 0x00})),
            new FileType("Windows graphics metafile", ".wmf", new ExactFileTypeMatcher(
                new byte[] {0xD7, 0xCD, 0xC6, 0x9A})),
            new FileType("Bitcoin-Qt blockchain block file", ".dat", new ExactFileTypeMatcher(
                new byte[] {0xF9, 0xBE, 0xB4, 0xD9})),
            new FileType("XZ archive file", ".xz", new ExactFileTypeMatcher(
                new byte[] {0xFD, 0x37, 0x7A, 0x58, 0x5A, 0x00})),
            new FileType("MS Publisher file subheader", ".pub", new RangeFileTypeMatcher(
                new ExactFileTypeMatcher(
                    new byte[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x02 }), 512)),
            new FileType("Windows MSinfo file", ".mof", new ExactFileTypeMatcher(
                new byte[] {0xFF, 0xFE, 0x23, 0x00, 0x6C, 0x00, 0x69, 0x00, 0x6E, 0x00, 0x65, 0x00, 0x20, 0x00, 0x31, 0x00})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
            //new FileType("", ".", new ExactFileTypeMatcher(
            //    new byte[] {})),
        };
    }
}

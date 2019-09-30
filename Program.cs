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
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace found.Recovery
{
    static class Program
    {
        internal static Font cascadia;

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadFontFromRes();
            Application.Run(new frmMain());
        }
        
        static void LoadFontFromRes()
        {
            string _res = "found.Recovery.Cascadia.ttf";
            Stream _fntStr = Assembly.GetExecutingAssembly().GetManifestResourceStream(_res);
            byte[] _fntdat = new byte[_fntStr.Length];
            IntPtr _d = Marshal.AllocCoTaskMem((int)_fntStr.Length);
            PrivateFontCollection privateFont = new PrivateFontCollection();
            _fntStr.Read(_fntdat, 0, (int)_fntStr.Length);
            Marshal.Copy(_fntdat, 0, _d, (int)_fntStr.Length);
            privateFont.AddMemoryFont(_d, (int)_fntStr.Length);
            _fntStr.Close();
            Marshal.FreeCoTaskMem(_d);
            cascadia = new Font(privateFont.Families[0], 9, FontStyle.Regular);
        }

    }
}

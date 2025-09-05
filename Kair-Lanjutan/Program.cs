using System;
using System.Windows.Forms;

namespace Kair_Lanjutan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inisialisasi konfigurasi modern untuk .NET 6+
            ApplicationConfiguration.Initialize();

            // Jalankan FormHome melalui Singleton instance
            Application.Run(FormHome.Instance);
        }
    }
}

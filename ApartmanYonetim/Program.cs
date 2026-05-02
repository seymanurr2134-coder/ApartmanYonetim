using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApartmanYonetim.Forms;

namespace ApartmanYonetim
{
    internal static class Program
    {
        public static string AktifKullaniciAdSoyad;
        public static int AktifKullaniciId;
        public static int AktifDaireId;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
        public static class AktifKullanici
        {
            public static int Id;
            public static string AdSoyad;
            public static string Email;
        }

    }
}

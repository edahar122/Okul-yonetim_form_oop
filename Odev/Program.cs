using Odev.OgrenciDosyasý;
using static Odev.OgrenciDosyasý.Ogrenci;

namespace Odev
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ornek veriler
            List<string> secilenDersler1 = new List<string> { "Matematik", "Fizik", "Programlama" };
            Ogrenci ogrenci1 = new Ogrenci("Ahmet", "Yýlmaz", "12345678901", "2000-05-15", "Erkek", "Bilgisayar Mühendisliði", secilenDersler1);

            List<string> secilenDersler2 = new List<string> { "Biyoloji", "Kimya", "Týp Terminolojisi" };
            Ogrenci ogrenci2 = new Ogrenci("Zeynep", "Kaya", "98765432109", "1998-10-22", "Kadýn", "Týp", secilenDersler2);

            List<string> secilenDersler3 = new List<string> { "Devre Analizi", "Elektromanyetik Alanlar", "Mikroiþlemciler" };
            Ogrenci ogrenci3 = new Ogrenci("Mehmet", "Demir", "45678912345", "1995-07-30", "Erkek", "Elektrik-Elektronik Mühendisliði", secilenDersler3);

            OgrenciList.OgrenciEkle(ogrenci1);
            OgrenciList.OgrenciEkle(ogrenci2);
            OgrenciList.OgrenciEkle(ogrenci3);
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
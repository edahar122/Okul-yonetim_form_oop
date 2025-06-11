namespace Odev.OgrenciDosyası
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public string DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Bolum { get; set; }
        public List<string> Dersler { get; set; } = new List<string>();

        public Ogrenci(string ad, string soyad, string tcKimlikNo, string dogumTarihi, string cinsiyet, string bolum, List<string> dersler) {
            Ad = ad;
            Soyad = soyad;
            TcKimlikNo = tcKimlikNo;
            DogumTarihi = dogumTarihi;
            Cinsiyet = cinsiyet;
            Bolum = bolum;
            Dersler = dersler;
        }

        public static class OgrenciList{
            public static List<Ogrenci> Ogrenciler { get; private set; } = new List<Ogrenci>();

            public static void OgrenciEkle(Ogrenci ogrenci) {
                Ogrenciler.Add(ogrenci);
            }
        }

    }
}

using Odev.OgrenciEkle;
using System.Data;
using static Odev.OgrenciDosyası.Ogrenci;

namespace Odev.OgrenciDosyası {
    public partial class Istatistikler : Form {
        public Istatistikler() {
            InitializeComponent();
            OgrencileriGoster();
        }

        private void OgrencileriGoster() {
            label1.Text = $"Toplam Öğrenci Sayısı: {OgrenciList.Ogrenciler.Count}"; 
            //toplam ogrenci sayisi

            int erkekSayisi = OgrenciList.Ogrenciler.Count(ogrenci => ogrenci.Cinsiyet == "Erkek");
            int kadinSayisi = OgrenciList.Ogrenciler.Count(ogrenci => ogrenci.Cinsiyet == "Kadın");
            //erkek-kadin sayisi

            progressBarErkek.Value = (int)((double)erkekSayisi / OgrenciList.Ogrenciler.Count * 100);
            progressBarKadin.Value = (int)((double)kadinSayisi / OgrenciList.Ogrenciler.Count * 100);
            //erkek-kadin orani

            listBoxDogumYili.Items.Clear();

            var dogumYiliGruplama = OgrenciList.Ogrenciler
                .GroupBy(ogrenci => ogrenci.DogumTarihi.Substring(0, 4))
                .Select(g => new { Yil = g.Key, OgrenciSayisi = g.Count() })
                .ToList();
            //dogum yili gruplama

            foreach (var item in dogumYiliGruplama) {
                listBoxDogumYili.Items.Add($"Yıl: {item.Yil} - Öğrenci Sayısı: {item.OgrenciSayisi}");
            }
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e) {
            OgrenciEkleForm form = new OgrenciEkleForm();
            form.Show();
            this.Hide();
        }

        private void ogrenciListeleToolStripMenuItem_Click(object sender, EventArgs e) {
            OgrenciListele form = new OgrenciListele();
            form.Show();
            this.Hide();
        }
    }
}
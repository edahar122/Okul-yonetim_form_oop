using Odev.OgrenciEkle;
using static Odev.OgrenciDosyası.Ogrenci;
namespace Odev.OgrenciDosyası
{
    public partial class OgrenciListele : Form {
        public OgrenciListele() {
            InitializeComponent();
            OgrencileriListele();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e) {
            string searchText = textBox1.Text.ToLower();
            dataGridView1.Rows.Clear();

            foreach (var ogrenci in OgrenciList.Ogrenciler) {
                if (ogrenci.Ad.ToLower().Contains(searchText))
                {
                    dataGridView1.Rows.Add(
                        ogrenci.Ad,
                        ogrenci.Soyad,
                        ogrenci.TcKimlikNo,
                        ogrenci.DogumTarihi,
                        ogrenci.Cinsiyet,
                        ogrenci.Bolum,
                        string.Join(", ", ogrenci.Dersler)
                    );
                }
            }
        }

        private void OgrencileriListele() {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Ad", "Ad");  //gerekli sütunların yaratılması
            dataGridView1.Columns.Add("Soyad", "Soyad");
            dataGridView1.Columns.Add("TC", "TC Kimlik No");
            dataGridView1.Columns.Add("DogumTarihi", "Doğum Tarihi");
            dataGridView1.Columns.Add("Cinsiyet", "Cinsiyet");
            dataGridView1.Columns.Add("Bolum", "Bölüm");
            dataGridView1.Columns.Add("Dersler", "Dersler");

            foreach (var ogrenci in OgrenciList.Ogrenciler) {  
                //lsitedeki tüm öğrencilerin yerleştirilmesi
                dataGridView1.Rows.Add(
                    ogrenci.Ad,
                    ogrenci.Soyad,
                    ogrenci.TcKimlikNo,
                    ogrenci.DogumTarihi,
                    ogrenci.Cinsiyet,
                    ogrenci.Bolum,
                    string.Join(", ", ogrenci.Dersler)
                );
            }

            dataGridView1.AllowUserToAddRows = true;  
            //güncelleme silme vb. gibi işlemler için ayarlar
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e) {
            OgrenciEkleForm ogrenci = new OgrenciEkleForm();
            ogrenci.Show();
            this.Hide();
        }

        private void ıstatistiklerToolStripMenuItem_Click(object sender, EventArgs e) {
            Istatistikler form = new Istatistikler();
            form.Show();
            this.Hide();
        }
    }
}

using Odev.OgrenciDosyası;
using static Odev.OgrenciDosyası.Ogrenci;

namespace Odev.OgrenciEkle
{
    public partial class OgrenciEkleForm : Form {
        public OgrenciEkleForm() {
            InitializeComponent();
        }

        private void OgrenciEkle_Click(object sender, EventArgs e) {
            try {
                string ad = textBox1.Text.Trim(); //verilerin alınması
                string soyad = textBox2.Text.Trim();
                string numara = textBox3.Text.Trim();

                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(numara)) { 
                    //eger bu alanlar bos ise hata mesaji verir
                    MessageBox.Show("Ad soyad ve numara boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBox1.SelectedItem == null) {   //bölüm seçimi boş ise hata verir
                    MessageBox.Show("Lütfen bir bölüm seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cinsiyet = ErkekCheck.Checked ? "Erkek" : "Kadın";
                string dogumTarihi = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string bolum = comboBox1.SelectedItem.ToString();

                List<string> secilenDersler = new List<string>();
                foreach (var item in checkedListBox1.CheckedItems) {  
                    secilenDersler.Add(item.ToString());
                }

                if (secilenDersler.Count == 0) {    // ders seçimi boş ise hata verir
                    MessageBox.Show("En az bir ders seçmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Ogrenci ogrenci = new Ogrenci(ad, soyad, numara, dogumTarihi, cinsiyet, bolum, secilenDersler);
                OgrenciList.OgrenciEkle(ogrenci);

                MessageBox.Show("Öğrenci eklendi: " + ogrenci.Ad, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {  //genel hata kontrolü
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void ogrenciListeleToolStripMenuItem_Click(object sender, EventArgs e) {
            OgrenciListele form = new OgrenciListele();
            form.Show();
            this.Hide();
        }

        private void ıstatistiklerToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Istatistikler form = new Istatistikler();
            form.Show();
            this.Hide();
        }
    }
}

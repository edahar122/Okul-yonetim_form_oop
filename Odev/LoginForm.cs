using Odev.OgrenciDosyas�;
using Odev.OgrenciEkle;

namespace Odev
{
    public partial class LoginForm : Form {
        public LoginForm() {
            /*Eda Har
              No: 16008121053
              Odev_3
              Tarih: 26.03.2025
            */
            InitializeComponent();
        }

        private string username = "admin";
        private string password = "admin";
        private string u = "eda";
        private string p = "123";

        private void loginButton_Click(object sender, EventArgs e) { //admin girisi
            try {
                if (textBox1.Text == username && textBox2.Text == password) {
                    MessageBox.Show("Ho�geldiniz(admin)");
                    OgrenciEkleForm ogrenciEkle = new OgrenciEkleForm();
                    ogrenciEkle.Show();
                    this.Hide();
                }
                else if (textBox1.Text == u && textBox2.Text == p) { //kullanici girisi
                    MessageBox.Show("Ho�geldiniz(kullanici)");
                    Istatistikler istatistik = new Istatistikler();
                    istatistik.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�");
                }
            }
            catch (Exception ex) { //hata kontrol�
                MessageBox.Show("Bir hata olu�tu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
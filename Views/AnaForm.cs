using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;


namespace WindowsFormsApp1
{
    public partial class AnaForm : Form
    {

        public AnaForm()
        {
            InitializeComponent();
        }


        private void kitap_ekle_Click(object sender, EventArgs e)
        {
            Kitap_Ekle kitap_Ekle = new Kitap_Ekle();
            kitap_Ekle.Show();
        }

        private void emanet_ekle_Click(object sender, EventArgs e)
        {
            EmanetEkle emanetEkle = new EmanetEkle();
            emanetEkle.Show();
        }

        private void üye_ekle_Click(object sender, EventArgs e)
        {
            ÜyeEkle üyeEkle = new ÜyeEkle();
            
            üyeEkle.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void kitap_listele_Click(object sender, EventArgs e)
        {
            KitaplarıListele kitaplarıListele = new KitaplarıListele();
            kitaplarıListele.Show();
        }

        private void emanet_listele_Click(object sender, EventArgs e)
        {
            Emanetler emanetler = new Emanetler();
            emanetler.Show();
        }

        private void üye_listele_Click(object sender, EventArgs e)
        {
            Üyeler üyeler = new Üyeler();
            üyeler.Show();
        }

        private void kullanıcıdegistir_menu_Click(object sender, EventArgs e)
        {
            GirişYap girişYap = new GirişYap();
            this.Hide();
            girişYap.Show();
        }
    }
}

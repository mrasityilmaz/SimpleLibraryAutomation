using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class Kitap_Ekle : Form
    {
        IController<Books> _booksController;
        public Kitap_Ekle()
        {
            InitializeComponent();
            _booksController = new EFController<Books>();
        }

        private void iptal_kitapekle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydet_kitapekle_Click(object sender, EventArgs e)
        {
            //label8 id doldurduğumuz labelin default texti,
            //eğer değişmiş ise kullanıcı Kitap bilgilerini güncellemekte olduğu için güncelleme fonksiyonuna yönlendiriyoruz. 
            if (kitapekle_id.Text != "label8")
            {
                _booksController.Update(new Books {
                       Kitap_adi=   kitap_adı.Text,
                       Yazar_adi=   yazar_adı.Text,
                       Baski_yili=  baskı_yılı.Text,
                       Sayfa_sayisi=sayfa_sayısı.Text,
                       Dili=        dili.Text,
                       Yayin_evi=   yayın_evi.Text,
                       Hakkinda=    kitap_hakkında.Text,
                       ID=          Convert.ToInt32(kitapekle_id.Text)
                       }); 
            }
            else//eğer id atadığımız text değişmemişse ilk kayıt işlemine yönlendiriyoruz.
            {
                //Formdan aldığımız text değerlerini ConnectionData sınıfımızdaki Sql kayıt methodumuza gönderiyoruz.
                _booksController.Add(new Books
                {
                    Kitap_adi = kitap_adı.Text,
                    Yazar_adi = yazar_adı.Text,
                    Baski_yili = baskı_yılı.Text,
                    Sayfa_sayisi = sayfa_sayısı.Text,
                    Dili = dili.Text,
                    Yayin_evi = yayın_evi.Text,
                    Hakkinda = kitap_hakkında.Text,
                    
                });
            }





            this.Close();

        }

        private void kitapekle_sil_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(kitapekle_id.Text);
            _booksController.Delete(ID);//KitaplarıListele formunun Datagridviewden aldığımız id değerini kullanıp kitabı silebiliyoruz
            this.Hide();
  


        }

        private void Kitap_Ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            KitaplarıListele kitaplarıListele = new KitaplarıListele();

            kitaplarıListele.Show();
        }

        private void Kitap_Ekle_Load(object sender, EventArgs e)
        {
         
                kaydet_kitapekle.Enabled = false;
            
        }


        private void kitap_adı_KeyPress(object sender, KeyPressEventArgs e)
        {
            kaydet_kitapekle.Enabled = true;
        }

        private void kitap_adı_TextChanged(object sender, EventArgs e)
        {
            if(kitap_adı.Text.Trim() == "" || kitap_adı.Text.Trim() == null)
            {
                kaydet_kitapekle.Enabled = false;
            }
        }
    }
}

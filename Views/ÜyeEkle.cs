using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class ÜyeEkle : Form
    {
        IController<Members> _memberscontroller;
        public ÜyeEkle()
        {
            InitializeComponent();
            _memberscontroller = new EFController<Members>();
        }

        private void iptal_üyeekle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydet_üyeekle_Click(object sender, EventArgs e)
        {
            if (adı_üyeekle.Text != "" && soyadı_üyeekle.Text != "" && telefon_üyeekle.Text != "" && eposta_üyeekle.Text != "" && adres_üyeekle.Text != "")
            {

                //label5 id doldurduğumuz labelin default texti,
                //eğer değişmiş ise kullanıcı üye bilgilerini güncellemekte olduğu için güncelleme fonksiyonuna yönlendiriyoruz. 
                if (üyeekle_id.Text != "label5")
                {
                    int ID = Convert.ToInt32(üyeekle_id.Text);
                    _memberscontroller.Update(new Members
                    {
                        Adi = adı_üyeekle.Text,
                        Soyadi = soyadı_üyeekle.Text,
                        Telefon = telefon_üyeekle.Text,
                        Eposta = eposta_üyeekle.Text,
                        Adres = adres_üyeekle.Text,
                        ID = ID
                    }
                        );
                }
                else//eğer id atadığımız text değişmemişse ilk kayıt işlemine yönlendiriyoruz.
                {
                    //Formdan aldığımız text değerlerini ConnectionData sınıfımızdaki Sql kayıt methodumuza gönderiyoruz.
                    _memberscontroller.Add(new Members
                    {
                        Adi = adı_üyeekle.Text,
                        Soyadi = soyadı_üyeekle.Text,
                        Telefon = telefon_üyeekle.Text,
                        Eposta = eposta_üyeekle.Text,
                        Adres = adres_üyeekle.Text,

                    }
                    );
                }





                this.Close();
            }
            else
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz!");
            }



        }

        private void sil_üyeekle_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(üyeekle_id.Text);
            _memberscontroller.Delete(ID);
           //Üyeler formunun Datagridviewden aldığımız id değerini kullanıp üyeyi silebiliyoruz
            this.Close();//Daha sonra açık olan üye ekle formunu kapatıyoruz.
        }

        private void ÜyeEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Üyeler üyeler = new Üyeler();
            üyeler.Show();
        }



        private void ÜyeEkle_Load(object sender, EventArgs e)
        {

        }


    }
}


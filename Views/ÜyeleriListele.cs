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
    public partial class Üyeler : Form
    {
        IController<Members> _memberscontroller;
        public Üyeler()
        {
            InitializeComponent();
            _memberscontroller = new EFController<Members>();
        }

        private void Üyeler_Load(object sender, EventArgs e)
        {
            //Datagridview için kendi seçtiğimiz özel renk değerlerini atıyoruz.
            üyelerlist_üyeler.BackgroundColor = Color.FromArgb(131, 197, 190);
            üyelerlist_üyeler.GridColor = Color.FromArgb(40, 61, 59);
            //




            üyelerlist_üyeler.DataSource = _memberscontroller.GetAll().ToList();


            //Datagridview'imizin başlık isimlerini değiştiriyoruz ve genişlik değerlerini atıyoruz.
            üyelerlist_üyeler.Columns[0].HeaderText = "Id"; üyelerlist_üyeler.Columns[0].Width = 30;
            üyelerlist_üyeler.Columns[1].HeaderText = "Ad"; üyelerlist_üyeler.Columns[1].Width = 150;
            üyelerlist_üyeler.Columns[2].HeaderText = "Soyad"; üyelerlist_üyeler.Columns[2].Width = 150;
            üyelerlist_üyeler.Columns[3].HeaderText = "Telefon"; üyelerlist_üyeler.Columns[3].Width = 150;
            üyelerlist_üyeler.Columns[4].HeaderText = "E-Posta"; üyelerlist_üyeler.Columns[4].Width = 150;
            üyelerlist_üyeler.Columns[5].HeaderText = "Adres"; üyelerlist_üyeler.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;







        }

        private void üyeekle_üyeler_Click(object sender, EventArgs e)
        {
            ÜyeEkle üyeEkle = new ÜyeEkle();//Üye ekle formunu açıyoruz
            üyeEkle.Show();
        }

        private void Üyeler_Activated(object sender, EventArgs e)
        {

            //Form her aktif olduğunda yada yeniden aktif form değeri kazandığında bir güncelleme varsa
            //bunu yüklemek için tekrar datagridviewe gelen veriyi güncelliyoruz.
            üyelerlist_üyeler.DataSource = _memberscontroller.GetAll().ToList();


        }

        private void üyedüzenle_üyeler_Click(object sender, EventArgs e)
        {
            //Başka bir formdan üye düzenle modu açtığımız için üye ekle formunu üye düzenleme formu gibi düzenliyoruz. 
            ÜyeEkle üyeEkle = new ÜyeEkle();
            üyeEkle.üyeekle_baslik.Text = "Üye Düzenle";
            üyeEkle.Text = "Üye Düzenle";                       //Düzenlenen alanların modifiers değeri onlara bu şekilde ulaşmak için
            üyeEkle.kaydet_üyeekle.Text = "GÜNCELLE";          //public olarak değiştirilmiştir.
            üyeEkle.sil_üyeekle.Visible = true;               //Sil butonuna üye eklerken gerek olmadığı için üye düzenlerken aktif hale getiriyoruz. 







            //        

            //BU KISIM İSTEDİĞİMİZ VERİYİ DİREKT OLARAK DATAGRİDVİEWDEKİ BELİRLİ ALANLAR ALIR.
            //****************************************************************************
            üyeEkle.üyeekle_id.Text = üyelerlist_üyeler.CurrentRow.Cells[0].Value.ToString();//Eğer kullanıcı üyeyi düzenlerken silmek isterse diye
                                                                                             //Datagridviewden id bilgisinide alıp diğer formda görünmez olan bir label'a atıyoruz. 
            üyeEkle.adı_üyeekle.Text = üyelerlist_üyeler.CurrentRow.Cells[1].Value.ToString();
            üyeEkle.soyadı_üyeekle.Text = üyelerlist_üyeler.CurrentRow.Cells[2].Value.ToString();
            üyeEkle.telefon_üyeekle.Text = üyelerlist_üyeler.CurrentRow.Cells[3].Value.ToString();
            üyeEkle.eposta_üyeekle.Text = üyelerlist_üyeler.CurrentRow.Cells[4].Value.ToString();
            üyeEkle.adres_üyeekle.Text = üyelerlist_üyeler.CurrentRow.Cells[5].Value.ToString();
            this.Close();
            üyeEkle.Show();

            //****************************************************************************


        }

        private void üyesil_üyelert_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(üyelerlist_üyeler.CurrentRow.Cells[0].Value);
            //Silmek istediğimiz üyenin id'sini ConnectionData sınıfımızda ürettiğimiz silme fonksiyonuna iletiyoruz.
            _memberscontroller.Delete(ID);
            üyelerlist_üyeler.DataSource = _memberscontroller.GetAll().ToList();
        }

        private void kaydet_üyeler_Click(object sender, EventArgs e)
        {
            this.Close();//Formu kapatıyoruz.
        }
    }
}

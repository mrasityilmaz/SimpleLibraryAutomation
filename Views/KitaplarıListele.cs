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
    public partial class KitaplarıListele : Form
    {

        IController<Books> _booksController;
        public KitaplarıListele()
        {
            InitializeComponent();
            _booksController = new EFController<Books>();
            kitaplar_kitaplist.DataSource = null;
            kitaplar_kitaplist.DataSource = _booksController.GetAll().ToList();

        }




        private void KitaplarıListele_Load(object sender, EventArgs e)
        {
            //Datagridview için kendi seçtiğimiz özel renk değerlerini atıyoruz.
            kitaplar_kitaplist.BackgroundColor = Color.FromArgb(131, 197, 190);
            kitaplar_kitaplist.GridColor = Color.FromArgb(40, 61, 59);



            kitaplar_kitaplist.DataSource = _booksController.GetAll().ToList();




            //Datagridview'imizin başlık isimlerini değiştiriyoruz ve genişlik değerlerini atıyoruz.
            kitaplar_kitaplist.Columns[0].HeaderText = "Id"; kitaplar_kitaplist.Columns[0].Width = 30;
            kitaplar_kitaplist.Columns[1].HeaderText = "Kitap Adı"; kitaplar_kitaplist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kitaplar_kitaplist.Columns[2].HeaderText = "Yazar Adı"; kitaplar_kitaplist.Columns[2].Width = 150;
            kitaplar_kitaplist.Columns[3].HeaderText = "Baskı Yılı"; kitaplar_kitaplist.Columns[3].Width = 80;
            kitaplar_kitaplist.Columns[4].HeaderText = "Sayfa Sayısı"; kitaplar_kitaplist.Columns[4].Width = 80;
            kitaplar_kitaplist.Columns[5].HeaderText = "Dili"; kitaplar_kitaplist.Columns[5].Width = 80;
            kitaplar_kitaplist.Columns[6].HeaderText = "Yayın Evi"; kitaplar_kitaplist.Columns[6].Width = 100;
            kitaplar_kitaplist.Columns[7].HeaderText = "Hakkında"; kitaplar_kitaplist.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;




        }



        private void kitapekle_kitaplist_Click(object sender, EventArgs e)
        {
            Kitap_Ekle kitap_Ekle = new Kitap_Ekle();
            
            kitap_Ekle.Show();
            this.Close();
        }





        //private void KitaplarıListele_Activated(object sender, EventArgs e)
        //{

        //    //Form her aktif olduğunda yada yeniden aktif form değeri kazandığında bir güncelleme varsa
        //    //bunu yüklemek için tekrar datagridviewe gelen veriyi güncelliyoruz.
        //    kitaplar_kitaplist.DataSource = _booksController.GetAll().Books.ToList();
            


        //}






        private void kitapdüzenle_kitaplist_Click(object sender, EventArgs e)
        {
            if (kitaplar_kitaplist.RowCount > 0)
            {
                //Başka bir formdan kitap düzenle modu açtığımız için kitap ekle formunu kitap düzenleme formu gibi düzenliyoruz. 
                Kitap_Ekle kitap_Ekle = new Kitap_Ekle();
                kitap_Ekle.kitapekle_baslik.Text = "Kitap Düzenle";
                kitap_Ekle.Text = "Kitap Düzenle";                       //Düzenlenen alanların modifiers değeri onlara bu şekilde ulaşmak için
                kitap_Ekle.kaydet_kitapekle.Text = "GÜNCELLE";          //public olarak değiştirilmiştir.
                kitap_Ekle.kitapekle_sil.Visible = true;               //Sil butonuna kitap eklerken gerek olmadığı için üye düzenlerken aktif hale getiriyoruz. 






                //        

                //BU KISIM İSTEDİĞİMİZ VERİYİ DİREKT OLARAK DATAGRİDVİEWDEKİ BELİRLİ ALANLAR ALIR.
                //****************************************************************************
                kitap_Ekle.kitapekle_id.Text = kitaplar_kitaplist.CurrentRow.Cells[0].Value.ToString();//Eğer kullanıcı kitabı düzenlerken silmek isterse diye
                                                                                                       //Datagridviewden id bilgisinide alıp diğer formda görünmez olan bir label'a atıyoruz. 
                kitap_Ekle.kitap_adı.Text = kitaplar_kitaplist.CurrentRow.Cells[1].Value.ToString();
                kitap_Ekle.yazar_adı.Text = kitaplar_kitaplist.CurrentRow.Cells[2].Value.ToString();
                kitap_Ekle.baskı_yılı.Text = kitaplar_kitaplist.CurrentRow.Cells[3].Value.ToString();
                kitap_Ekle.sayfa_sayısı.Text = kitaplar_kitaplist.CurrentRow.Cells[4].Value.ToString();
                kitap_Ekle.dili.Text = kitaplar_kitaplist.CurrentRow.Cells[5].Value.ToString();
                kitap_Ekle.yayın_evi.Text = kitaplar_kitaplist.CurrentRow.Cells[4].Value.ToString();
                kitap_Ekle.kitap_hakkında.Text = kitaplar_kitaplist.CurrentRow.Cells[5].Value.ToString();

                kitap_Ekle.Show();
                this.Close();
                //****************************************************************************
            }
        }

        private void kitapsil_kitaplist_Click(object sender, EventArgs e)
        {

            if (kitaplar_kitaplist.RowCount > 0)
            {
                
                //Silmek istediğimiz kitabın id'sini ConnectionData sınıfımızda ürettiğimiz silme fonksiyonuna iletiyoruz.
                int ID = Convert.ToInt32(kitaplar_kitaplist.CurrentRow.Cells[0].Value);
                _booksController.Delete(ID);


                //Form her aktif olduğunda yada yeniden aktif form değeri kazandığında bir güncelleme varsa
                //bunu yüklemek için tekrar datagridviewe gelen veriyi güncelliyoruz.
                kitaplar_kitaplist.DataSource = _booksController.GetAll().ToList();


            }

        }

        private void kaydet_kitaplist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

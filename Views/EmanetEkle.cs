using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using static WindowsFormsApp1.Program;//Program.cs dosyamızdaki sql baglantı cümlesini ekliyoruz.


namespace WindowsFormsApp1
{
    public partial class EmanetEkle : Form
    {

        
        IController<Deposits> _Controller;
        IController<Members> _MController;


        public EmanetEkle()
        {

            InitializeComponent();

            _Controller = new EFController<Deposits>();
            _MController = new EFController<Members>();

        }



        private void üyekayıt_emanetekle_Click(object sender, EventArgs e)
        {
            ÜyeEkle üyeEkle = new ÜyeEkle();
            üyeEkle.Show();
            this.Close();
        }





        private void EmanetEkle_Load(object sender, EventArgs e)
        {

            //Datetimepickerların minimum tarihleri o günkü tarihe ayarlıyoruz. Örn: min alım tarihi = O anki tarih
            alımtarih_emanetekle.MinDate = DateTime.Now;
            teslimtarih_emanetekle.MinDate = DateTime.Now;

            kaydet_emanetekle.Enabled = false;//Form açıldığında boş değerler için kayıt yapılmasına izin vermiyoruz.Textlerin değerini leave eventi ile kontrol edip aksiyon gösteriyoruz.


            EmanetAlanÜyeComboboxAutoCompleteSource();//Üye adlarını otomatik tamamlama için emanetekle formunun emanet_alan_üye combobox'ına yüklüyoruz.

            OtherComboBoxAutoCompleteSource();//emanetekle formunun sol tarafında yer alan tüm comboboxların ıtemslarını burada dolduruyoz.
        }






        private void EmanetAlanÜyeComboboxAutoCompleteSource()
        {
            //Üye adlarını otomatik tamamlama için emanetekle formunun emanet_alan_üye combobox'ına yüklüyoruz.
            foreach (var item in _MController.GetAll().ToList())
            {
                emanetalanüye__emanetekle.Items.Add(item.Adi + " " + item.Soyadi);
            }
            emanetalanüye__emanetekle.AutoCompleteCustomSource.Add(emanetalanüye__emanetekle.Items.ToString()); //Combobox'a yüklediğimiz itemleri combobox'ın custom source'ına ekliyoruz.
            emanetalanüye__emanetekle.AutoCompleteSource = AutoCompleteSource.ListItems; //ve complete source'ını listitems olarak atadık.
            emanetalanüye__emanetekle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;//son olarak otomatik tamamlama modunu suggestappend  olarak ayarlıyoruz.
        }






        private void OtherComboBoxAutoCompleteSource()
        {
            
            //emanetekle formunun sol tarafında yer alan tüm comboboxların ıtemslarını burada dolduruyoz.

            //böylece emanet eklerken kitap adı seçildiği anda kitap bilgilerinin yer aldığı tüm comboboxlar seçilen kitabın bilgilerini gösterecek

            //bu otomatik atama düzenlemesini emanet ekle formunda yapacağız. 
            //emanetekle formunun ilgili combobox'ının ıtemlerine ekliyoruz.
            foreach (var bookContent in _Controller.GetAll().ToList())
            {
                kitap_adı_emanetekle.Items.Add(bookContent.Kitap_adi);

                yazar_adı_emanetekle.Items.Add(bookContent.Yazar_adi);

                baskı_yılı_emanetekle.Items.Add(bookContent.Baski_yili);

                sayfa_sayısı_emanetekle.Items.Add(bookContent.Sayfa_sayisi);

                dili_emanetekle.Items.Add(bookContent.Dili);

                yayın_evi_emanetekle.Items.Add(bookContent.Yayin_evi);
            }


            //Combobox'a yüklediğimiz itemleri combobox'ın custom source'ına ekliyoruz.
            //ve complete source'ını listitems olarak atadık.
            //son olarak otomatik tamamlama modunu suggestappend olarak ayarlıyoruz.
            //Bu işlemleri emanet ekle formundaki kitap bilgileri içeren tüm comboboxlara uyguluyoruz.
            //Bu atamaları tek tek yapmak yerine emanetekle formundaki kitapla ilgili comboboxları bir panel içine koyup dönüyle tümüne işlem yapacağız.



            foreach (ComboBox control in emanetekle_allcombobox.Controls)//bu döngü ile kitap bilgileri içeren tüm comboboxlara tek işlemle müdahale ediyoruz.
            {


                control.AutoCompleteCustomSource.Add(control.Items.ToString());
                control.AutoCompleteSource = AutoCompleteSource.ListItems;
                control.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //Tüm comboboxları bu işlemle istediğimiz hale getirdik.
                //hepsine tek tek atamak yerine bu şekilde tek seferde yaptık.

            }
        }



        private void iptal_kitapekle_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        private void kaydet_emanetekle_Click(object sender, EventArgs e)
        {

            //Veritabanına emanet ekliyoruz
             _Controller.Add(new Deposits {
                        Kitap_adi = kitap_adı_emanetekle.Text,
    
                       Yazar_adi=   yazar_adı_emanetekle.Text,
                       Baski_yili=    Convert.ToInt32(baskı_yılı_emanetekle.Text),
                       Sayfa_sayisi=  Convert.ToInt32(sayfa_sayısı_emanetekle.Text),
                       Dili=         dili_emanetekle.Text,
                       Yayin_evi=     yayın_evi_emanetekle.Text,
                       Emanet_alan_üye=   emanetalanüye__emanetekle.Text,
                       Alis_tarihi=   alımtarih_emanetekle.Value,
                       Teslim_tarihi= teslimtarih_emanetekle.Value,
                       Emanet_notu=  emanetekle_not.Text,
                       Teslim_durumu= false
                       });


            this.Close();




        }






        private void EmanetEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Emanetler emanetlerList = new Emanetler();
            emanetlerList.Activate();
        }





        private void kitap_adı_emanetekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kitap adı değeri değiştiğinde zaten dolu olan diğer combobaxlarımın seçili kitap özelliklerini göstermesi için
            //değer her değiştiğinde diğerlerininde değerlerini değiştiriyoruz.
            foreach(ComboBox box in emanetekle_allcombobox.Controls)
            {
                //Kitap adı bilgisini zaten kullanıcı doldurduğu için onun seçilmiş
                //değerini değiştirmiyoruz.Sadece geriye kalan bilgiler için değişim yapıyoruz.
                if (box.Name != "kitap_adı_emanetekle")
                {
                    box.SelectedIndex = kitap_adı_emanetekle.SelectedIndex;//Seçilen kitabla aynı indiste bulunan diğer bilgileri
                                                                           //göstermek için kalan tüm boxların indexini kitap indexi ile aynı yapıyoruz.

                }
            }
        }












        private void kitap_adı_emanetekle_Leave(object sender, EventArgs e)
        {
            
                                                  //Combobox kontrollerine erişmek için                          
            ComboBox comboBox = (ComboBox)sender;//Evente sahip olan öğelerin geri dönderdiği senderi bir combobox'a atıyoruz.

            if(comboBox.SelectedIndex == -1 )//Eğer değer girilmezse kaydet butonu aktif olmaması için index değerini kontrol ediyoruz.
            {
                kaydet_emanetekle.Enabled = false;
            }
            else if(comboBox.SelectedIndex != -1 && emanetalanüye__emanetekle.SelectedIndex != -1)
            {
                kaydet_emanetekle.Enabled = true;
            }
          
        }

        private void emanetalanüye__emanetekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            kaydet_emanetekle.Enabled = true;
        }
    }
}



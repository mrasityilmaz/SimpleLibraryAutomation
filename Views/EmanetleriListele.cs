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
    public partial class Emanetler : Form
    {


        IController<Deposits> _Controller; 
        public Emanetler()
        {
            InitializeComponent();
  
            _Controller = new EFController<Deposits>();
        }

        private void tamam_emanetlist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emanetekle_emanetlist_Click(object sender, EventArgs e)
        {
            EmanetEkle emanetEkle = new EmanetEkle();
            emanetEkle.Show();
        }

        private void Emanetler_Load(object sender, EventArgs e)
        {   //Datagridview için kendi seçtiğimiz özel renk değerlerini atıyoruz.
            emanetler_emanetlist.BackgroundColor = Color.FromArgb(131, 197, 190);
            emanetler_emanetlist.GridColor = Color.FromArgb(40, 61, 59);



            //Datagridview'imizin başlık isimlerini değiştiriyoruz ve genişlik değerlerini atıyoruz.

            emanetler_emanetlist.DataSource = _Controller.GetAll().Where(x => x.Teslim_durumu == false).Select(x=> new {x.ID,x.Emanet_alan_üye,x.Kitap_adi,x.Alis_tarihi,x.Teslim_tarihi,x.Emanet_notu}).ToList();//Emanetleri datagridview'in datasource'una yüklüyoruz.



            emanetler_emanetlist.Columns[0].HeaderText = "Id"; emanetler_emanetlist.Columns[0].Width = 30;
            emanetler_emanetlist.Columns[1].HeaderText = "Üye Adı"; emanetler_emanetlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emanetler_emanetlist.Columns[2].HeaderText = "Kitap Adı"; emanetler_emanetlist.Columns[2].Width = 150;
            emanetler_emanetlist.Columns[3].HeaderText = "Alım Tarihi"; emanetler_emanetlist.Columns[3].Width = 150;
            emanetler_emanetlist.Columns[4].HeaderText = "Teslim Tarihi"; emanetler_emanetlist.Columns[4].Width = 150;
            emanetler_emanetlist.Columns[5].HeaderText = "Emanet Notu"; emanetler_emanetlist.Columns[5].Width = 150;






        }

        private void teslimal_emanetlist_Click(object sender, EventArgs e)
        {
            if (emanetler_emanetlist.RowCount > 0)//Listenin dolu olup olmadığını kontrol ediyoruz
            {

                //Aldığımız Id bilgisine göre emanetin teslim durumunu true yapıyoruz.
                int ID = Convert.ToInt32(emanetler_emanetlist.CurrentRow.Cells[0].Value);


                Deposits UpdateDeposit = _Controller.GetAll().FirstOrDefault(X => X.ID == ID);
                UpdateDeposit.Teslim_durumu = true;
                _Controller.Update(UpdateDeposit);

            }
            Emanetler_Activated(null, null);//Eventi bir method gibi kullanıp tekrardan çağırdık.
        }

        private void Emanetler_Activated(object sender, EventArgs e)
        {
            //Form her aktif olduğunda yada yeniden aktif form değeri kazandığında bir güncelleme varsa
            //bunu yüklemek için tekrar datagridviewe gelen veriyi güncelliyoruz.
            emanetler_emanetlist.DataSource = _Controller.GetAll().Where(x => x.Teslim_durumu == false).Select(x => new { x.ID, x.Emanet_alan_üye, x.Kitap_adi, x.Alis_tarihi, x.Teslim_tarihi, x.Emanet_notu }).ToList();//Emanetleri datagridview'in datasource'una yüklüyoruz.

        }

        private void eski_kayitlar_emanetler_Click(object sender, EventArgs e)
        {




            emanetler_emanetlist.DataSource = _Controller.GetAll().Where(x => x.Teslim_durumu == true).Select(x => new { x.ID, x.Emanet_alan_üye, x.Kitap_adi, x.Alis_tarihi, x.Teslim_tarihi, x.Emanet_notu }).ToList();//Emanetleri datagridview'in datasource'una yüklüyoruz.
            emanetler_emanetlist.Refresh();
            eski_kayitlar_emanetler.Visible = false;
            güncel_emanetler.Visible = true;
            teslimal_emanetlist.Visible = false;
            emanetekle_emanetlist.Visible = false;



        }

        private void güncel_emanetler_Click(object sender, EventArgs e)
        {



            emanetler_emanetlist.DataSource = _Controller.GetAll().Where(x => x.Teslim_durumu == false).Select(x => new { x.ID, x.Emanet_alan_üye, x.Kitap_adi, x.Alis_tarihi, x.Teslim_tarihi, x.Emanet_notu }).ToList();//Emanetleri datagridview'in datasource'una yüklüyoruz.


            eski_kayitlar_emanetler.Visible = true;
            güncel_emanetler.Visible = false;
            teslimal_emanetlist.Visible = true;
            emanetekle_emanetlist.Visible = true;

        }
    }
}
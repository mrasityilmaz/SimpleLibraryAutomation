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
using static WindowsFormsApp1.Program;//Program.cs dosyamızdaki sql baglantı cümlesini ekliyoruz.

namespace WindowsFormsApp1
{
    public partial class GirişYap : Form
    {
        UserController _userController;
        public GirişYap()
        {
            InitializeComponent();
            _userController = new UserController();
            _userController.UserAdd();
        }





        private string usernametext;
        private string passwordtext;

        private void GirişYap_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Kullanıcı Adı: rasit" + "\n" + "Şifre : yilmaz");  

            username.BackColor = Color.FromArgb(253, 251, 249);
            password.BackColor = Color.FromArgb(253, 251, 249);
            this.BackColor = Color.FromArgb(190, 188, 184);
        }





        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

                girisyap_login_Click(null, null);
            }
        }

        private void girisyap_login_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {

                usernametext = _userController.GetUsername().Trim();
                passwordtext = _userController.GetPassword().Trim();

                if (username.Text.TrimEnd() == usernametext && password.Text.TrimEnd() == passwordtext)
                {
                    AnaForm anaform = new AnaForm();


                    anaform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı yada Şifre Hatalı !");
                }



            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre aHatalı");
            }
        }

        private void cıkısyap_login_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkmak İstediğinize Emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}

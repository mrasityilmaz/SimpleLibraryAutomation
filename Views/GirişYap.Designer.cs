
namespace WindowsFormsApp1
{
    partial class GirişYap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.girisyap_login = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.cıkısyap_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisyap_login
            // 
            this.girisyap_login.BackColor = System.Drawing.Color.Transparent;
            this.girisyap_login.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.OkButton;
            this.girisyap_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.girisyap_login.FlatAppearance.BorderSize = 0;
            this.girisyap_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.girisyap_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.girisyap_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisyap_login.Location = new System.Drawing.Point(306, 400);
            this.girisyap_login.Name = "girisyap_login";
            this.girisyap_login.Size = new System.Drawing.Size(115, 34);
            this.girisyap_login.TabIndex = 2;
            this.girisyap_login.UseVisualStyleBackColor = true;
            this.girisyap_login.Click += new System.EventHandler(this.girisyap_login_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.AliceBlue;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username.Location = new System.Drawing.Point(193, 262);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(214, 23);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.AliceBlue;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(193, 331);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(214, 23);
            this.password.TabIndex = 1;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // cıkısyap_login
            // 
            this.cıkısyap_login.BackColor = System.Drawing.Color.Transparent;
            this.cıkısyap_login.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.quit;
            this.cıkısyap_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cıkısyap_login.FlatAppearance.BorderSize = 0;
            this.cıkısyap_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cıkısyap_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cıkısyap_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cıkısyap_login.Location = new System.Drawing.Point(551, 12);
            this.cıkısyap_login.Name = "cıkısyap_login";
            this.cıkısyap_login.Size = new System.Drawing.Size(35, 35);
            this.cıkısyap_login.TabIndex = 3;
            this.cıkısyap_login.UseVisualStyleBackColor = false;
            this.cıkısyap_login.Click += new System.EventHandler(this.cıkısyap_login_Click);
            // 
            // GirişYap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.LoginDesign;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.ControlBox = false;
            this.Controls.Add(this.cıkısyap_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.girisyap_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "GirişYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirişYap";
            this.Load += new System.EventHandler(this.GirişYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button girisyap_login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button cıkısyap_login;
    }
}

namespace WindowsFormsApp1
{
    partial class Kitap_Ekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kitap_adı = new System.Windows.Forms.TextBox();
            this.yazar_adı = new System.Windows.Forms.TextBox();
            this.kitap_hakkında = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kitapekle_baslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dili = new System.Windows.Forms.TextBox();
            this.yayın_evi = new System.Windows.Forms.TextBox();
            this.baskı_yılı = new System.Windows.Forms.MaskedTextBox();
            this.sayfa_sayısı = new System.Windows.Forms.MaskedTextBox();
            this.iptal_kitapekle = new System.Windows.Forms.Button();
            this.kaydet_kitapekle = new System.Windows.Forms.Button();
            this.kitapekle_sil = new System.Windows.Forms.Button();
            this.kitapekle_id = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baskı Yılı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dili:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yayın Evi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(374, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kitap Hakkında:";
            // 
            // kitap_adı
            // 
            this.kitap_adı.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitap_adı.Location = new System.Drawing.Point(137, 163);
            this.kitap_adı.Name = "kitap_adı";
            this.kitap_adı.Size = new System.Drawing.Size(202, 27);
            this.kitap_adı.TabIndex = 0;
            this.kitap_adı.TextChanged += new System.EventHandler(this.kitap_adı_TextChanged);
            this.kitap_adı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitap_adı_KeyPress);
            // 
            // yazar_adı
            // 
            this.yazar_adı.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yazar_adı.Location = new System.Drawing.Point(137, 211);
            this.yazar_adı.Name = "yazar_adı";
            this.yazar_adı.Size = new System.Drawing.Size(202, 27);
            this.yazar_adı.TabIndex = 1;
            this.yazar_adı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitap_adı_KeyPress);
            // 
            // kitap_hakkında
            // 
            this.kitap_hakkında.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kitap_hakkında.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitap_hakkında.Location = new System.Drawing.Point(378, 189);
            this.kitap_hakkında.Name = "kitap_hakkında";
            this.kitap_hakkında.Size = new System.Drawing.Size(347, 241);
            this.kitap_hakkında.TabIndex = 6;
            this.kitap_hakkında.Text = "";
            this.kitap_hakkında.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitap_adı_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.kitapekle_baslik);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 121);
            this.panel1.TabIndex = 14;
            // 
            // kitapekle_baslik
            // 
            this.kitapekle_baslik.AutoSize = true;
            this.kitapekle_baslik.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapekle_baslik.Location = new System.Drawing.Point(328, 43);
            this.kitapekle_baslik.Name = "kitapekle_baslik";
            this.kitapekle_baslik.Size = new System.Drawing.Size(237, 35);
            this.kitapekle_baslik.TabIndex = 15;
            this.kitapekle_baslik.Text = "Menü/KİTAP EKLE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dili
            // 
            this.dili.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dili.Location = new System.Drawing.Point(137, 355);
            this.dili.Name = "dili";
            this.dili.Size = new System.Drawing.Size(202, 27);
            this.dili.TabIndex = 4;
            this.dili.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitap_adı_KeyPress);
            // 
            // yayın_evi
            // 
            this.yayın_evi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yayın_evi.Location = new System.Drawing.Point(137, 403);
            this.yayın_evi.Name = "yayın_evi";
            this.yayın_evi.Size = new System.Drawing.Size(202, 27);
            this.yayın_evi.TabIndex = 5;
            this.yayın_evi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitap_adı_KeyPress);
            // 
            // baskı_yılı
            // 
            this.baskı_yılı.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baskı_yılı.Location = new System.Drawing.Point(137, 259);
            this.baskı_yılı.Mask = "0000";
            this.baskı_yılı.Name = "baskı_yılı";
            this.baskı_yılı.Size = new System.Drawing.Size(202, 27);
            this.baskı_yılı.TabIndex = 2;
            this.baskı_yılı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.baskı_yılı.ValidatingType = typeof(int);
            this.baskı_yılı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitap_adı_KeyPress);
            // 
            // sayfa_sayısı
            // 
            this.sayfa_sayısı.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayfa_sayısı.Location = new System.Drawing.Point(137, 307);
            this.sayfa_sayısı.Mask = "0000000000";
            this.sayfa_sayısı.Name = "sayfa_sayısı";
            this.sayfa_sayısı.RejectInputOnFirstFailure = true;
            this.sayfa_sayısı.Size = new System.Drawing.Size(202, 27);
            this.sayfa_sayısı.TabIndex = 3;
            this.sayfa_sayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sayfa_sayısı.ValidatingType = typeof(int);
            this.sayfa_sayısı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitap_adı_KeyPress);
            // 
            // iptal_kitapekle
            // 
            this.iptal_kitapekle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iptal_kitapekle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptal_kitapekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal_kitapekle.Location = new System.Drawing.Point(378, 461);
            this.iptal_kitapekle.Name = "iptal_kitapekle";
            this.iptal_kitapekle.Size = new System.Drawing.Size(161, 49);
            this.iptal_kitapekle.TabIndex = 8;
            this.iptal_kitapekle.Text = "İPTAL";
            this.iptal_kitapekle.UseVisualStyleBackColor = false;
            this.iptal_kitapekle.Click += new System.EventHandler(this.iptal_kitapekle_Click);
            // 
            // kaydet_kitapekle
            // 
            this.kaydet_kitapekle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kaydet_kitapekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet_kitapekle.Location = new System.Drawing.Point(564, 461);
            this.kaydet_kitapekle.Name = "kaydet_kitapekle";
            this.kaydet_kitapekle.Size = new System.Drawing.Size(161, 49);
            this.kaydet_kitapekle.TabIndex = 7;
            this.kaydet_kitapekle.Text = "KAYDET";
            this.kaydet_kitapekle.UseVisualStyleBackColor = false;
            this.kaydet_kitapekle.Click += new System.EventHandler(this.kaydet_kitapekle_Click);
            // 
            // kitapekle_sil
            // 
            this.kitapekle_sil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kitapekle_sil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kitapekle_sil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapekle_sil.Location = new System.Drawing.Point(178, 461);
            this.kitapekle_sil.Name = "kitapekle_sil";
            this.kitapekle_sil.Size = new System.Drawing.Size(161, 49);
            this.kitapekle_sil.TabIndex = 15;
            this.kitapekle_sil.Text = "SİL";
            this.kitapekle_sil.UseVisualStyleBackColor = false;
            this.kitapekle_sil.Visible = false;
            this.kitapekle_sil.Click += new System.EventHandler(this.kitapekle_sil_Click);
            // 
            // kitapekle_id
            // 
            this.kitapekle_id.AutoSize = true;
            this.kitapekle_id.Location = new System.Drawing.Point(679, 146);
            this.kitapekle_id.Name = "kitapekle_id";
            this.kitapekle_id.Size = new System.Drawing.Size(46, 17);
            this.kitapekle_id.TabIndex = 16;
            this.kitapekle_id.Text = "label8";
            this.kitapekle_id.Visible = false;
            // 
            // Kitap_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.iptal_kitapekle;
            this.ClientSize = new System.Drawing.Size(758, 553);
            this.Controls.Add(this.kitapekle_id);
            this.Controls.Add(this.kitapekle_sil);
            this.Controls.Add(this.kaydet_kitapekle);
            this.Controls.Add(this.iptal_kitapekle);
            this.Controls.Add(this.yayın_evi);
            this.Controls.Add(this.dili);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kitap_hakkında);
            this.Controls.Add(this.yazar_adı);
            this.Controls.Add(this.kitap_adı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baskı_yılı);
            this.Controls.Add(this.sayfa_sayısı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(776, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(776, 600);
            this.Name = "Kitap_Ekle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP EKLE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kitap_Ekle_FormClosed);
            this.Load += new System.EventHandler(this.Kitap_Ekle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox kitap_adı;
        public System.Windows.Forms.TextBox yazar_adı;
        public System.Windows.Forms.RichTextBox kitap_hakkında;
        public System.Windows.Forms.Label kitapekle_baslik;
        public System.Windows.Forms.TextBox dili;
        public System.Windows.Forms.TextBox yayın_evi;
        public System.Windows.Forms.MaskedTextBox baskı_yılı;
        public System.Windows.Forms.MaskedTextBox sayfa_sayısı;
        public System.Windows.Forms.Button kitapekle_sil;
        private System.Windows.Forms.Button iptal_kitapekle;
        public System.Windows.Forms.Button kaydet_kitapekle;
        public System.Windows.Forms.Label kitapekle_id;
    }
}
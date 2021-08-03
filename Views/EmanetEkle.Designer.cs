
namespace WindowsFormsApp1
{
    partial class EmanetEkle
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
            this.kaydet_emanetekle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.iptal_emanetekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.üyekayıt_emanetekle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.alımtarih_emanetekle = new System.Windows.Forms.DateTimePicker();
            this.teslimtarih_emanetekle = new System.Windows.Forms.DateTimePicker();
            this.emanetekle_not = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.emanetalanüye__emanetekle = new System.Windows.Forms.ComboBox();
            this.kitap_adı_emanetekle = new System.Windows.Forms.ComboBox();
            this.yazar_adı_emanetekle = new System.Windows.Forms.ComboBox();
            this.baskı_yılı_emanetekle = new System.Windows.Forms.ComboBox();
            this.sayfa_sayısı_emanetekle = new System.Windows.Forms.ComboBox();
            this.dili_emanetekle = new System.Windows.Forms.ComboBox();
            this.yayın_evi_emanetekle = new System.Windows.Forms.ComboBox();
            this.emanetekle_allcombobox = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.emanetekle_allcombobox.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaydet_emanetekle
            // 
            this.kaydet_emanetekle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kaydet_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet_emanetekle.Location = new System.Drawing.Point(581, 396);
            this.kaydet_emanetekle.Name = "kaydet_emanetekle";
            this.kaydet_emanetekle.Size = new System.Drawing.Size(161, 49);
            this.kaydet_emanetekle.TabIndex = 10;
            this.kaydet_emanetekle.Text = "KAYDET";
            this.kaydet_emanetekle.UseVisualStyleBackColor = false;
            this.kaydet_emanetekle.Click += new System.EventHandler(this.kaydet_emanetekle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(328, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "Menü/EMANET EKLE";
            // 
            // iptal_emanetekle
            // 
            this.iptal_emanetekle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iptal_emanetekle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptal_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal_emanetekle.Location = new System.Drawing.Point(395, 396);
            this.iptal_emanetekle.Name = "iptal_emanetekle";
            this.iptal_emanetekle.Size = new System.Drawing.Size(161, 49);
            this.iptal_emanetekle.TabIndex = 11;
            this.iptal_emanetekle.Text = "İPTAL";
            this.iptal_emanetekle.UseVisualStyleBackColor = false;
            this.iptal_emanetekle.Click += new System.EventHandler(this.iptal_kitapekle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(44, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 121);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.ematekle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(391, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Emanet Alan Üye:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Yayın Evi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Dili:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Baskı Yılı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Yazar Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kitap Adı:";
            // 
            // üyekayıt_emanetekle
            // 
            this.üyekayıt_emanetekle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.üyekayıt_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üyekayıt_emanetekle.Location = new System.Drawing.Point(745, 175);
            this.üyekayıt_emanetekle.Name = "üyekayıt_emanetekle";
            this.üyekayıt_emanetekle.Size = new System.Drawing.Size(31, 29);
            this.üyekayıt_emanetekle.TabIndex = 7;
            this.üyekayıt_emanetekle.Text = "+";
            this.üyekayıt_emanetekle.UseVisualStyleBackColor = false;
            this.üyekayıt_emanetekle.Click += new System.EventHandler(this.üyekayıt_emanetekle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(391, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 21);
            this.label9.TabIndex = 48;
            this.label9.Text = "Alış Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(391, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Teslim Tarihi:";
            // 
            // alımtarih_emanetekle
            // 
            this.alımtarih_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alımtarih_emanetekle.Location = new System.Drawing.Point(540, 224);
            this.alımtarih_emanetekle.Name = "alımtarih_emanetekle";
            this.alımtarih_emanetekle.Size = new System.Drawing.Size(202, 27);
            this.alımtarih_emanetekle.TabIndex = 8;
            // 
            // teslimtarih_emanetekle
            // 
            this.teslimtarih_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimtarih_emanetekle.Location = new System.Drawing.Point(540, 257);
            this.teslimtarih_emanetekle.Name = "teslimtarih_emanetekle";
            this.teslimtarih_emanetekle.Size = new System.Drawing.Size(202, 27);
            this.teslimtarih_emanetekle.TabIndex = 9;
            // 
            // emanetekle_not
            // 
            this.emanetekle_not.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emanetekle_not.Location = new System.Drawing.Point(395, 323);
            this.emanetekle_not.Name = "emanetekle_not";
            this.emanetekle_not.Size = new System.Drawing.Size(347, 67);
            this.emanetekle_not.TabIndex = 51;
            this.emanetekle_not.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(391, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 21);
            this.label11.TabIndex = 52;
            this.label11.Text = "Emanet Notu:";
            // 
            // emanetalanüye__emanetekle
            // 
            this.emanetalanüye__emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetalanüye__emanetekle.FormattingEnabled = true;
            this.emanetalanüye__emanetekle.Location = new System.Drawing.Point(540, 176);
            this.emanetalanüye__emanetekle.Name = "emanetalanüye__emanetekle";
            this.emanetalanüye__emanetekle.Size = new System.Drawing.Size(202, 28);
            this.emanetalanüye__emanetekle.TabIndex = 53;
            this.emanetalanüye__emanetekle.SelectedIndexChanged += new System.EventHandler(this.emanetalanüye__emanetekle_SelectedIndexChanged);
            this.emanetalanüye__emanetekle.Leave += new System.EventHandler(this.kitap_adı_emanetekle_Leave);
            // 
            // kitap_adı_emanetekle
            // 
            this.kitap_adı_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap_adı_emanetekle.FormattingEnabled = true;
            this.kitap_adı_emanetekle.Location = new System.Drawing.Point(16, 17);
            this.kitap_adı_emanetekle.Name = "kitap_adı_emanetekle";
            this.kitap_adı_emanetekle.Size = new System.Drawing.Size(202, 28);
            this.kitap_adı_emanetekle.TabIndex = 54;
            this.kitap_adı_emanetekle.SelectedIndexChanged += new System.EventHandler(this.kitap_adı_emanetekle_SelectedIndexChanged);
            this.kitap_adı_emanetekle.Leave += new System.EventHandler(this.kitap_adı_emanetekle_Leave);
            // 
            // yazar_adı_emanetekle
            // 
            this.yazar_adı_emanetekle.Enabled = false;
            this.yazar_adı_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazar_adı_emanetekle.FormattingEnabled = true;
            this.yazar_adı_emanetekle.Location = new System.Drawing.Point(16, 66);
            this.yazar_adı_emanetekle.Name = "yazar_adı_emanetekle";
            this.yazar_adı_emanetekle.Size = new System.Drawing.Size(202, 28);
            this.yazar_adı_emanetekle.TabIndex = 55;
            // 
            // baskı_yılı_emanetekle
            // 
            this.baskı_yılı_emanetekle.Enabled = false;
            this.baskı_yılı_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baskı_yılı_emanetekle.FormattingEnabled = true;
            this.baskı_yılı_emanetekle.Location = new System.Drawing.Point(16, 114);
            this.baskı_yılı_emanetekle.Name = "baskı_yılı_emanetekle";
            this.baskı_yılı_emanetekle.Size = new System.Drawing.Size(202, 28);
            this.baskı_yılı_emanetekle.TabIndex = 56;
            // 
            // sayfa_sayısı_emanetekle
            // 
            this.sayfa_sayısı_emanetekle.Enabled = false;
            this.sayfa_sayısı_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayfa_sayısı_emanetekle.FormattingEnabled = true;
            this.sayfa_sayısı_emanetekle.Location = new System.Drawing.Point(16, 162);
            this.sayfa_sayısı_emanetekle.Name = "sayfa_sayısı_emanetekle";
            this.sayfa_sayısı_emanetekle.Size = new System.Drawing.Size(202, 28);
            this.sayfa_sayısı_emanetekle.TabIndex = 57;
            // 
            // dili_emanetekle
            // 
            this.dili_emanetekle.Enabled = false;
            this.dili_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dili_emanetekle.FormattingEnabled = true;
            this.dili_emanetekle.Location = new System.Drawing.Point(16, 210);
            this.dili_emanetekle.Name = "dili_emanetekle";
            this.dili_emanetekle.Size = new System.Drawing.Size(202, 28);
            this.dili_emanetekle.TabIndex = 58;
            // 
            // yayın_evi_emanetekle
            // 
            this.yayın_evi_emanetekle.Enabled = false;
            this.yayın_evi_emanetekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yayın_evi_emanetekle.FormattingEnabled = true;
            this.yayın_evi_emanetekle.Location = new System.Drawing.Point(16, 258);
            this.yayın_evi_emanetekle.Name = "yayın_evi_emanetekle";
            this.yayın_evi_emanetekle.Size = new System.Drawing.Size(202, 28);
            this.yayın_evi_emanetekle.TabIndex = 59;
            // 
            // emanetekle_allcombobox
            // 
            this.emanetekle_allcombobox.Controls.Add(this.yayın_evi_emanetekle);
            this.emanetekle_allcombobox.Controls.Add(this.kitap_adı_emanetekle);
            this.emanetekle_allcombobox.Controls.Add(this.dili_emanetekle);
            this.emanetekle_allcombobox.Controls.Add(this.yazar_adı_emanetekle);
            this.emanetekle_allcombobox.Controls.Add(this.sayfa_sayısı_emanetekle);
            this.emanetekle_allcombobox.Controls.Add(this.baskı_yılı_emanetekle);
            this.emanetekle_allcombobox.Location = new System.Drawing.Point(151, 158);
            this.emanetekle_allcombobox.Name = "emanetekle_allcombobox";
            this.emanetekle_allcombobox.Size = new System.Drawing.Size(234, 306);
            this.emanetekle_allcombobox.TabIndex = 60;
            // 
            // EmanetEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.iptal_emanetekle;
            this.ClientSize = new System.Drawing.Size(782, 472);
            this.Controls.Add(this.emanetalanüye__emanetekle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emanetekle_not);
            this.Controls.Add(this.alımtarih_emanetekle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.üyekayıt_emanetekle);
            this.Controls.Add(this.kaydet_emanetekle);
            this.Controls.Add(this.iptal_emanetekle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teslimtarih_emanetekle);
            this.Controls.Add(this.emanetekle_allcombobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 519);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 519);
            this.Name = "EmanetEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMANET EKLE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmanetEkle_FormClosed);
            this.Load += new System.EventHandler(this.EmanetEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.emanetekle_allcombobox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydet_emanetekle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button iptal_emanetekle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button üyekayıt_emanetekle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker alımtarih_emanetekle;
        private System.Windows.Forms.DateTimePicker teslimtarih_emanetekle;
        private System.Windows.Forms.RichTextBox emanetekle_not;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox emanetalanüye__emanetekle;
        public System.Windows.Forms.ComboBox kitap_adı_emanetekle;
        public System.Windows.Forms.ComboBox yazar_adı_emanetekle;
        public System.Windows.Forms.ComboBox baskı_yılı_emanetekle;
        public System.Windows.Forms.ComboBox sayfa_sayısı_emanetekle;
        public System.Windows.Forms.ComboBox dili_emanetekle;
        public System.Windows.Forms.ComboBox yayın_evi_emanetekle;
        public System.Windows.Forms.Panel emanetekle_allcombobox;
    }
}
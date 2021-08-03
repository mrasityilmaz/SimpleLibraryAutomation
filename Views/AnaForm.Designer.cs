
namespace WindowsFormsApp1
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanıcıdegistir_menu = new System.Windows.Forms.Button();
            this.kitap_ekle = new System.Windows.Forms.Button();
            this.emanet_ekle = new System.Windows.Forms.Button();
            this.üye_ekle = new System.Windows.Forms.Button();
            this.kitap_listele = new System.Windows.Forms.Button();
            this.emanet_listele = new System.Windows.Forms.Button();
            this.üye_listele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 48);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kütüphane Otomasyonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(807, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "v0.1";
            // 
            // kullanıcıdegistir_menu
            // 
            this.kullanıcıdegistir_menu.BackColor = System.Drawing.Color.Transparent;
            this.kullanıcıdegistir_menu.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.change_user;
            this.kullanıcıdegistir_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kullanıcıdegistir_menu.FlatAppearance.BorderSize = 0;
            this.kullanıcıdegistir_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullanıcıdegistir_menu.Location = new System.Drawing.Point(1031, 24);
            this.kullanıcıdegistir_menu.Name = "kullanıcıdegistir_menu";
            this.kullanıcıdegistir_menu.Size = new System.Drawing.Size(97, 87);
            this.kullanıcıdegistir_menu.TabIndex = 21;
            this.kullanıcıdegistir_menu.UseVisualStyleBackColor = false;
            this.kullanıcıdegistir_menu.Click += new System.EventHandler(this.kullanıcıdegistir_menu_Click);
            // 
            // kitap_ekle
            // 
            this.kitap_ekle.BackColor = System.Drawing.Color.White;
            this.kitap_ekle.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.book;
            this.kitap_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kitap_ekle.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap_ekle.Location = new System.Drawing.Point(52, 141);
            this.kitap_ekle.Name = "kitap_ekle";
            this.kitap_ekle.Size = new System.Drawing.Size(316, 173);
            this.kitap_ekle.TabIndex = 13;
            this.kitap_ekle.Text = "Kitap Ekle";
            this.kitap_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kitap_ekle.UseVisualStyleBackColor = false;
            this.kitap_ekle.Click += new System.EventHandler(this.kitap_ekle_Click);
            // 
            // emanet_ekle
            // 
            this.emanet_ekle.BackColor = System.Drawing.Color.White;
            this.emanet_ekle.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emanet;
            this.emanet_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emanet_ekle.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanet_ekle.Location = new System.Drawing.Point(433, 141);
            this.emanet_ekle.Name = "emanet_ekle";
            this.emanet_ekle.Size = new System.Drawing.Size(316, 173);
            this.emanet_ekle.TabIndex = 14;
            this.emanet_ekle.Text = "Emanet Ekle";
            this.emanet_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emanet_ekle.UseVisualStyleBackColor = false;
            this.emanet_ekle.Click += new System.EventHandler(this.emanet_ekle_Click);
            // 
            // üye_ekle
            // 
            this.üye_ekle.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.members1;
            this.üye_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.üye_ekle.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üye_ekle.Location = new System.Drawing.Point(812, 141);
            this.üye_ekle.Name = "üye_ekle";
            this.üye_ekle.Size = new System.Drawing.Size(316, 173);
            this.üye_ekle.TabIndex = 15;
            this.üye_ekle.Text = "Üye Ekle";
            this.üye_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.üye_ekle.UseVisualStyleBackColor = true;
            this.üye_ekle.Click += new System.EventHandler(this.üye_ekle_Click);
            // 
            // kitap_listele
            // 
            this.kitap_listele.BackColor = System.Drawing.Color.White;
            this.kitap_listele.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.book;
            this.kitap_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kitap_listele.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap_listele.Location = new System.Drawing.Point(52, 358);
            this.kitap_listele.Name = "kitap_listele";
            this.kitap_listele.Size = new System.Drawing.Size(316, 173);
            this.kitap_listele.TabIndex = 16;
            this.kitap_listele.Text = "Kitapları Listele";
            this.kitap_listele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kitap_listele.UseVisualStyleBackColor = false;
            this.kitap_listele.Click += new System.EventHandler(this.kitap_listele_Click);
            // 
            // emanet_listele
            // 
            this.emanet_listele.BackColor = System.Drawing.Color.White;
            this.emanet_listele.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emanet;
            this.emanet_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emanet_listele.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanet_listele.Location = new System.Drawing.Point(433, 358);
            this.emanet_listele.Name = "emanet_listele";
            this.emanet_listele.Size = new System.Drawing.Size(316, 173);
            this.emanet_listele.TabIndex = 17;
            this.emanet_listele.Text = "Emanetleri Listele";
            this.emanet_listele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emanet_listele.UseVisualStyleBackColor = false;
            this.emanet_listele.Click += new System.EventHandler(this.emanet_listele_Click);
            // 
            // üye_listele
            // 
            this.üye_listele.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.members1;
            this.üye_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.üye_listele.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üye_listele.Location = new System.Drawing.Point(812, 358);
            this.üye_listele.Name = "üye_listele";
            this.üye_listele.Size = new System.Drawing.Size(316, 173);
            this.üye_listele.TabIndex = 18;
            this.üye_listele.Text = "Üyeleri Listele";
            this.üye_listele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.üye_listele.UseVisualStyleBackColor = true;
            this.üye_listele.Click += new System.EventHandler(this.üye_listele_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.kullanıcıdegistir_menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitap_ekle);
            this.Controls.Add(this.emanet_ekle);
            this.Controls.Add(this.üye_ekle);
            this.Controls.Add(this.kitap_listele);
            this.Controls.Add(this.emanet_listele);
            this.Controls.Add(this.üye_listele);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kitap_ekle;
        private System.Windows.Forms.Button emanet_ekle;
        private System.Windows.Forms.Button üye_ekle;
        private System.Windows.Forms.Button kitap_listele;
        private System.Windows.Forms.Button emanet_listele;
        private System.Windows.Forms.Button üye_listele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kullanıcıdegistir_menu;
    }
}


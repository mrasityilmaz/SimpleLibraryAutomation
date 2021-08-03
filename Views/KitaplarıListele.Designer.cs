
namespace WindowsFormsApp1
{
    partial class KitaplarıListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kitaplar_kitaplist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapsil_kitaplist = new System.Windows.Forms.Button();
            this.kitapdüzenle_kitaplist = new System.Windows.Forms.Button();
            this.kitapekle_kitaplist = new System.Windows.Forms.Button();
            this.kaydet_kitaplist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar_kitaplist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 121);
            this.panel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(545, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "Menü/KİTAPLAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kitaplar_kitaplist
            // 
            this.kitaplar_kitaplist.AllowUserToAddRows = false;
            this.kitaplar_kitaplist.AllowUserToDeleteRows = false;
            this.kitaplar_kitaplist.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.kitaplar_kitaplist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kitaplar_kitaplist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.kitaplar_kitaplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplar_kitaplist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitaplar_kitaplist.EnableHeadersVisualStyles = false;
            this.kitaplar_kitaplist.Location = new System.Drawing.Point(11, 164);
            this.kitaplar_kitaplist.Name = "kitaplar_kitaplist";
            this.kitaplar_kitaplist.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kitaplar_kitaplist.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.kitaplar_kitaplist.RowHeadersVisible = false;
            this.kitaplar_kitaplist.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.kitaplar_kitaplist.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.kitaplar_kitaplist.RowTemplate.Height = 24;
            this.kitaplar_kitaplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kitaplar_kitaplist.Size = new System.Drawing.Size(1201, 493);
            this.kitaplar_kitaplist.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitap Listesi";
            // 
            // kitapsil_kitaplist
            // 
            this.kitapsil_kitaplist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kitapsil_kitaplist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapsil_kitaplist.Location = new System.Drawing.Point(11, 664);
            this.kitapsil_kitaplist.Name = "kitapsil_kitaplist";
            this.kitapsil_kitaplist.Size = new System.Drawing.Size(161, 49);
            this.kitapsil_kitaplist.TabIndex = 17;
            this.kitapsil_kitaplist.Text = "Kitap Sil";
            this.kitapsil_kitaplist.UseVisualStyleBackColor = false;
            this.kitapsil_kitaplist.Click += new System.EventHandler(this.kitapsil_kitaplist_Click);
            // 
            // kitapdüzenle_kitaplist
            // 
            this.kitapdüzenle_kitaplist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kitapdüzenle_kitaplist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapdüzenle_kitaplist.Location = new System.Drawing.Point(178, 664);
            this.kitapdüzenle_kitaplist.Name = "kitapdüzenle_kitaplist";
            this.kitapdüzenle_kitaplist.Size = new System.Drawing.Size(161, 49);
            this.kitapdüzenle_kitaplist.TabIndex = 18;
            this.kitapdüzenle_kitaplist.Text = "Kitap Düzenle";
            this.kitapdüzenle_kitaplist.UseVisualStyleBackColor = false;
            this.kitapdüzenle_kitaplist.Click += new System.EventHandler(this.kitapdüzenle_kitaplist_Click);
            // 
            // kitapekle_kitaplist
            // 
            this.kitapekle_kitaplist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kitapekle_kitaplist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapekle_kitaplist.Location = new System.Drawing.Point(345, 664);
            this.kitapekle_kitaplist.Name = "kitapekle_kitaplist";
            this.kitapekle_kitaplist.Size = new System.Drawing.Size(161, 49);
            this.kitapekle_kitaplist.TabIndex = 19;
            this.kitapekle_kitaplist.Text = "Kitap Ekle";
            this.kitapekle_kitaplist.UseVisualStyleBackColor = false;
            this.kitapekle_kitaplist.Click += new System.EventHandler(this.kitapekle_kitaplist_Click);
            // 
            // kaydet_kitaplist
            // 
            this.kaydet_kitaplist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kaydet_kitaplist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet_kitaplist.Location = new System.Drawing.Point(1051, 664);
            this.kaydet_kitaplist.Name = "kaydet_kitaplist";
            this.kaydet_kitaplist.Size = new System.Drawing.Size(161, 49);
            this.kaydet_kitaplist.TabIndex = 20;
            this.kaydet_kitaplist.Text = "TAMAM";
            this.kaydet_kitaplist.UseVisualStyleBackColor = false;
            this.kaydet_kitaplist.Click += new System.EventHandler(this.kaydet_kitaplist_Click);
            // 
            // KitaplarıListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 725);
            this.Controls.Add(this.kaydet_kitaplist);
            this.Controls.Add(this.kitapekle_kitaplist);
            this.Controls.Add(this.kitapdüzenle_kitaplist);
            this.Controls.Add(this.kitapsil_kitaplist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitaplar_kitaplist);
            this.Controls.Add(this.panel1);
            this.Name = "KitaplarıListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP LİSTESİ";
            this.Load += new System.EventHandler(this.KitaplarıListele_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar_kitaplist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView kitaplar_kitaplist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kitapsil_kitaplist;
        private System.Windows.Forms.Button kitapdüzenle_kitaplist;
        private System.Windows.Forms.Button kitapekle_kitaplist;
        private System.Windows.Forms.Button kaydet_kitaplist;
    }
}
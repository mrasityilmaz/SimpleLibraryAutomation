
namespace WindowsFormsApp1
{
    partial class Üyeler
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
            this.kaydet_üyeler = new System.Windows.Forms.Button();
            this.üyeekle_üyeler = new System.Windows.Forms.Button();
            this.üyedüzenle_üyeler = new System.Windows.Forms.Button();
            this.üyesil_üyelert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.üyelerlist_üyeler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.üyelerlist_üyeler)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kaydet_üyeler
            // 
            this.kaydet_üyeler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kaydet_üyeler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet_üyeler.Location = new System.Drawing.Point(1052, 670);
            this.kaydet_üyeler.Name = "kaydet_üyeler";
            this.kaydet_üyeler.Size = new System.Drawing.Size(161, 49);
            this.kaydet_üyeler.TabIndex = 27;
            this.kaydet_üyeler.Text = "TAMAM";
            this.kaydet_üyeler.UseVisualStyleBackColor = false;
            this.kaydet_üyeler.Click += new System.EventHandler(this.kaydet_üyeler_Click);
            // 
            // üyeekle_üyeler
            // 
            this.üyeekle_üyeler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.üyeekle_üyeler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üyeekle_üyeler.Location = new System.Drawing.Point(346, 670);
            this.üyeekle_üyeler.Name = "üyeekle_üyeler";
            this.üyeekle_üyeler.Size = new System.Drawing.Size(161, 49);
            this.üyeekle_üyeler.TabIndex = 26;
            this.üyeekle_üyeler.Text = "Üye Ekle";
            this.üyeekle_üyeler.UseVisualStyleBackColor = false;
            this.üyeekle_üyeler.Click += new System.EventHandler(this.üyeekle_üyeler_Click);
            // 
            // üyedüzenle_üyeler
            // 
            this.üyedüzenle_üyeler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.üyedüzenle_üyeler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üyedüzenle_üyeler.Location = new System.Drawing.Point(179, 670);
            this.üyedüzenle_üyeler.Name = "üyedüzenle_üyeler";
            this.üyedüzenle_üyeler.Size = new System.Drawing.Size(161, 49);
            this.üyedüzenle_üyeler.TabIndex = 25;
            this.üyedüzenle_üyeler.Text = "Üye Düzenle";
            this.üyedüzenle_üyeler.UseVisualStyleBackColor = false;
            this.üyedüzenle_üyeler.Click += new System.EventHandler(this.üyedüzenle_üyeler_Click);
            // 
            // üyesil_üyelert
            // 
            this.üyesil_üyelert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.üyesil_üyelert.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üyesil_üyelert.Location = new System.Drawing.Point(12, 670);
            this.üyesil_üyelert.Name = "üyesil_üyelert";
            this.üyesil_üyelert.Size = new System.Drawing.Size(161, 49);
            this.üyesil_üyelert.TabIndex = 24;
            this.üyesil_üyelert.Text = "Üye Sil";
            this.üyesil_üyelert.UseVisualStyleBackColor = false;
            this.üyesil_üyelert.Click += new System.EventHandler(this.üyesil_üyelert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "Üye Listesi";
            // 
            // üyelerlist_üyeler
            // 
            this.üyelerlist_üyeler.AllowUserToAddRows = false;
            this.üyelerlist_üyeler.AllowUserToDeleteRows = false;
            this.üyelerlist_üyeler.AllowUserToResizeRows = false;
            this.üyelerlist_üyeler.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.üyelerlist_üyeler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.üyelerlist_üyeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.üyelerlist_üyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.üyelerlist_üyeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.üyelerlist_üyeler.EnableHeadersVisualStyles = false;
            this.üyelerlist_üyeler.Location = new System.Drawing.Point(12, 170);
            this.üyelerlist_üyeler.Name = "üyelerlist_üyeler";
            this.üyelerlist_üyeler.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.üyelerlist_üyeler.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.üyelerlist_üyeler.RowHeadersVisible = false;
            this.üyelerlist_üyeler.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.üyelerlist_üyeler.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.üyelerlist_üyeler.RowTemplate.Height = 24;
            this.üyelerlist_üyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.üyelerlist_üyeler.Size = new System.Drawing.Size(1201, 493);
            this.üyelerlist_üyeler.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 121);
            this.panel1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(545, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "Menü/ÜYELER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.members1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Üyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 725);
            this.Controls.Add(this.kaydet_üyeler);
            this.Controls.Add(this.üyeekle_üyeler);
            this.Controls.Add(this.üyedüzenle_üyeler);
            this.Controls.Add(this.üyesil_üyelert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.üyelerlist_üyeler);
            this.Controls.Add(this.panel1);
            this.Name = "Üyeler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜYE LİSTESİ";
            this.Activated += new System.EventHandler(this.Üyeler_Activated);
            this.Load += new System.EventHandler(this.Üyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.üyelerlist_üyeler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydet_üyeler;
        private System.Windows.Forms.Button üyeekle_üyeler;
        private System.Windows.Forms.Button üyedüzenle_üyeler;
        private System.Windows.Forms.Button üyesil_üyelert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView üyelerlist_üyeler;
    }
}
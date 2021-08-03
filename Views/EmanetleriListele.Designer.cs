
namespace WindowsFormsApp1
{
    partial class Emanetler
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
            this.tamam_emanetlist = new System.Windows.Forms.Button();
            this.teslimal_emanetlist = new System.Windows.Forms.Button();
            this.emanetekle_emanetlist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emanetler_emanetlist = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eski_kayitlar_emanetler = new System.Windows.Forms.Button();
            this.güncel_emanetler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emanetler_emanetlist)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tamam_emanetlist
            // 
            this.tamam_emanetlist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tamam_emanetlist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tamam_emanetlist.Location = new System.Drawing.Point(1052, 670);
            this.tamam_emanetlist.Name = "tamam_emanetlist";
            this.tamam_emanetlist.Size = new System.Drawing.Size(161, 49);
            this.tamam_emanetlist.TabIndex = 27;
            this.tamam_emanetlist.Text = "TAMAM";
            this.tamam_emanetlist.UseVisualStyleBackColor = false;
            this.tamam_emanetlist.Click += new System.EventHandler(this.tamam_emanetlist_Click);
            // 
            // teslimal_emanetlist
            // 
            this.teslimal_emanetlist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.teslimal_emanetlist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimal_emanetlist.Location = new System.Drawing.Point(179, 670);
            this.teslimal_emanetlist.Name = "teslimal_emanetlist";
            this.teslimal_emanetlist.Size = new System.Drawing.Size(161, 49);
            this.teslimal_emanetlist.TabIndex = 26;
            this.teslimal_emanetlist.Text = "Teslim Al";
            this.teslimal_emanetlist.UseVisualStyleBackColor = false;
            this.teslimal_emanetlist.Click += new System.EventHandler(this.teslimal_emanetlist_Click);
            // 
            // emanetekle_emanetlist
            // 
            this.emanetekle_emanetlist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emanetekle_emanetlist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetekle_emanetlist.Location = new System.Drawing.Point(12, 670);
            this.emanetekle_emanetlist.Name = "emanetekle_emanetlist";
            this.emanetekle_emanetlist.Size = new System.Drawing.Size(161, 49);
            this.emanetekle_emanetlist.TabIndex = 24;
            this.emanetekle_emanetlist.Text = "Emanet Ekle";
            this.emanetekle_emanetlist.UseVisualStyleBackColor = false;
            this.emanetekle_emanetlist.Click += new System.EventHandler(this.emanetekle_emanetlist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "Emanet Listesi";
            // 
            // emanetler_emanetlist
            // 
            this.emanetler_emanetlist.AllowUserToAddRows = false;
            this.emanetler_emanetlist.AllowUserToDeleteRows = false;
            this.emanetler_emanetlist.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.emanetler_emanetlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emanetler_emanetlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.emanetler_emanetlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emanetler_emanetlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emanetler_emanetlist.EnableHeadersVisualStyles = false;
            this.emanetler_emanetlist.Location = new System.Drawing.Point(12, 170);
            this.emanetler_emanetlist.Name = "emanetler_emanetlist";
            this.emanetler_emanetlist.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emanetler_emanetlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.emanetler_emanetlist.RowHeadersVisible = false;
            this.emanetler_emanetlist.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.emanetler_emanetlist.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.emanetler_emanetlist.RowTemplate.Height = 24;
            this.emanetler_emanetlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emanetler_emanetlist.Size = new System.Drawing.Size(1201, 493);
            this.emanetler_emanetlist.TabIndex = 23;
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
            this.label8.Size = new System.Drawing.Size(247, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "Menü/EMANETLER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.emanet;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // eski_kayitlar_emanetler
            // 
            this.eski_kayitlar_emanetler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eski_kayitlar_emanetler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eski_kayitlar_emanetler.Location = new System.Drawing.Point(1052, 133);
            this.eski_kayitlar_emanetler.Name = "eski_kayitlar_emanetler";
            this.eski_kayitlar_emanetler.Size = new System.Drawing.Size(161, 30);
            this.eski_kayitlar_emanetler.TabIndex = 28;
            this.eski_kayitlar_emanetler.Text = "Eski Kayıtlar";
            this.eski_kayitlar_emanetler.UseVisualStyleBackColor = false;
            this.eski_kayitlar_emanetler.Click += new System.EventHandler(this.eski_kayitlar_emanetler_Click);
            // 
            // güncel_emanetler
            // 
            this.güncel_emanetler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.güncel_emanetler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncel_emanetler.Location = new System.Drawing.Point(1051, 133);
            this.güncel_emanetler.Name = "güncel_emanetler";
            this.güncel_emanetler.Size = new System.Drawing.Size(161, 30);
            this.güncel_emanetler.TabIndex = 29;
            this.güncel_emanetler.Text = "Güncel Kayıtlar";
            this.güncel_emanetler.UseVisualStyleBackColor = false;
            this.güncel_emanetler.Visible = false;
            this.güncel_emanetler.Click += new System.EventHandler(this.güncel_emanetler_Click);
            // 
            // Emanetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 725);
            this.Controls.Add(this.tamam_emanetlist);
            this.Controls.Add(this.teslimal_emanetlist);
            this.Controls.Add(this.emanetekle_emanetlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emanetler_emanetlist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.güncel_emanetler);
            this.Controls.Add(this.eski_kayitlar_emanetler);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1242, 772);
            this.MinimumSize = new System.Drawing.Size(1242, 772);
            this.Name = "Emanetler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMANET LİSTESİ";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Emanetler_Activated);
            this.Load += new System.EventHandler(this.Emanetler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emanetler_emanetlist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tamam_emanetlist;
        private System.Windows.Forms.Button teslimal_emanetlist;
        private System.Windows.Forms.Button emanetekle_emanetlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView emanetler_emanetlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button eski_kayitlar_emanetler;
        private System.Windows.Forms.Button güncel_emanetler;
    }
}
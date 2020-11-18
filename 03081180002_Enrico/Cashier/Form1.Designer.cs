namespace Cashier
{
    partial class Form1
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CetakStruk = new System.Windows.Forms.Button();
            this.TombolDelete = new System.Windows.Forms.Button();
            this.TombolSaveUpdate = new System.Windows.Forms.Button();
            this.HargaMenu = new System.Windows.Forms.NumericUpDown();
            this.NamaMenu = new System.Windows.Forms.TextBox();
            this.TombolGambar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNoMeja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RincianPenjualan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.Meja = new System.Windows.Forms.DataGridView();
            this.Meja8 = new System.Windows.Forms.Label();
            this.Meja7 = new System.Windows.Forms.Label();
            this.Meja6 = new System.Windows.Forms.Label();
            this.Meja5 = new System.Windows.Forms.Label();
            this.Meja4 = new System.Windows.Forms.Label();
            this.Meja3 = new System.Windows.Forms.Label();
            this.Meja2 = new System.Windows.Forms.Label();
            this.Meja1 = new System.Windows.Forms.Label();
            this.Meja9 = new System.Windows.Forms.Label();
            this.Meja10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HargaMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RincianPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meja)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CetakStruk
            // 
            this.CetakStruk.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.CetakStruk.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CetakStruk.Location = new System.Drawing.Point(3, 304);
            this.CetakStruk.Name = "CetakStruk";
            this.CetakStruk.Size = new System.Drawing.Size(232, 28);
            this.CetakStruk.TabIndex = 87;
            this.CetakStruk.Text = "Cetak";
            this.CetakStruk.UseVisualStyleBackColor = false;
            this.CetakStruk.Click += new System.EventHandler(this.TombolCetak_Click);
            // 
            // TombolDelete
            // 
            this.TombolDelete.BackColor = System.Drawing.Color.Red;
            this.TombolDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TombolDelete.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolDelete.ForeColor = System.Drawing.Color.White;
            this.TombolDelete.Location = new System.Drawing.Point(342, 257);
            this.TombolDelete.Name = "TombolDelete";
            this.TombolDelete.Size = new System.Drawing.Size(80, 23);
            this.TombolDelete.TabIndex = 86;
            this.TombolDelete.Text = "Delete";
            this.TombolDelete.UseVisualStyleBackColor = false;
            this.TombolDelete.Click += new System.EventHandler(this.TombolDelete_Click);
            // 
            // TombolSaveUpdate
            // 
            this.TombolSaveUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.TombolSaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TombolSaveUpdate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolSaveUpdate.Location = new System.Drawing.Point(342, 228);
            this.TombolSaveUpdate.Name = "TombolSaveUpdate";
            this.TombolSaveUpdate.Size = new System.Drawing.Size(80, 23);
            this.TombolSaveUpdate.TabIndex = 85;
            this.TombolSaveUpdate.Text = "Save";
            this.TombolSaveUpdate.UseVisualStyleBackColor = false;
            this.TombolSaveUpdate.Click += new System.EventHandler(this.TombolSaveUpdate_Click);
            // 
            // HargaMenu
            // 
            this.HargaMenu.Location = new System.Drawing.Point(353, 136);
            this.HargaMenu.Name = "HargaMenu";
            this.HargaMenu.Size = new System.Drawing.Size(100, 20);
            this.HargaMenu.TabIndex = 84;
            // 
            // NamaMenu
            // 
            this.NamaMenu.Location = new System.Drawing.Point(353, 106);
            this.NamaMenu.Name = "NamaMenu";
            this.NamaMenu.Size = new System.Drawing.Size(100, 20);
            this.NamaMenu.TabIndex = 83;
            this.NamaMenu.Leave += new System.EventHandler(this.NamaMenu_Leave);
            // 
            // TombolGambar
            // 
            this.TombolGambar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolGambar.Location = new System.Drawing.Point(353, 163);
            this.TombolGambar.Name = "TombolGambar";
            this.TombolGambar.Size = new System.Drawing.Size(100, 23);
            this.TombolGambar.TabIndex = 82;
            this.TombolGambar.Text = "Pilih Gambar";
            this.TombolGambar.UseVisualStyleBackColor = true;
            this.TombolGambar.Click += new System.EventHandler(this.TombolGambar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(246, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 26);
            this.label7.TabIndex = 80;
            this.label7.Tag = "";
            this.label7.Text = "Tambah/Edit Menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 79;
            this.label6.Text = "Gambar Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 78;
            this.label5.Text = "Harga Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "Nama Menu";
            // 
            // lblNoMeja
            // 
            this.lblNoMeja.AutoSize = true;
            this.lblNoMeja.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoMeja.Location = new System.Drawing.Point(60, 46);
            this.lblNoMeja.Name = "lblNoMeja";
            this.lblNoMeja.Size = new System.Drawing.Size(0, 23);
            this.lblNoMeja.TabIndex = 76;
            this.lblNoMeja.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 75;
            this.label4.Tag = "";
            this.label4.Text = "Meja";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Footlight MT Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(579, 307);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 19);
            this.lblTotal.TabIndex = 74;
            this.lblTotal.Text = "label3";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 73;
            this.label2.Tag = "";
            this.label2.Text = "Total Penjualan :";
            // 
            // RincianPenjualan
            // 
            this.RincianPenjualan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.RincianPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RincianPenjualan.Location = new System.Drawing.Point(459, 72);
            this.RincianPenjualan.Name = "RincianPenjualan";
            this.RincianPenjualan.Size = new System.Drawing.Size(256, 226);
            this.RincianPenjualan.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 71;
            this.label1.Tag = "";
            this.label1.Text = "Rincian Penjualan";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Location = new System.Drawing.Point(490, 50);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(193, 20);
            this.dtpTanggal.TabIndex = 70;
            this.dtpTanggal.ValueChanged += new System.EventHandler(this.dtpTanggal_ValueChanged);
            // 
            // Meja
            // 
            this.Meja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Meja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Meja.Location = new System.Drawing.Point(3, 72);
            this.Meja.Name = "Meja";
            this.Meja.Size = new System.Drawing.Size(232, 226);
            this.Meja.TabIndex = 69;
            // 
            // Meja8
            // 
            this.Meja8.BackColor = System.Drawing.Color.White;
            this.Meja8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja8.ForeColor = System.Drawing.Color.Black;
            this.Meja8.Location = new System.Drawing.Point(189, -1);
            this.Meja8.Name = "Meja8";
            this.Meja8.Size = new System.Drawing.Size(21, 40);
            this.Meja8.TabIndex = 68;
            this.Meja8.Text = "8";
            this.Meja8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja8.Click += new System.EventHandler(this.lblMeja8_Click);
            // 
            // Meja7
            // 
            this.Meja7.BackColor = System.Drawing.Color.White;
            this.Meja7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja7.ForeColor = System.Drawing.Color.Black;
            this.Meja7.Location = new System.Drawing.Point(162, -1);
            this.Meja7.Name = "Meja7";
            this.Meja7.Size = new System.Drawing.Size(21, 40);
            this.Meja7.TabIndex = 67;
            this.Meja7.Text = "7";
            this.Meja7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja7.Click += new System.EventHandler(this.lblMeja7_Click);
            // 
            // Meja6
            // 
            this.Meja6.BackColor = System.Drawing.Color.White;
            this.Meja6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja6.ForeColor = System.Drawing.Color.Black;
            this.Meja6.Location = new System.Drawing.Point(135, -1);
            this.Meja6.Name = "Meja6";
            this.Meja6.Size = new System.Drawing.Size(21, 40);
            this.Meja6.TabIndex = 66;
            this.Meja6.Text = "6";
            this.Meja6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja6.Click += new System.EventHandler(this.lblMeja6_Click);
            // 
            // Meja5
            // 
            this.Meja5.BackColor = System.Drawing.Color.White;
            this.Meja5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja5.ForeColor = System.Drawing.Color.Black;
            this.Meja5.Location = new System.Drawing.Point(108, -1);
            this.Meja5.Name = "Meja5";
            this.Meja5.Size = new System.Drawing.Size(21, 40);
            this.Meja5.TabIndex = 65;
            this.Meja5.Text = "5";
            this.Meja5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja5.Click += new System.EventHandler(this.lblMeja5_Click);
            // 
            // Meja4
            // 
            this.Meja4.BackColor = System.Drawing.Color.White;
            this.Meja4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja4.ForeColor = System.Drawing.Color.Black;
            this.Meja4.Location = new System.Drawing.Point(81, -1);
            this.Meja4.Name = "Meja4";
            this.Meja4.Size = new System.Drawing.Size(21, 40);
            this.Meja4.TabIndex = 64;
            this.Meja4.Text = "4";
            this.Meja4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja4.Click += new System.EventHandler(this.lblMeja4_Click);
            // 
            // Meja3
            // 
            this.Meja3.BackColor = System.Drawing.Color.White;
            this.Meja3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja3.ForeColor = System.Drawing.Color.Black;
            this.Meja3.Location = new System.Drawing.Point(54, -1);
            this.Meja3.Name = "Meja3";
            this.Meja3.Size = new System.Drawing.Size(21, 40);
            this.Meja3.TabIndex = 63;
            this.Meja3.Text = "3";
            this.Meja3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja3.Click += new System.EventHandler(this.lblMeja3_Click);
            // 
            // Meja2
            // 
            this.Meja2.BackColor = System.Drawing.Color.White;
            this.Meja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja2.ForeColor = System.Drawing.Color.Black;
            this.Meja2.Location = new System.Drawing.Point(27, -1);
            this.Meja2.Name = "Meja2";
            this.Meja2.Size = new System.Drawing.Size(21, 40);
            this.Meja2.TabIndex = 62;
            this.Meja2.Text = "2";
            this.Meja2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja2.Click += new System.EventHandler(this.lblMeja2_Click);
            // 
            // Meja1
            // 
            this.Meja1.BackColor = System.Drawing.Color.White;
            this.Meja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja1.ForeColor = System.Drawing.Color.Black;
            this.Meja1.Location = new System.Drawing.Point(0, -1);
            this.Meja1.Name = "Meja1";
            this.Meja1.Size = new System.Drawing.Size(21, 40);
            this.Meja1.TabIndex = 61;
            this.Meja1.Text = "1";
            this.Meja1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja1.Click += new System.EventHandler(this.lblMeja1_Click);
            // 
            // Meja9
            // 
            this.Meja9.BackColor = System.Drawing.Color.White;
            this.Meja9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja9.ForeColor = System.Drawing.Color.Black;
            this.Meja9.Location = new System.Drawing.Point(216, -1);
            this.Meja9.Name = "Meja9";
            this.Meja9.Size = new System.Drawing.Size(21, 40);
            this.Meja9.TabIndex = 88;
            this.Meja9.Text = "9";
            this.Meja9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja9.Click += new System.EventHandler(this.lblMeja9_Click);
            // 
            // Meja10
            // 
            this.Meja10.BackColor = System.Drawing.Color.White;
            this.Meja10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja10.ForeColor = System.Drawing.Color.Black;
            this.Meja10.Location = new System.Drawing.Point(243, -1);
            this.Meja10.Name = "Meja10";
            this.Meja10.Size = new System.Drawing.Size(21, 40);
            this.Meja10.TabIndex = 89;
            this.Meja10.Text = "10";
            this.Meja10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja10.Click += new System.EventHandler(this.lblMeja10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(735, 343);
            this.Controls.Add(this.Meja10);
            this.Controls.Add(this.Meja9);
            this.Controls.Add(this.CetakStruk);
            this.Controls.Add(this.TombolDelete);
            this.Controls.Add(this.TombolSaveUpdate);
            this.Controls.Add(this.HargaMenu);
            this.Controls.Add(this.NamaMenu);
            this.Controls.Add(this.TombolGambar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNoMeja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RincianPenjualan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.Meja);
            this.Controls.Add(this.Meja8);
            this.Controls.Add(this.Meja7);
            this.Controls.Add(this.Meja6);
            this.Controls.Add(this.Meja5);
            this.Controls.Add(this.Meja4);
            this.Controls.Add(this.Meja3);
            this.Controls.Add(this.Meja2);
            this.Controls.Add(this.Meja1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HargaMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RincianPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CetakStruk;
        private System.Windows.Forms.Button TombolDelete;
        private System.Windows.Forms.Button TombolSaveUpdate;
        private System.Windows.Forms.NumericUpDown HargaMenu;
        private System.Windows.Forms.TextBox NamaMenu;
        private System.Windows.Forms.Button TombolGambar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoMeja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RincianPenjualan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.DataGridView Meja;
        private System.Windows.Forms.Label Meja8;
        private System.Windows.Forms.Label Meja7;
        private System.Windows.Forms.Label Meja6;
        private System.Windows.Forms.Label Meja5;
        private System.Windows.Forms.Label Meja4;
        private System.Windows.Forms.Label Meja3;
        private System.Windows.Forms.Label Meja2;
        private System.Windows.Forms.Label Meja1;
        private System.Windows.Forms.Label Meja9;
        private System.Windows.Forms.Label Meja10;
    }
}


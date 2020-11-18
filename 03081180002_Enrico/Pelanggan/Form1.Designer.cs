namespace Pelanggan
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPesanan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DaftarMenu = new System.Windows.Forms.DataGridView();
            this.BestSeller = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbxNoMeja = new System.Windows.Forms.ComboBox();
            this.grpbxPesan = new System.Windows.Forms.GroupBox();
            this.TombolPesan = new System.Windows.Forms.Button();
            this.nudJumlahPesanan = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TombolBayar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DaftarPesanan = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DaftarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestSeller)).BeginInit();
            this.grpbxPesan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahPesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaftarPesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "Daftar Pesanan";
            // 
            // lblTotalPesanan
            // 
            this.lblTotalPesanan.AutoSize = true;
            this.lblTotalPesanan.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPesanan.Location = new System.Drawing.Point(481, 286);
            this.lblTotalPesanan.Name = "lblTotalPesanan";
            this.lblTotalPesanan.Size = new System.Drawing.Size(49, 15);
            this.lblTotalPesanan.TabIndex = 40;
            this.lblTotalPesanan.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Total Harga :";
            // 
            // DaftarMenu
            // 
            this.DaftarMenu.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.DaftarMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaftarMenu.Location = new System.Drawing.Point(12, 41);
            this.DaftarMenu.Name = "DaftarMenu";
            this.DaftarMenu.Size = new System.Drawing.Size(242, 225);
            this.DaftarMenu.TabIndex = 30;
            this.DaftarMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaftarMenu_CellClick);
            // 
            // BestSeller
            // 
            this.BestSeller.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.BestSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BestSeller.Location = new System.Drawing.Point(333, 353);
            this.BestSeller.MultiSelect = false;
            this.BestSeller.Name = "BestSeller";
            this.BestSeller.ReadOnly = true;
            this.BestSeller.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BestSeller.Size = new System.Drawing.Size(243, 74);
            this.BestSeller.TabIndex = 38;
            this.BestSeller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BestSeller_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Daftar Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Our Best Seller";
            // 
            // cmbbxNoMeja
            // 
            this.cmbbxNoMeja.FormattingEnabled = true;
            this.cmbbxNoMeja.Location = new System.Drawing.Point(202, 16);
            this.cmbbxNoMeja.Name = "cmbbxNoMeja";
            this.cmbbxNoMeja.Size = new System.Drawing.Size(52, 21);
            this.cmbbxNoMeja.TabIndex = 36;
            this.cmbbxNoMeja.SelectedIndexChanged += new System.EventHandler(this.cmbbxNoMeja_SelectedIndexChanged);
            // 
            // grpbxPesan
            // 
            this.grpbxPesan.BackColor = System.Drawing.Color.Transparent;
            this.grpbxPesan.Controls.Add(this.TombolPesan);
            this.grpbxPesan.Controls.Add(this.nudJumlahPesanan);
            this.grpbxPesan.Controls.Add(this.label2);
            this.grpbxPesan.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPesan.Location = new System.Drawing.Point(12, 272);
            this.grpbxPesan.Name = "grpbxPesan";
            this.grpbxPesan.Size = new System.Drawing.Size(150, 155);
            this.grpbxPesan.TabIndex = 35;
            this.grpbxPesan.TabStop = false;
            this.grpbxPesan.Text = "Pesan";
            // 
            // TombolPesan
            // 
            this.TombolPesan.BackColor = System.Drawing.Color.Firebrick;
            this.TombolPesan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TombolPesan.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolPesan.ForeColor = System.Drawing.Color.White;
            this.TombolPesan.Location = new System.Drawing.Point(24, 97);
            this.TombolPesan.Name = "TombolPesan";
            this.TombolPesan.Size = new System.Drawing.Size(100, 39);
            this.TombolPesan.TabIndex = 4;
            this.TombolPesan.Text = "Pesan";
            this.TombolPesan.UseVisualStyleBackColor = false;
            this.TombolPesan.Click += new System.EventHandler(this.TombolPesan_Click);
            // 
            // nudJumlahPesanan
            // 
            this.nudJumlahPesanan.Location = new System.Drawing.Point(24, 59);
            this.nudJumlahPesanan.Name = "nudJumlahPesanan";
            this.nudJumlahPesanan.Size = new System.Drawing.Size(100, 20);
            this.nudJumlahPesanan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah";
            // 
            // TombolBayar
            // 
            this.TombolBayar.BackColor = System.Drawing.Color.Firebrick;
            this.TombolBayar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TombolBayar.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolBayar.ForeColor = System.Drawing.Color.White;
            this.TombolBayar.Location = new System.Drawing.Point(324, 277);
            this.TombolBayar.Name = "TombolBayar";
            this.TombolBayar.Size = new System.Drawing.Size(61, 33);
            this.TombolBayar.TabIndex = 33;
            this.TombolBayar.Text = "Bayar";
            this.TombolBayar.UseVisualStyleBackColor = false;
            this.TombolBayar.Click += new System.EventHandler(this.TombolBayar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Meja";
            // 
            // DaftarPesanan
            // 
            this.DaftarPesanan.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.DaftarPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaftarPesanan.Location = new System.Drawing.Point(260, 41);
            this.DaftarPesanan.MultiSelect = false;
            this.DaftarPesanan.Name = "DaftarPesanan";
            this.DaftarPesanan.ReadOnly = true;
            this.DaftarPesanan.Size = new System.Drawing.Size(316, 225);
            this.DaftarPesanan.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(168, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(590, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalPesanan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DaftarMenu);
            this.Controls.Add(this.BestSeller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbbxNoMeja);
            this.Controls.Add(this.grpbxPesan);
            this.Controls.Add(this.TombolBayar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DaftarPesanan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaftarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestSeller)).EndInit();
            this.grpbxPesan.ResumeLayout(false);
            this.grpbxPesan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaftarPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPesanan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DaftarMenu;
        private System.Windows.Forms.DataGridView BestSeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbxNoMeja;
        private System.Windows.Forms.GroupBox grpbxPesan;
        private System.Windows.Forms.Button TombolPesan;
        private System.Windows.Forms.NumericUpDown nudJumlahPesanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TombolBayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DaftarPesanan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


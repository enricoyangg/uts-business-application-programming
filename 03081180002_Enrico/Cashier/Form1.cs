using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cashier
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataReader reader;
        SqlCommand cmd;
        public int tagihan = 0;
        public string linkfoto;
        public Form1()
        {
            InitializeComponent();

            conn = new SqlConnection("server = localhost; data source = localhost\\SQLEXPRESS; database = DB_DATA; integrated security = SSPI");
            conn.Open();

            CetakStruk.Enabled = false;
            HargaMenu.Minimum = 10000;
            HargaMenu.Maximum = 100000;
            HargaMenu.Increment = 1000;
            lblTotal.Text = "";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Meja1.BackColor = Color.White;
            Meja2.BackColor = Color.White;
            Meja3.BackColor = Color.White;
            Meja4.BackColor = Color.White;
            Meja5.BackColor = Color.White;
            Meja6.BackColor = Color.White;
            Meja7.BackColor = Color.White;
            Meja8.BackColor = Color.White;
            cmd = new SqlCommand("select TableNum from Meja where flag = 1 group by TableNum", conn);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    string temp = reader[0].ToString();
                    if (temp == "1")
                        Meja1.BackColor = Color.Lime;
                    else if (temp == "2")
                        Meja2.BackColor = Color.Lime;
                    else if (temp == "3")
                        Meja3.BackColor = Color.Lime;
                    else if (temp == "4")
                        Meja4.BackColor = Color.Lime;
                    else if (temp == "5")
                        Meja5.BackColor = Color.Lime;
                    else if (temp == "6")
                        Meja6.BackColor = Color.Lime;
                    else if (temp == "7")
                        Meja7.BackColor = Color.Lime;
                    else if (temp == "8")
                        Meja8.BackColor = Color.Lime;
                }
            reader.Close();
        }

        private void lblMeja1_Click(object sender, EventArgs e)
        {
            CetakBilling("1", Meja1.BackColor);
        }

        private void lblMeja2_Click(object sender, EventArgs e)
        {
            CetakBilling("2", Meja2.BackColor);
        }

        private void lblMeja3_Click(object sender, EventArgs e)
        {
            CetakBilling("3", Meja3.BackColor);
        }

        private void lblMeja4_Click(object sender, EventArgs e)
        {
            CetakBilling("4", Meja4.BackColor);
        }
        private void lblMeja5_Click(object sender, EventArgs e)
        {
            CetakBilling("5", Meja5.BackColor);
        }
        private void lblMeja6_Click(object sender, EventArgs e)
        {
            CetakBilling("6", Meja6.BackColor);
        }
        private void lblMeja7_Click(object sender, EventArgs e)
        {
            CetakBilling("7", Meja7.BackColor);
        }
        private void lblMeja8_Click(object sender, EventArgs e)
        {
            CetakBilling("8", Meja8.BackColor);
        }
        private void lblMeja9_Click(object sender, EventArgs e)
        {
            CetakBilling("9", Meja9.BackColor);
        }
        private void lblMeja10_Click(object sender, EventArgs e)
        {
            CetakBilling("10", Meja10.BackColor);
        }

        private void TombolCetak_Click(object sender, EventArgs e)
        {
            if (Meja.Rows.Count > 1)
            {
                tagihan = 0;

                for (int i = 0; i < Meja.Rows.Count; i++)
                    tagihan += Convert.ToInt32(Meja.Rows[i].Cells[3].Value);

                string sql = String.Format("insert into Admin values('{0}',convert(varchar,cast({1} as money)),'{2}')", lblNoMeja.Text, tagihan, DateTimeOffset.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                PrintPreviewDialog ppd1 = new PrintPreviewDialog();
                ppd1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("tes", 285, 600);
                ppd1.ShowDialog();

                sql = String.Format("Update Meja set flag = 0 where TableNum = '{0}'", lblNoMeja.Text);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = String.Format("Delete from Meja where TableNum = '{0}'", lblNoMeja.Text);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                Meja.DataSource = null;

                Form1_Load(null, null);
            }
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter($"select * from Admin where Tanggal = '{dtpTanggal.Value.ToString("yyyy/MM/dd")}'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Rekap");
            RincianPenjualan.DataSource = ds.Tables["Rekap"];
            int sum = 0;
            for (int i = 0; i < RincianPenjualan.Rows.Count; i++)
                sum += Convert.ToInt32(RincianPenjualan.Rows[i].Cells[1].Value);
            lblTotal.Text = $"Rp.{sum:N}";
            if (RincianPenjualan.Rows.Count < 1)
                RincianPenjualan.DataSource = null;
        }

        private void NamaMenu_Leave(object sender, EventArgs e)
        {
            TombolSaveUpdate.Enabled = true;
            string sql = String.Format("select NamaMenu, GambarMenu, HargaMenu from Menu where NamaMenu = '{0}'", NamaMenu.Text);
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            TombolSaveUpdate.Text = "Save";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    HargaMenu.Value = Convert.ToDecimal(reader[2]);
                    pictureBox1.Image = Image.FromFile($"{reader[1].ToString()}");
                    linkfoto = reader[1].ToString();
                }

                TombolSaveUpdate.Text = "Update";
                TombolDelete.Enabled = true;
            }
            reader.Close();
        }

        private void TombolGambar_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Images";
            openFileDialog1.Filter = "All Images|*.jpg;*.png;*.bmp";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString() != "")
            {
                linkfoto = openFileDialog1.FileName.ToString();
                pictureBox1.Image = Image.FromFile(linkfoto);
            }

        }

        private void TombolSaveUpdate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (TombolSaveUpdate.Text == "Update")
                {
                    string sql = String.Format("update Menu set HargaMenu = convert(money,{0}), GambarMenu = '{1}' where NamaMenu = '{2}'", HargaMenu.Value, linkfoto, NamaMenu.Text);
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                }
                else
                {
                    string sql = String.Format("Insert into Menu values('{0}','{1}',convert(money,{2}),0)", NamaMenu.Text, linkfoto, HargaMenu.Value);
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                Reset();
            }

        }
        private void TombolDelete_Click(object sender, EventArgs e)
        {
            if (TombolSaveUpdate.Text == "Update")
            {
                string sql = String.Format("Delete from Menu where NamaMenu = '{0}'", NamaMenu.Text);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Reset();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Arabia", new Font("Matura MT Script Capitals", 20, FontStyle.Bold), Brushes.Black, new Point(65, 10));
            e.Graphics.DrawLine(Pens.Black, new Point(0, 50), new Point(285, 50));
            e.Graphics.DrawLine(Pens.Black, new Point(0, 53), new Point(285, 53));
            e.Graphics.DrawString($"{DateTimeOffset.Now.ToString("dd MMM yyyy hh:mm:ss")}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(60, 60));

            string sql = String.Format("select m.NamaMenu,Qty, (HargaMenu * Qty) from Meja m inner join Menu n on m.NamaMenu = n.NamaMenu where TableNum = '{0}'", lblNoMeja.Text);
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            int inc = 0, bott = 110;
            e.Graphics.DrawString("Pesanan", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(30, 90));
            e.Graphics.DrawString("@", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(120, 90));
            e.Graphics.DrawString("Total", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(150, 90));
            while (reader.Read())
            {
                e.Graphics.DrawString($"{reader[0].ToString()}", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(30, bott + inc));
                e.Graphics.DrawString($"{reader[1].ToString()}", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(120, bott + inc));
                e.Graphics.DrawString($"Rp.{reader[2].ToString()}", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(150, bott + inc));
                inc += 15;
            }
            e.Graphics.DrawString($"Grand Total ....... Rp.{tagihan.ToString()}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(48, 250));
            e.Graphics.DrawString("Have a Good Day", new Font("Lucida Handwriting", 15, FontStyle.Bold), Brushes.Black, new Point(25, 270));
            reader.Close();
        }

        public void CetakBilling(string noMeja, Color bg)
        {
            SqlDataAdapter da = new SqlDataAdapter($"select t.NamaMenu, HargaMenu, Qty, HargaMenu*Qty Total, Tanggal from Menu m inner join Meja t on m.NamaMenu = t.NamaMenu where TableNum = {noMeja}", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            Meja.DataSource = ds.Tables["Menu"];
            lblNoMeja.Text = noMeja;
            if (bg == Color.Lime)
                CetakStruk.Enabled = true;
            else
                CetakStruk.Enabled = false;
        }

        public void Reset()
        {
            TombolSaveUpdate.Text = "Save";
            NamaMenu.Text = "";
            HargaMenu.Value = HargaMenu.Minimum;
            pictureBox1.Image = null;
            linkfoto = "";
            TombolSaveUpdate.Enabled = false;
            TombolDelete.Enabled = false;
        }
    }
}

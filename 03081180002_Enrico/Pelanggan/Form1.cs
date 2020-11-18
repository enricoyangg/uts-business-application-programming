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

namespace Pelanggan
{
    public partial class Form1 : Form
    {
        public string makanan;
        SqlConnection conn;
        SqlDataReader reader;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("server = localhost; data source = localhost\\SQLEXPRESS; database = DB_DATA; integrated security = SSPI");
            conn.Open();
            int i = 1;
            while (i < 11)
            {
                cmbbxNoMeja.Items.Add(i);
                i++;
            }
            nudJumlahPesanan.Minimum = 1;
            nudJumlahPesanan.Maximum = 20;
            DaftarPesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BestSeller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DaftarMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select NamaMenu, Cast(HargaMenu as decimal) Harga from Menu", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            DaftarMenu.DataSource = ds.Tables["Menu"];
            da = new SqlDataAdapter("select Top 2 NamaMenu, HargaMenu from Menu order by Populer desc", conn);
            ds = new DataSet();
            da.Fill(ds, "Menu");
            BestSeller.DataSource = ds.Tables["Menu"];
            lblTotalPesanan.Text = "0";
            
            DaftarMenu.Enabled = false;
            BestSeller.Enabled = false;
            TombolBayar.Enabled = false;
            cmbbxNoMeja.Enabled = true;
            DaftarMenu.ClearSelection();
            BestSeller.ClearSelection();
            DaftarPesanan.ClearSelection();
            DaftarPesanan.DataSource = null;
            pictureBox1.Image = null;
        }
        private void cmbbxNoMeja_SelectedIndexChanged(object sender, EventArgs e)
        {
            BestSeller.Enabled = true;
            DaftarMenu.Enabled = true;
            SqlDataAdapter da = new SqlDataAdapter($"select t.NamaMenu, HargaMenu, Qty, HargaMenu*Qty Total from Menu m inner join Meja t on m.NamaMenu = t.NamaMenu where TableNum = '{cmbbxNoMeja.SelectedItem}'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            DaftarPesanan.DataSource = ds.Tables["Menu"];
            if (DaftarPesanan.Rows.Count > 0)
                TombolBayar.Enabled = true;
        }

        private void BestSeller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DaftarMenu.ClearSelection();
            grpbxPesan.Enabled = true;
            makanan = BestSeller.Rows[e.RowIndex].Cells[0].Value.ToString();
            Gambar(makanan);
        }

        private void DaftarMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BestSeller.ClearSelection();
            grpbxPesan.Enabled = true;
            makanan = DaftarMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            Gambar(makanan);

        }

        private void TombolBayar_Click(object sender, EventArgs e)
        {
            if (DaftarPesanan.RowCount > 1)
            {
                MessageBox.Show("Mohon Menunggu Kasir kami");
                string sql = String.Format("Update Meja set flag = '1' where TableNum = '{0}'", cmbbxNoMeja.SelectedItem);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Form1_Load(null, null);
            }
        }
        private void TombolPesan_Click(object sender, EventArgs e)
        {
            TombolBayar.Enabled = true;
            string sql = String.Format("insert into Meja values('{0}','0','{1}','{2}',{3})", cmbbxNoMeja.SelectedItem, makanan, DateTimeOffset.Now.ToString("yyyy/MM/dd"), nudJumlahPesanan.Value);
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter($"select t.NamaMenu, HargaMenu, Qty, HargaMenu*Qty Total from Menu m inner join Meja t on m.NamaMenu = t.NamaMenu where TableNum = '{cmbbxNoMeja.SelectedItem}'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Pesanan");
            DaftarPesanan.DataSource = ds.Tables["Pesanan"];
            sql = String.Format("Update Menu set Populer += {0} where NamaMenu = '{1}'", nudJumlahPesanan.Value, makanan);
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            int total = 0;
            for (int i = 0; i < DaftarPesanan.Rows.Count; i++)
                total += Convert.ToInt32(DaftarPesanan.Rows[i].Cells[3].Value);
            lblTotalPesanan.Text = total.ToString();
        }

        public void Gambar(string makanan)
        {
            string sql = String.Format("Select GambarMenu from Menu where NamaMenu = '{0}'", makanan);
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                pictureBox1.Image = Image.FromFile(reader[0].ToString());
            reader.Close();
        }

    }
}

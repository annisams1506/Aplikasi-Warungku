using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarungKu
{
    public partial class FormBarang : Form
    {
        Connection con;
        public FormBarang()
        {
            InitializeComponent();
            con = new Connection();

            //MASUKKAN DATA KATEGORI DARI TABLE KE COMBOBOX
            cbkategori.ValueMember = "id_kategori";
            cbkategori.DisplayMember = "nama_kategori";
            cbkategori.DataSource = con.loadComboBox("select id_kategori, nama_kategori from kategori");

            cbfilter .ValueMember = "id_kategori";
            cbfilter.DisplayMember = "nama_kategori";
            cbfilter.DataSource = con.loadComboBox("select id_kategori, nama_kategori from kategori");
            refreshData();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnkasir_Click(object sender, EventArgs e)
        {
            FormKasir fk = new FormKasir();
            fk.Show();
            this.Hide();
        }
        private void btnkategori_Click(object sender, EventArgs e)
        {
            FormKategori  fk = new FormKategori();
            fk.Show();
            this.Hide();
        }
        private void refreshData()
        {
            dataGridViewBarang.DataSource = con.GetTable("select id_barang as'ID Barang', nama_barang as 'Nama Barang', jumlah as Jumlah, harga as Harga, nama_kategori as 'Nama Kategori' from barang join kategori on barang.id_kategori = kategori.id_kategori");

            //mengatur lebar kolom
            dataGridViewBarang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBarang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBarang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBarang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBarang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //mengatur alignment kolom
            dataGridViewBarang.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void clearTextbox()
        {
            txtharga.Text = "";
            txtidbarang.Text = "";
            txtjml.Text = "";
            txtnamabarang.Text = "";
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtidbarang.Text=="" || txtnamabarang.Text=="" || txtharga.Text == "" || txtjml.Text=="")
                {
                    MessageBox.Show("Data Tidak Lengksp !   ");
                }
                else
                {
                    con.executeUpdate("insert into barang values ('" + txtidbarang.Text + "','" + txtnamabarang.Text + "','" + txtjml.Text + "','" + txtharga.Text + "','" + cbkategori.SelectedValue.ToString() + "')");
                    MessageBox.Show("Barang Berhasil Ditambahkan !");
                    refreshData();
                    clearTextbox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pilihData(object sender, DataGridViewCellEventArgs e)
        {
            txtidbarang.Text = dataGridViewBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnamabarang .Text = dataGridViewBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtjml .Text = dataGridViewBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtharga .Text = dataGridViewBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbkategori.SelectedValue = con.GetTable("select id_kategori from kategori where nama_kategori = '" + dataGridViewBarang.Rows[e.RowIndex].Cells[4].Value.ToString() + "'").Rows[0][0].ToString();

        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtidbarang.Text=="" || txtharga.Text=="" || txtjml.Text==""|| txtnamabarang.Text=="")
                {
                    MessageBox.Show("Data Tidak Lengkap ! ");
                }
                else
                {
                    con.executeUpdate("update barang set nama_barang = '" + txtnamabarang.Text + "', jumlah='" + txtjml.Text + "', harga='" + txtharga.Text + "', id_kategori='" + cbkategori.SelectedValue.ToString() + "' where id_barang ='" + txtidbarang.Text + "'");
                    MessageBox.Show("Data Berhasil Diperbaharui !");
                    refreshData();
                    clearTextbox();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidbarang.Text == "")
                {
                    MessageBox.Show("Pilih Kategori Terlebih dahulu");
                }
                else
                {
                    con.executeUpdate("Delete from barang where id_barang='" + txtidbarang .Text + "'");
                    MessageBox.Show("Kategori BErhasil Dihapus");
                    refreshData();
                    clearTextbox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnfilter_Click(object sender, EventArgs e)
        {
            dataGridViewBarang.DataSource = con.GetTable("select id_barang as'ID Barang', nama_barang as 'Nama Barang', jumlah as Jumlah, harga as Harga, nama_kategori as 'Nama Kategori' from barang join kategori on barang.id_kategori = kategori.id_kategori where barang.id_kategori = '" + cbfilter.SelectedValue.ToString()+"'") ;
            //mengatur lebar kolom
            dataGridViewBarang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBarang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBarang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBarang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBarang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //mengatur alignment kolom
            dataGridViewBarang.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}

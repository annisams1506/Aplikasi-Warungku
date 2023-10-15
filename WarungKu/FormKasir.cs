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
    public partial class FormKasir : Form
    {
        Connection con;
        public FormKasir()
        {
            InitializeComponent();
            con = new Connection();
            refreshData();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnbarang_Click(object sender, EventArgs e)
        {
            FormBarang FB = new FormBarang();
            FB.Show();
            this.Hide();
        }
        private void btnkategori_Click(object sender, EventArgs e)
        {
            FormKategori FK = new FormKategori();
            FK.Show();
            this.Hide();
        }
        private void refreshData()
        {
            dataGridViewKasir.DataSource = con.GetTable("Select id_kasir as 'ID Kasir', nama_kasir as 'Nama Kasir', umur as Umur, no_hp as 'No Hp', password_kasir as 'Password Kasir' from kasir");

            dataGridViewKasir.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKasir.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKasir.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKasir.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKasir.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewKasir.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void clearTextbox()
        {
            txtidkasir.Text = "";
            txtnamakasir.Text = "";
            txtnohp.Text = "";
            txtumur.Text = "";
            txtpw.Text = "";
        }
        private void btntambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidkasir.Text == "" || txtnamakasir.Text == "" || txtnohp.Text == "" || txtpw.Text == "" || txtumur.Text=="")
                {
                    MessageBox.Show("Data Tidak Lengksp !   ");
                }
                else
                {
                    con.executeUpdate("insert into kasir values ('" + txtidkasir .Text + "','" + txtnamakasir.Text + "','" + txtumur .Text + "','" + txtnohp .Text + "','" + txtpw.Text  + "')");
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
            txtidkasir.Text = dataGridViewKasir.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnamakasir.Text = dataGridViewKasir.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtumur.Text = dataGridViewKasir.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtnohp.Text = dataGridViewKasir.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtpw.Text = dataGridViewKasir.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtidkasir.Text=="" || txtnamakasir.Text=="" || txtnohp.Text=="" || txtpw.Text=="" || txtumur.Text=="")
                {
                    MessageBox.Show("Data Tidak Lengkap");
                }
                else
                {
                    con.executeUpdate("update kasir set nama_kasir = '" + txtnamakasir.Text + "', umur='" + txtumur.Text + "', no_hp='" + txtnohp.Text + "', password_kasir='" + txtpw.Text + "' where id_kasir='" + txtidkasir.Text + "'");
                    MessageBox.Show("Kasir Berhasil Diperbaharui !");
                    refreshData();
                    clearTextbox();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnhapus_Click(object sender, EventArgs e)    
        {
            try
            {
                if (txtidkasir.Text == "")
                {
                    MessageBox.Show("Pilih Data Terlebih dahulu");
                }
                else
                {
                    con.executeUpdate("Delete from kategori where id_kasir='" + txtidkasir.Text + "'");
                    MessageBox.Show("Kategori BErhasil Dihapus");
                    refreshData ();
                    clearTextbox  ();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class FormKategori : Form
    {
        Connection con;
        public FormKategori()
        {
            InitializeComponent();
            con = new Connection();
            refreshdata();
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

        private void btnkasir_Click(object sender, EventArgs e)
        {
            FormKasir FK = new FormKasir();
            FK.Show();
            this.Hide();
        }
        //prosedur utk menghapus text pada textbox
        private void cleartextbox()
        {
            txtidkategori.Text = "";
            txtdeskripsi.Text = "";
            txtnamakategori.Text = "";            
        }
        //prosedur utk mengambil data pada tabel kategori
        private void refreshdata()
        {
            dataGridViewKategori.DataSource = con.GetTable("select id_kategori as 'ID Kategori', nama_kategori as 'Nama Kategori', deskripsi as Deskripsi from Kategori");
            //mengatur lebar kolom datagridview
            dataGridViewKategori.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewKategori.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewKategori.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ;
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidkategori.Text=="" || txtnamakategori.Text=="" || txtdeskripsi.Text == "")
                {
                    MessageBox.Show("Data Tidak Lengkap !");
                }
                else
                {
                    con.executeUpdate("insert into kategori values ('" + txtidkategori.Text + "','" + txtnamakategori.Text + "','" + txtdeskripsi.Text + "')");
                    MessageBox.Show("Kategori Berhasil Ditambahkan !");
                    refreshdata();
                    cleartextbox();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pilihData(object sender, DataGridViewCellEventArgs e)
        {
            txtidkategori.Text = dataGridViewKategori.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnamakategori .Text = dataGridViewKategori.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdeskripsi.Text = dataGridViewKategori.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtidkategori.Text=="" || txtdeskripsi.Text=="" || txtnamakategori.Text=="")
                {
                    MessageBox.Show("Data TIdak Lengkap");
                }
                else
                {
                    con.executeUpdate("Update kategori set nama_Kategori = '" + txtnamakategori.Text + "', deskripsi ='" + txtdeskripsi.Text + "' where id_kategori='" + txtidkategori.Text + "'");
                    MessageBox.Show("Kategori Berhasil Diperbarui ! ");
                    refreshdata();
                    cleartextbox();  
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
                if (txtidkategori.Text == "")
                {
                    MessageBox.Show("Pilih Kategori Terlebih dahulu");
                }
                else
                {
                    con.executeUpdate("Delete from kategori where id_kategori='" + txtidkategori.Text + "'");
                    MessageBox.Show("Kategori BErhasil Dihapus");
                    refreshdata();
                    cleartextbox();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormKategori_Load(object sender, EventArgs e)
        {

        }
    }
}

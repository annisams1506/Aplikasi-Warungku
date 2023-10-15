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
    public partial class FormPenjualan : Form
    {
        Connection con;
        //datatable untuk data source datagridviewpemesanan
        DataTable detail = new DataTable();
        //variable untuk meghitung pemesanan
        int n = 0;
        int grandTotal = 0;
        int statusTambahBarang = 0;
        public FormPenjualan()
        {
            InitializeComponent();
            con = new Connection();
            //load nama kasir ke label kasir
            labelkasir.Text = Kasir.namaKasir;
            //load tanggal ke labeldate
            labeldate.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            //ambil data kategori di database dan dimasukkan ke combobox
            cbfilter.ValueMember = "id_kategori";
            cbfilter.DisplayMember = "nama_kategori";
            cbfilter.DataSource = con.loadComboBox("select id_kategori, nama_kategori from kategori");
            generateIDPenjualan();
            refreshListBarang();
            refreshPenjualan();
            //membuat kolom DataTable detail
            detail.Columns.Add("No", typeof(string));
            detail.Columns.Add("ID Barang", typeof(string));
            detail.Columns.Add("Nama Barang", typeof(string));
            detail.Columns.Add("Harga", typeof(string));
            detail.Columns.Add("Jumlah", typeof(string));
             detail.Columns.Add("Total", typeof(string));
            //Menghilangkan kolom pertama yang kosong pada datagridview penjualan agar tidak ikut ter ekspor
            dataGridViewpenjualan.RowHeadersVisible = false;
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            FormLogin  FL = new FormLogin();
            FL .Show();
            this.Hide();
            //Application.Exit();
        }
        private void clearTextbox()
        {
            txtidbarang.Text = "";
            txtnamabarang.Text = "";
            txtharga.Text = "";
            txtjml.Text = "";
        }
        //prosedur untuk generate ID Penjualan
        private void generateIDPenjualan()
        {
            //kode otomatis id penjualan
            string kode = "PJ";
            DataTable dt = con.GetTable("select id_penjualan from penjualan where tanggal_penjualan='" + System.DateTime.Today.ToString("yyyyMMdd") + "' order by id_penjualan desc");
            //cek table penjualan sudah terisi/blm
            if (dt.Rows.Count != 0)
            {
                //AMBIL 5 karakter terakhir dari id_penjualan teratas/ id_penjualan terakhir
                String genData = dt.Rows[0][0].ToString().Substring(10);
                //tambahkan 1 dari kode penjualan terakhir
                int genCode = Int32.Parse(genData) + 1;
                //gabungkan 2 karakter kode + 8 karakter tanggal hari ini + kode penjualan terbaru
                labelidpenjualan.Text = kode + System.DateTime.Today.ToString("yyyyMMdd") + genCode.ToString("00000");
            }
            else
            {
                //set id penjualan 1 jika belum ada penjualan di hari itu
                labelidpenjualan.Text = kode + System.DateTime.Today.ToString("yyyyMMdd") + "00001";
            }
        }
        //proseduruntuk mengambil data barang dan diisi ke datagridviewlist barang
        private void refreshListBarang()
        {
            dataGridViewfilter.DataSource = con.GetTable("select nama_barang as 'Nama Barang', jumlah as Jumlah from barang");
            //untuk warp text column
            dataGridViewfilter.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //mengatur lebar kolom
            dataGridViewfilter.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewfilter.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //mengatur alignment kolom
            dataGridViewfilter.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        //prosedur untuk mengambil data penjualan dan mengisi datagridviewpenjualan
        private void refreshPenjualan()
        {
            dataGridViewpenjualan.DataSource = con.GetTable("select penjualan.id_penjualan as 'ID Penjualan', kasir.nama_kasir as 'Nama Kasir', convert(varchar, tanggal_penjualan, 103) as Tanggal, sum(harga_jual * jumlah_jual) as Total from penjualan join kasir on penjualan.id_kasir = kasir.id_kasir join detail_penjualan on penjualan.id_penjualan = detail_penjualan.id_penjualan group by penjualan.id_penjualan, kasir.nama_kasir, penjualan.tanggal_penjualan");
            dataGridViewpenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewpenjualan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void pilihData(object sender, DataGridViewCellEventArgs e)
        {
            txtnamabarang.Text = dataGridViewfilter.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtharga.Text = con.GetTable("select harga from barang where nama_barang ='" + txtnamabarang.Text + "'").Rows[0][0].ToString();
            txtidbarang.Text = con.GetTable("select id_barang from barang where nama_barang ='" + txtnamabarang.Text + "'").Rows[0][0].ToString();
        }
        private void btntambahbarang_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidbarang.Text == "" || txtharga.Text == "" || txtjml.Text == "" || txtnamabarang.Text == "")
                {
                    MessageBox.Show("Data Tidak Lengkap");
                }
                else
                {
                    if (Convert.ToInt32(txtjml.Text) >= Convert.ToInt32(con.GetTable("select jumlah from barang where nama_barang='" + txtnamabarang.Text + "'").Rows[0][0].ToString()))
                    {
                        MessageBox.Show("Stok Barang Tidak Cukup");
                    }
                    else
                    {
                        //menghitung kolom total
                        int total = Int32.Parse(txtharga.Text) * Int32.Parse(txtjml.Text);

                        //mengisi datatable detail sessuai dgn input
                        detail.Rows.Add((n + 1), txtidbarang.Text, txtnamabarang.Text, txtharga.Text, txtjml.Text, total);
                        dataGridViewPemesanan.DataSource = detail;

                        //mengatur format tampilan datagridview
                        dataGridViewPemesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewPemesanan.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dataGridViewPemesanan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        dataGridViewPemesanan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridViewPemesanan.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridViewPemesanan.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        n++;
                        grandTotal = grandTotal + total;
                        labeltotal.Text = "Rp " + grandTotal;
                        statusTambahBarang = 1;
                    }
                }
                clearTextbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btntambah_Click(object sender, EventArgs e)
        {
            try
            {
                if(statusTambahBarang != 1)
                {
                    MessageBox.Show("Isi Barang Yang Dijual !");
                }
                else
                {
                    //insert ke table enjualan
                    con.executeUpdate("insert into penjualan values('" + labelidpenjualan.Text + "','" + Kasir.idKasir + "','" + System.DateTime.Today.ToString("yyyyMMdd") + "')") ;
                    //variable untuk menghitung stok barang
                    int updateStok, genStok, genJml;
                    //memasukkan setiap data yang ada di datagridviewpemesanan dan update stok pada table barang
                    for(int i=0; i< dataGridViewPemesanan.Rows.Count - 1; i++)
                    {
                        //ambil jumlah barang yang ada di database
                        genStok = Int32.Parse(con.GetTable("select jumlah from barang where id_barang = '" + detail.Rows[i][1].ToString() + "'").Rows[0][0].ToString());
                        //ambil barang yang dipesan dari datagridviewpemesanan
                        genJml = Int32.Parse(detail.Rows[i][4].ToString());
                        //data jumlah barang - jumlah barang yang dipesan
                        updateStok = genStok - genJml;
                        con.executeUpdate("update barang set jumlah='" + updateStok + "' where id_barang ='" + detail.Rows[i][1].ToString() + "'");
                        con.executeUpdate("insert into detail_penjualan values ('" + labelidpenjualan.Text + "','" + detail.Rows[i][1].ToString() + "','" + detail.Rows[i][3].ToString() + "','" + detail.Rows[i][4].ToString() + "')");
                    }
                    dataGridViewPemesanan.DataSource = null;
                    dataGridViewPemesanan.Rows.Clear();
                    detail.Rows.Clear();
                    refreshPenjualan();
                    refreshListBarang();
                    clearTextbox();
                    generateIDPenjualan();
                    n = 0;
                    statusTambahBarang = 0;
                    grandTotal = 0;
                    labeltotal.Text = "Rp " + grandTotal;                      
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnexport_Click(object sender, EventArgs e)
        {
            dataGridViewpenjualan.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewpenjualan.SelectAll();
            dataGridViewpenjualan.SelectAll();
            DataObject copyData = dataGridViewpenjualan.GetClipboardContent();
            if(copyData != null)
            {
                Clipboard.SetDataObject(copyData);
            }
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWsheet;
            object missData = System.Reflection.Missing.Value;
            xlWbook = xlApp.Workbooks.Add(missData);
            xlWsheet = (Microsoft.Office.Interop.Excel.Worksheet)
                xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlWsheet.Cells[1, 1];
            xlr.Select();
            xlWsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            dataGridViewPemesanan.DataSource = null;
            dataGridViewPemesanan.Rows.Clear();
            detail.Rows.Clear();
            clearTextbox();
            n = 0;
            statusTambahBarang = 0;
            grandTotal = 0;
            labeltotal.Text = "RP. " + grandTotal;
            generateIDPenjualan(); 
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshListBarang();
        }
        private void btnfilter_Click(object sender, EventArgs e)
        {
            dataGridViewfilter.DataSource = con.GetTable("select nama_barang as 'Nama Barang', jumlah as Jumlah from barang join kategori on barang.id_kategori = kategori.id_kategori where barang.id_kategori ='" + cbfilter.SelectedValue.ToString() + "'");
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormLogin : Form
    {
        Connection con;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void labelkeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void labelclear_Click(object sender, EventArgs e)
        {
            txtpw.Text = "";
            txtuser.Text = "";
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text =="" || txtpw.Text == "")
            {
                MessageBox.Show("Isi Username dan Password ! ");
            }
            else
            {
                if (cbperan.SelectedIndex > -1)
                {
                    if(cbperan.SelectedItem.ToString() == "Admin")
                    {
                        if(txtuser.Text=="Admin" && txtpw.Text == "admin123")
                        {
                            MessageBox.Show("Selamat Datang Admin ! ");
                            FormBarang FB = new FormBarang();
                            FB.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Jika Anda Admin, Masukkan Ussername dan Password Yang Benar ! ");
                        }
                    }
                    else
                    {
                        con = new Connection();
                        int RowCount = con.GetTable("select id_kasir from kasir where id_kasir ='" + txtuser.Text + "' and password_kasir = '" + txtpw.Text + "'").Rows.Count;
                        if (RowCount > 0)
                        {
                            Kasir.idKasir = txtuser.Text;
                            Kasir.passwordKasir = txtpw.Text;
                            Kasir.namaKasir = con.GetTable("select nama_kasir from kasir where id_kasir ='" + txtuser.Text + "' and password_kasir='" + txtpw.Text + "'").Rows[0][0].ToString();
                            Kasir.noHP = con.GetTable("select no_hp from kasir where id_kasir ='" + txtuser.Text + "' and password_kasir ='" + txtpw.Text + "'").Rows[0][0].ToString();
                            Kasir.umur =con.GetTable("select umur from kasir where id_kasir ='" + txtuser.Text + "' and password_kasir ='" + txtpw.Text + "'").Rows[0][0].ToString();

                            MessageBox.Show("Selamat Datang " + Kasir.namaKasir);
                            FormPenjualan FP = new FormPenjualan();
                            FP.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Jika Anda Kasir, Masukkan Username dan Password yang benar !");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pilih Peran Untuk Login !");
                }
            }
        }
        private void cbperan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

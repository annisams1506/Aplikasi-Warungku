using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WarungKu
{
    class Connection
    {
        SqlConnection con;

        public Connection()
        {
            con = new SqlConnection(@"Data Source=ANNISA;Initial Catalog=warungku;Integrated Security=True");
            con.Open();
        }
        public DataTable GetTable(string query)
        {
            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
            con.Open();

            SqlDataAdapter table = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            table.Fill(dt);
            con.Close();
            return dt;
        }
        public void executeUpdate(string query)
        {
            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public DataTable loadComboBox (string query)
        {
            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
            con.Open();
            SqlCommand command=new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_kategori", typeof(string));
            dt.Columns.Add("nama_kategori", typeof(string));
            dt.Load(rdr);
            con.Close();
            return dt;
        }
    }
}
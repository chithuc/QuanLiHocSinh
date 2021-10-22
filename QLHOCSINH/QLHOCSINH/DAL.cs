using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHOCSINH
{
    class DAL
    {
        public SqlConnection GetConnection()
        {
            String connString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLHOCSINH;Integrated Security=True";
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable GetTable(string sql)
        {
            SqlConnection con = GetConnection();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public SqlDataReader rdr(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader();
        }
    }
}

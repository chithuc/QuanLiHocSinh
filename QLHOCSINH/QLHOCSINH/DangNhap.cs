using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHOCSINH
{
    public partial class FormDangNhap : Form
    {
        static String sqlConnectStr = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLHOCSINH;Integrated Security=True";
        SqlConnection conn = new SqlConnection(sqlConnectStr);
        public FormDangNhap()
        {
            InitializeComponent();
        }



        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void bttDangNhap_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Account where UserName=N'" + txtTaiKhoan.Text + "' and Password =N'" + txtMatKhau.Text + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                FormMenuChinh frm = new FormMenuChinh();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ban dang nhap khong thanh cong!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                txtTaiKhoan.Focus();
            }
        }
    }
}

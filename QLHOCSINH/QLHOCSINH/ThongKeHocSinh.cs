using QLHOCSINH.DTO;
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
using Microsoft.Reporting.WinForms;

namespace QLHOCSINH
{
    public partial class FormThongKeHocSinh : Form
    {
        public FormThongKeHocSinh()
        {
            InitializeComponent();
        }

        private void ThongKeHocSinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLopHoc.HocSinh' table. You can move, or remove it, as needed.
            this.HocSinhTableAdapter.Fill(this.dsLopHoc.HocSinh);
            this.reportHocSinh.RefreshReport();
        }
      
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            reportHocSinh.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FormTKHocSinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormMenuChinh frm = new FormMenuChinh();
            frm.Show();
        }
    }
}

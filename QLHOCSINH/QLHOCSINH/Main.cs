using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHOCSINH
{
    public partial class FormMenuChinh : Form
    {
        public FormMenuChinh()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void mntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void mntDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận đăng xuất ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap frm = new FormDangNhap();
                frm.Show();
            }
        }

        private void mntHocSinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHocSinh frm = new FormHocSinh();
            frm.Show();
        }

        private void mntLopHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLopHoc frm = new FormLopHoc();
            frm.Show();
        }

        private void mntMonHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMonHoc frm = new FormMonHoc();
            frm.Show();
        }

        private void mntBangDiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBangDiem frm = new FormBangDiem();
            frm.Show();
        }

        private void mntThongKeLopHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongKeLopHoc frm = new FormThongKeLopHoc();
            frm.Show();
        }

        private void mntThongKeHocSinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongKeHocSinh frm = new FormThongKeHocSinh();
            frm.Show();
        }

        private void mntThongKeBangDiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeBangDiem frm = new ThongKeBangDiem();
            frm.Show();
        }
    }
}

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
    public partial class ThongKeBangDiem : Form
    {
        public ThongKeBangDiem()
        {
            InitializeComponent();
        }

        private void ThongKeBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLopHoc.BangDiem' table. You can move, or remove it, as needed.
            this.BangDiemTableAdapter.Fill(this.dsLopHoc.BangDiem);
            this.reportBangDiem.RefreshReport();

        }

        private void FormTKBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormMenuChinh frm = new FormMenuChinh();
            frm.Show();
        }
    }
}

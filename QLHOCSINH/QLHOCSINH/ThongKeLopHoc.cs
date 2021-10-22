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
    public partial class FormThongKeLopHoc : Form
    {
        public FormThongKeLopHoc()
        {
            InitializeComponent();
        }

        private void FormThongKeLopHoc_Load(object sender, EventArgs e)
        {
            this.LopHocTableAdapter.Fill(this.dsLopHoc.LopHoc);

            this.reportLopHoc.RefreshReport();
        }

        private void FormTKLH_Formclosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormMenuChinh frm = new FormMenuChinh();
            frm.Show();
        }
    }
}

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
    public partial class FormLopHoc : Form
    {
        BLL bll = new BLL();

        public FormLopHoc()
        {
            InitializeComponent();
        }
        private void resetValue()
        {
            txtMaL.Text = "";
            txtTenLop.Clear();
            txtSiSo.Clear();
            txtKhoaHoc.Clear();
            txtMaL.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtTenLop.Text) || string.IsNullOrEmpty(txtSiSo.Text) || string.IsNullOrEmpty(txtKhoaHoc.Text) )
                {
                    MessageBox.Show("vui lòng nhập đầy đủ các trường còn lại");
                }
                else
                {
                    int count = 0;
                    count = dataLopHoc.Rows.Count;
                    string chuoi1 = "";
                    int chuoi2 = 0;
                    chuoi1 = Convert.ToString(dataLopHoc.Rows[count - 2].Cells[0].Value);
                    chuoi2 = Convert.ToInt32(chuoi1.Remove(0,1));
                    if(chuoi2 + 1  < 10)
                    {
                        txtMaL.Text = "L00" + (chuoi2 + 1).ToString();
                    }
                    else if(chuoi2 + 1 < 100)
                    {
                        txtMaL.Text = "L0" + (chuoi2 + 1).ToString();
                    }
                    bll.InsertLopHoc(txtMaL.Text,txtTenLop.Text, Int32.Parse(txtSiSo.Text), txtKhoaHoc.Text);
                    FormLopHoc_Load(sender, e);
                    resetValue();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trường sĩ số phải là số");
            }
        }

        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.showLopHoc();
            dataLopHoc.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaL.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bll.UpdateLopHoc(txtMaL.Text, txtTenLop.Text, Int32.Parse(txtSiSo.Text), txtKhoaHoc.Text); 
                FormLopHoc_Load(sender, e);
                resetValue();
            }
        }
        int Vitri;

        private void dataLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Vitri = e.RowIndex;
            if (Vitri >=0)
            {
                txtMaL.Text = dataLopHoc.Rows[Vitri].Cells[0].Value.ToString();
                txtTenLop.Text = dataLopHoc.Rows[Vitri].Cells[1].Value.ToString();
                txtSiSo.Text = dataLopHoc.Rows[Vitri].Cells[2].Value.ToString();
                txtKhoaHoc.Text = dataLopHoc.Rows[Vitri].Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaL.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bll.DeleteLopHoc(txtMaL.Text);
                FormLopHoc_Load(sender, e);
                resetValue();
            }
        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn quay lại không?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (h == DialogResult.OK)
            {
                this.Hide();
                FormMenuChinh frm = new FormMenuChinh();
                frm.Show();
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (txtTKMaLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaL.Focus();
            }
            else
            {
                string ml = txtTKMaLop.Text;
                DataTable dt = new DataTable();
                dt = bll.TimLopHoc(txtTKMaLop.Text);
                dataLopHoc.DataSource = dt;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaL.Enabled = false;
            txtMaL.Text = "";
            txtTenLop.Focus();
            txtTenLop.Clear();
            txtSiSo.Clear();
            txtKhoaHoc.Clear();
        }

    }
}

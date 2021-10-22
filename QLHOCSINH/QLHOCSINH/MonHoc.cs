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
    public partial class FormMonHoc : Form
    {
        BLL bll = new BLL();
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.showMonHoc();
            dataMonHoc.DataSource = dt;
        }

        private void resetValue()
        {
            txtMaMH.Text = "";
            txtTenMH.Clear();
            txtMaHS.Clear();
            cbHocKy.Text = "";
            txtSoTiet.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenMH.Text) || string.IsNullOrEmpty(txtMaHS.Text) || string.IsNullOrEmpty(cbHocKy.Text) || string.IsNullOrEmpty(txtSoTiet.Text))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ các trường còn lại");
                }
                else
                {
                    int count = 0;
                    count = dataMonHoc.Rows.Count;
                    string chuoi1 = "";
                    int chuoi2 = 0;
                    chuoi1 = Convert.ToString(dataMonHoc.Rows[count - 2].Cells[0].Value);
                    chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
                    if (chuoi2 + 1 < 10)
                    {
                        txtMaMH.Text = "MH00" + (chuoi2 + 1).ToString();
                    }
                    else if (chuoi2 + 1 < 100)
                    {
                        txtMaMH.Text = "MH0" + (chuoi2 + 1).ToString();
                    }
                    bll.InsertMonHoc(txtMaMH.Text, txtTenMH.Text, txtMaHS.Text, cbHocKy.Text, Int32.Parse(txtSoTiet.Text));
                    FormMonHoc_Load(sender, e);
                    resetValue();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trường số tiết phải là số");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bll.UpdateMonHoc(txtMaMH.Text, txtTenMH.Text, txtMaHS.Text, cbHocKy.Text, Int32.Parse(txtSoTiet.Text));
                resetValue();
                FormMonHoc_Load(sender, e);              
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bll.DeleteMonHoc(txtMaMH.Text);
                FormMonHoc_Load(sender, e);
                resetValue();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaMH.Enabled = false;
            txtTenMH.Focus();
            txtTenMH.Clear();
            txtMaHS.Clear();
            cbHocKy.Text = "";
            txtSoTiet.Clear();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTKMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTKMH.Focus();
            }
            else
            {
                string mmh = txtTKMH.Text;
                DataTable dt = new DataTable();
                dt = bll.TimMonHoc(txtTKMH.Text);
                dataMonHoc.DataSource = dt;
            }
        }

        int Vitri;
        private void dataMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Vitri = e.RowIndex;
            if (Vitri >= 0)
            {
                txtMaMH.Text = dataMonHoc.Rows[Vitri].Cells[0].Value.ToString();
                txtTenMH.Text = dataMonHoc.Rows[Vitri].Cells[1].Value.ToString();
                txtMaHS.Text = dataMonHoc.Rows[Vitri].Cells[2].Value.ToString();
                cbHocKy.Text = dataMonHoc.Rows[Vitri].Cells[3].Value.ToString();
                txtSoTiet.Text = dataMonHoc.Rows[Vitri].Cells[4].Value.ToString();
            }
        }
    }
}

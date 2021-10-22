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
    public partial class FormBangDiem : Form
    {
        BLL bll = new BLL();
        public FormBangDiem()
        {
            InitializeComponent();
        }

        private void FormBangDiem_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.showBangDiem();
            dataBangDiem.DataSource = dt;
        }

        private void resetValue()
        {
            txtMaBD.Text = "";
            txtMaHS.Clear();
            txtMaMH.Clear();
            txtDiem.Clear();
            txtXepLoai.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                count = dataBangDiem.Rows.Count;
                string chuoi1 = "";
                int chuoi2 = 0;
                chuoi1 = Convert.ToString(dataBangDiem.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
                if (chuoi2 + 1 < 10)
                {
                    txtMaBD.Text = "BD00" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 100)
                {
                    txtMaBD.Text = "BD0" + (chuoi2 + 1).ToString();
                }
                if (string.IsNullOrEmpty(txtMaHS.Text) || string.IsNullOrEmpty(txtMaMH.Text) || string.IsNullOrEmpty(txtDiem.Text) || string.IsNullOrEmpty(txtXepLoai.Text))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ các trường còn lại");
                }
                else
                {
                    bll.InsertBangDiem(txtMaBD.Text, txtMaHS.Text, txtMaMH.Text, float.Parse(txtDiem.Text), txtXepLoai.Text);
                    FormBangDiem_Load(sender, e);
                    resetValue();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trường Điểm phải là số");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaBD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bll.UpdateBangDiem(txtMaBD.Text, txtMaHS.Text, txtMaMH.Text, float.Parse(txtDiem.Text), txtXepLoai.Text);
                resetValue();
                FormBangDiem_Load(sender, e);
            }
        }

        int Vitri;
        private void dataBangDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Vitri = e.RowIndex;
            if (Vitri >= 0)
            {
                txtMaBD.Text = dataBangDiem.Rows[Vitri].Cells[0].Value.ToString();
                txtMaHS.Text = dataBangDiem.Rows[Vitri].Cells[1].Value.ToString();
                txtMaMH.Text = dataBangDiem.Rows[Vitri].Cells[2].Value.ToString();
                txtDiem.Text = dataBangDiem.Rows[Vitri].Cells[3].Value.ToString();
                txtXepLoai.Text = dataBangDiem.Rows[Vitri].Cells[4].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bll.DeleteBangDiem(txtMaBD.Text);
                FormBangDiem_Load(sender, e);
                resetValue();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaBD.Enabled = false;
            txtMaHS.Focus();
            txtMaHS.Clear();
            txtMaMH.Clear();
            txtDiem.Clear();
            txtXepLoai.Clear();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn quay lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (h == DialogResult.OK)
            {
                this.Hide();
                FormMenuChinh frm = new FormMenuChinh();
                frm.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTKBD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã bảng điểm để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTKBD.Focus();
            }
            else
            {
                string mbd = txtTKBD.Text;
                DataTable dt = new DataTable();
                dt = bll.TimBangDiem(txtTKBD.Text);
                dataBangDiem.DataSource = dt;
            }
        }
    }
}

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
    public partial class FormHocSinh : Form
    {
        BLL bll = new BLL();
        public FormHocSinh()
        {
            InitializeComponent();
        }

        private void resetValue()
        {
            txtMaHS.Clear();
            txtTenHS.Clear();
            txtMaLop.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = true;
            txtDiaChi.Clear();
            txtSDT.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenHS.Text) || string.IsNullOrEmpty(txtMaLop.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ các trường còn lại");
                }
                else
                {
                    int count = 0;
                    count = dataThongTinHS.Rows.Count;
                    string chuoi1 = "";
                    int chuoi2 = 0;
                    chuoi1 = Convert.ToString(dataThongTinHS.Rows[count - 2].Cells[0].Value);
                    chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
                    if (chuoi2 + 1 < 10)
                    {
                        txtMaHS.Text = "HS00" + (chuoi2 + 1).ToString();
                    }
                    else if (chuoi2 + 1 < 100)
                    {
                        txtMaHS.Text = "HS0" + (chuoi2 + 1).ToString();
                    }
                    Boolean gt;
                    if (rdbNam.Checked) gt = true;
                    else gt = false;

                    bll.InsertHocSinh(txtMaHS.Text,txtTenHS.Text, txtMaLop.Text, dtpNgaySinh.Value, gt, txtDiaChi.Text, Int32.Parse(txtSDT.Text));
                    FormHocSinh_Load(sender, e);
                    resetValue();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Trường SDT phải là số");
            }           
        }

        private void FormHocSinh_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.showHocSinh();
            dataThongTinHS.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Boolean gt;
                if (rdbNam.Checked) gt = true;
                else gt = false;

                bll.UpdateHocSinh(txtMaHS.Text, txtTenHS.Text, txtMaLop.Text, dtpNgaySinh.Value, gt, txtDiaChi.Text, Int32.Parse(txtSDT.Text));
                FormHocSinh_Load(sender, e);
                resetValue();
            }
        }
        int Vitri;
        private void dataThongTinHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Vitri = e.RowIndex;
            if (Vitri >= 0)
            {
                txtMaHS.Text = dataThongTinHS.Rows[Vitri].Cells[0].Value.ToString();
                txtTenHS.Text = dataThongTinHS.Rows[Vitri].Cells[1].Value.ToString();
                txtMaLop.Text = dataThongTinHS.Rows[Vitri].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dataThongTinHS.Rows[Vitri].Cells[3].Value.ToString();
                if (dataThongTinHS.Rows[Vitri].Cells[4].Value.Equals(true))
                    rdbNam.Checked = true;
                else rdbNu.Checked = true;
                txtDiaChi.Text = dataThongTinHS.Rows[Vitri].Cells[5].Value.ToString();
                txtSDT.Text = dataThongTinHS.Rows[Vitri].Cells[6].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bll.DeleteHocSinh(txtMaHS.Text);
                FormHocSinh_Load(sender, e);
                resetValue();
            }
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
            if (txtTKHS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã học sinh để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTKHS.Focus();
            }
            else
            {
                string mhs = txtTKHS.Text;
                DataTable dt = new DataTable();
                dt = bll.TimHocSinh(txtTKHS.Text);
                dataThongTinHS.DataSource = dt;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaHS.Enabled = false;
            txtTenHS.Focus();
            txtTenHS.Clear();
            txtMaLop.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = true;
            txtDiaChi.Clear();
            txtSDT.Clear();
        }

    } 
}

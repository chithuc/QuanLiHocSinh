using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLHOCSINH
{
    class BLL
    {
        DAL da = new DAL();
        public DataTable showHocSinh()
        {
            string sql = "select * from HocSinh";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertHocSinh(string mhs, string ths, string ml, DateTime ns,  Boolean gt, string dc, int sdt)
        {
            string sql = "insert into HocSinh values ('" + mhs + "',N'" + ths + "','" + ml + "', " +
                "'" + ns.ToString("yyyy-MM-dd") + "', '" + gt + "',N'" + dc + "','" + sdt + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateHocSinh(string mhs, string ths, string ml, DateTime ns, Boolean gt, string dc, int sdt)
        {
            string sql = "update HocSinh set MaHS='" + mhs + "',TenHS = N'" + ths + "', MaLop = '" + ml + "', " +
                "NgaySinh = '" + ns.ToString("yyyy-MM-dd") + "',GioiTinh = '" + gt + "', " +
                "DiaChi = N'" + dc + "',SDT='" + sdt + "'where MaHS = '" + mhs + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteHocSinh(string mhs)
        {
            string sql = "delete HocSinh where MaHS = '" + mhs + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable TimHocSinh(string mhs)
        {
            string sql = "select * from HocSinh where MaHS ='" + mhs + "'";
            DataTable tblHS = new DataTable();
            tblHS = da.GetTable(sql);
            return tblHS;
        }

        public DataTable showBangDiem()
        {
            string sql = "select * from BangDiem";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertBangDiem(string mbd, string mhs, string mh, float d, string xl)
        {
            string sql = "insert into BangDiem values ('" + mbd + "','" + mhs + "','" + mh + "', '" + d + "',N'" + xl + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateBangDiem(string mbd, string mhs, string mh, float d, string xl)
        {
            string sql = "update BangDiem set MaBD='" + mbd + "',MaHS = '" + mhs + "', MaMH = '" + mh + "', " +
                "Diem = '" + d + "', XepLoai = N'" + xl + "' where MaBD = '" + mbd + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteBangDiem(string mbd)
        {
            string sql = "delete BangDiem where MaBD = '" + mbd + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable TimBangDiem(string mbd)
        {
            string sql = "select * from BangDiem where MaBD ='" + mbd + "'";
            DataTable tblBD = new DataTable();
            tblBD = da.GetTable(sql);
            return tblBD;
        }

        public DataTable showLopHoc()
        {
            string sql = "select * from LopHoc";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertLopHoc(string ml, string tl, int ss, string kh)
        {
            string sql = "insert into LopHoc values ('"+ml+"',N'" + tl + "','" + ss + "', N'" + kh + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateLopHoc(string ml, string tl, int ss, string kh)
        {
            string sql = "update LopHoc set Malop='" + ml + "',TenLop = N'" + tl + "', SiSo = '" + ss + "', " +
                "KhoaHoc = N'" + kh + "' where MaLop = '" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteLopHoc(string ml)
        {
            string sql = "delete LopHoc where MaLop = '" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable TimLopHoc(string ml)
        {
            string sql = "select * from LopHoc where MaLop ='" + ml + "'";
            DataTable tblLop = new DataTable();
            tblLop = da.GetTable(sql);
            return tblLop;
        }

        public DataTable showMonHoc()
        {
            string sql = "select * from MonHoc";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertMonHoc(string mmh, string tmh,string mhs,string hk, int st)
        {
            string sql = "insert into MonHoc values ('" + mmh + "',N'" + tmh + "',N'" + mhs + "', N'" + hk + "', '" + st + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateMonHoc(string mmh, string tmh, string mhs, string hk, int st)
        {
            string sql = "update MonHoc set MaMH='" + mmh + "',TenMH = N'" + tmh + "', MaHS = N'" + mhs + "', " +
                "HocKy = N'" + hk + "',SoTiet = '" + st + "' where MaMH = '" + mmh + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteMonHoc(string mmh)
        {
            string sql = "delete MonHoc where MaMH = '" + mmh + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable TimMonHoc(string mmh)
        {
            string sql = "select * from MonHoc where MaMH ='" + mmh + "'";
            DataTable tblLop = new DataTable();
            tblLop = da.GetTable(sql);
            return tblLop;
        }
    }
}

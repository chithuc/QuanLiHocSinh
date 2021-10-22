using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHOCSINH.DTO
{
    class HocSinh_DTO
    {
        private string MaHS, TenHS, MaLop, DiaChi;
        public string MaHS1
        {
            get { return MaHS; }
            set { MaHS = value; }
        }

        public string TenHS1
        {
            get { return TenHS; }
            set { TenHS = value; }
        }

        public string MaLop1
        {
            get { return MaLop; }
            set { MaLop = value; }
        }

        public string DiaChi1
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }

        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private int sdt;

        public int Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private bool gioiTinh;

        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public HocSinh_DTO()
        {

        }
        public HocSinh_DTO(string MaHS, string TenHS, string MaLop, DateTime NgaySinh, Boolean GioiTinh, string DiaChi, int sdt)
        {
            this.MaHS = MaHS;
            this.TenHS = TenHS;
            this.MaLop = MaLop;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.Sdt = sdt;
        }
    }
}

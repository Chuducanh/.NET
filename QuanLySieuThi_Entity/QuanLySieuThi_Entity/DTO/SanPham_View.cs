using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Entity.DTO
{
    public class SanPham_View
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public System.DateTime NgayNhap { get; set; }
        public string MatHang { get; set; }
        public bool TinhTrang { get; set; }
        public string TenNhaSX { get; set; }
    }
}

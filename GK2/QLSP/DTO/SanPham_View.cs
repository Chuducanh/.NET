using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSP.DTO
{
    public class SanPham_View
    {
        public string MaSP { get; set; }
        public string NameSP { get; set; }
        public float Gia { get; set; }
        public DateTime NgayNhap { get; set; }
        public string NameNCC { get; set; }
        public string NameTinh { get; set; }
    }
}

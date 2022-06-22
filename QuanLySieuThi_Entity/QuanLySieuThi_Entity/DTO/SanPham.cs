using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Entity.DTO
{
    public class SanPham
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string MaSP { get; set; }
        [Required]
        public string TenSP { get; set; }
        [Required]
        [StringLength(10)]
        public string ID_NhaSX { get; set; }
        public System.DateTime NgayNhap { get; set; }
        public string MatHang { get; set; }
        public bool TinhTrang { get; set; }


        [ForeignKey("ID_NhaSX")]
        public virtual NhaSX NhaSX { get; set; }
    }
}

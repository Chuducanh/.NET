using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSP.DTO
{
    public class SanPham
    {
        [Key]
        [StringLength(10)]
        [Required]
        public string MaSP { get; set; }
        public string NameSP { get; set; }
        public float Gia { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        [Required]
        public int MaNCC { get; set; }
        [ForeignKey("MaNCC")]
        public virtual NCC NCC { get; set; }
    }
}

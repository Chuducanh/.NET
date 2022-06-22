using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Entity.DTO
{
    public class NhaSX
    {
        [Key][Required][StringLength(10)]
        public string ID_NhaSX { get; set; }
        [Required]
        public string TenNhaSX { get; set; }

        public NhaSX()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}

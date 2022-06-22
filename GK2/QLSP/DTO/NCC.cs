using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSP.DTO
{
    public class NCC
    {
      
        [Key][Required]
        // TĂNG TỰ ĐỘNG
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // [Column(Order =0)]  
        public int MaNCC { get; set; }
        public string NameNCC { get; set; }
        [StringLength(2)][Required]
        public string MaTinh { get; set; }
        [ForeignKey("MaTinh")]
        public virtual Tinh Tinh { get; set; }
    }
}

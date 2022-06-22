using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSP.DTO
{
    public class Tinh
    {
        public Tinh()
        {
            this.NCCs = new HashSet<NCC>();
        }
        [Key][StringLength(2)][Required]
        public string MaTinh { get; set; }
        public string NameTinh { get; set; }
        public virtual ICollection<NCC> NCCs { get; set; }
    }
}

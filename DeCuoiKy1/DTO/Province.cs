using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCuoiKy1.DTO
{
    public class Province
    {
        [Key][StringLength(2)]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}

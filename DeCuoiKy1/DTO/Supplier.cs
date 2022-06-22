using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCuoiKy1.DTO
{
    public class Supplier
    {
        public Supplier()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string SupplierName { get; set; }
        [StringLength(2)]
        public string ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]
        public virtual Province ProVince { get; set; }
        public virtual ICollection<Product> Products { get; set; }  
    }
}

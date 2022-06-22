using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCuoiKy1.DTO
{
    public class Product
    {
        [Key][StringLength(10)]
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public DateTime DateImport { get; set; }
        public int ProductQuantity { get; set; }
        public int Supplier_ID { get; set; }
        [ForeignKey("Supplier_ID")]

        public virtual Supplier Supplier { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace DeCuoiKy1.DTO
{
    public class CreateDB : CreateDatabaseIfNotExists<ProductEntities>
    {
        protected override void Seed(ProductEntities context)
        {
            context.Provinces.AddRange(new Province[]
            {
                new Province{ ProvinceCode = "1", ProvinceName = "Đà Nẵng"},
                new Province{ ProvinceCode = "2", ProvinceName = "Thừa Thiên Huế"},
                new Province{ ProvinceCode = "3", ProvinceName = "Quảng Nam"}
            });
            context.Suppliers.AddRange(new Supplier[]
            {
                new Supplier{ ID = 1, SupplierName = "FPT", ProvinceCode = "1" },
                new Supplier{ ID = 2, SupplierName = "Huda", ProvinceCode = "2" },
                new Supplier{ ID = 3, SupplierName = "ABC", ProvinceCode = "3" },
            });
            context.Products.AddRange(new Product[]
            {
                new Product{ ProductCode = "FPT001", ProductName = "Iphone", DateImport = new DateTime(2022, 06, 11), Price = 1222222, ProductQuantity = 10, Supplier_ID = 1},
                new Product{ ProductCode = "FPT002", ProductName = "SamSung", DateImport = DateTime.Now, Price = 900000, ProductQuantity = 15, Supplier_ID = 1},
                new Product{ ProductCode = "Huda001", ProductName = "Bia Huda", DateImport = new DateTime(2022, 06, 11), Price = 10000, ProductQuantity = 10, Supplier_ID = 2},
                new Product{ ProductCode = "ABC001", ProductName = "Ao quan", DateImport = new DateTime(2022, 06, 11), Price = 1500000, ProductQuantity = 10, Supplier_ID = 3}
            });
        }
    }
}

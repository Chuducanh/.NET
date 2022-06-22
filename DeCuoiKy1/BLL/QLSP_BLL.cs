using DeCuoiKy1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCuoiKy1.BLL
{
    public class QLSP_BLL
    {
        private static QLSP_BLL _Instance;
        public static QLSP_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLSP_BLL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private QLSP_BLL() { }
        public List<CBBSupplier> GetCBBSupplier()
        {
            List<CBBSupplier> data = new List<CBBSupplier>();
            foreach (Supplier i in ProductEntities.Instance.Suppliers.ToList())
            {
                data.Add(new CBBSupplier { Value = i.ID, Text = i.SupplierName });
            }
            return data;
        }
        public List<CBBProvince> GetCBBProvince()
        {
            List<CBBProvince> data = new List<CBBProvince>();
            foreach (Province i in ProductEntities.Instance.Provinces.ToList())
            {
                data.Add(new CBBProvince { Value = i.ProvinceCode, Text = i.ProvinceName });
            }
            return data;
        }
        public List<Product> GetAllProduct(string ProvinceCode, int Supplier_ID, string txtSearch, string typeSort)
        {
            List<Product> products = (from p in ProductEntities.Instance.Products where 
                                     (p.Supplier.ProvinceCode == ProvinceCode || ProvinceCode == "")
                                     && (p.Supplier_ID == Supplier_ID || Supplier_ID == 0)
                                     && p.ProductName.Contains(txtSearch)
                                     select p).ToList();
            return Sort(products, typeSort);
        }
        public List<Product> Sort(List<Product> data, string typeSort)
        {
            switch (typeSort.ToLower())
            {
                case "giá nhập":
                    return data.OrderBy(p => p.Price).ToList();
                case "ngày nhập hàng":
                    return data.OrderBy(p => p.DateImport).ToList();
            }
            return data;
        }
        public DataTable GetDataTableProduct(List<Product> Products)
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Số thứ tự", DataType = typeof(int)},
                new DataColumn {ColumnName = "Tên sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Mã sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Giá nhập", DataType = typeof(float)},
                new DataColumn {ColumnName = "Ngày nhập hàng", DataType = typeof(DateTime)},
                new DataColumn {ColumnName = "Nhà cung cấp", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tỉnh/Thành phố", DataType = typeof(string)}

            });
            int index = 1;
            foreach (Product p in Products)
            {
                data.Rows.Add(index, p.ProductName, p.ProductCode, p.Price, p.DateImport, p.Supplier.SupplierName, p.Supplier.ProVince.ProvinceName);
                index++;
            }
            return data;
        }
        public List<CBBSupplier> GetCBBSupplierByProvince(string ProvinceCode)
        {
            List<CBBSupplier> data = new List<CBBSupplier>();
            foreach(Supplier supplier in ProductEntities.Instance.Suppliers)
            {
                if (supplier.ProvinceCode == ProvinceCode)
                {
                    data.Add(new CBBSupplier { Value = supplier.ID, Text = supplier.SupplierName });
                }
            }
            return data;
        }
        public void Delete(string ProductCode)
        {
            Product product = ProductEntities.Instance.Products.Find(ProductCode);
            ProductEntities.Instance.Products.Remove(product);
            ProductEntities.Instance.SaveChanges();
        }
        public Product GetProductByProductCode(string ProductCode)
        {
            return ProductEntities.Instance.Products.Find(ProductCode);
        }
        public void ExecuteDB(Product product)
        {
            Product productFind = ProductEntities.Instance.Products.Find(product.ProductCode);
            if (productFind == null)
            {
                ProductEntities.Instance.Products.Add(product);
            }
            else
            {
                productFind.ProductName = product.ProductName;
                productFind.Price = product.Price;
                productFind.DateImport = product.DateImport;
                productFind.Supplier_ID = product.Supplier_ID;
                productFind.Supplier.ProvinceCode = product.Supplier.ProvinceCode;
            }
            ProductEntities.Instance.SaveChanges();
        }
    }
}

using System;
using System.Data.Entity;
using System.Linq;

namespace DeCuoiKy1.DTO
{
    public class ProductEntities : DbContext
    {
        private static ProductEntities _Instance;
        public static ProductEntities Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ProductEntities();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private ProductEntities()
            : base("name=ProductEntities")
        {
            Database.SetInitializer<ProductEntities>(new CreateDB());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
    }
}
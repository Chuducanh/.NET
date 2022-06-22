using QuanLySieuThi_Entity.DTO;
using System;
using System.Data.Entity;
using System.Linq;


namespace QuanLySieuThi_Entity.Entity
{
    public class DALQLST : DbContext
    {
        // Your context has been configured to use a 'DALQLST' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QuanLySieuThi_Entity.DALQLST' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DALQLST' 
        // connection string in the application configuration file.

        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<NhaSX> NhaSXes { get; set; }
        

        public DALQLST()
            : base("name=DALQLST")
        {
            Database.SetInitializer<DALQLST>(new CreateDB());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
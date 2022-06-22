using QLSP.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace QLSP
{
    public class QLSP : DbContext
    {
        // Your context has been configured to use a 'QLSP' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QLSP.QLSP' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLSP' 
        // connection string in the application configuration file.
        public QLSP()
            : base("name=QLSP")
        {
            Database.SetInitializer<QLSP>(new CreateDB());
        }
        public virtual DbSet<SanPham> SanPhams { get; set; }    
        public virtual DbSet<NCC> NCCs { get; set; }
        public virtual DbSet<Tinh> Tinhs { get; set; }    

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
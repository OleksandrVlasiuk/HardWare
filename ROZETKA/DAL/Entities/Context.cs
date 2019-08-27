using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCompressImage.Entities;

namespace ROZETKA.Entities
{
    public class EFContext : DbContext
    {
        public EFContext() : base("ConnectionString") { }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAccess> ProductAccesses { get; set; }
    }
}

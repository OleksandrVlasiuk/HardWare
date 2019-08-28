using DAL.Abstract;
using DAL.Entities;
using ROZETKA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrate
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly EFContext context = new EFContext();
        public IEnumerable<Product> Get()
        {
            return context.Products.ToList();
        }

    }
}

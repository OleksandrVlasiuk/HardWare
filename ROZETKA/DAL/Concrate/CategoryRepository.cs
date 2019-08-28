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
    public class CategoryRepository : IRepository<Categories>
    {
        private readonly EFContext context = new EFContext();
        public IEnumerable<Categories> Get()
        {
            return context.Categories.ToList();
        }

    }
}

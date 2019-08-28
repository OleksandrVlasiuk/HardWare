using BLL.Abstract;
using BLL.Models;
using DAL.Abstract;
using DAL.Entities;
using ROZETKA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrate
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;
        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public IEnumerable<ProductDTO> GetAll()
        {
            return _repository.Get().Select(t => new ProductDTO() { Id = t.Id, Name = t.Name, Price = t.Price, Categories_id = t.Categories_id , Decription=t.Description }).ToList();
        }
    }
}

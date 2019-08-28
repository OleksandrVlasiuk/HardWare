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
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Categories> _repository;
        public CategoryService(IRepository<Categories> repository)
        {
            _repository = repository;
        }
        public IEnumerable<CategoryDTO> GetCategories()
        {
            return _repository.Get().Select(t => new CategoryDTO() { Id = t.Id, Name = t.Name }).ToList();
        }
    }
}

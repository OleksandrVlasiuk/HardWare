using BLL.Abstract;
using BLL.Models;
using DAL.Abstract;
using DAL.Entities;
using ROZETKA.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCompressImage.Entities;

namespace BLL.Concrate
{
    public class ImagesService : IImagesService
    {
        private readonly IRepository<Images> _repository;
        public ImagesService(IRepository<Images> repository)
        {
            _repository = repository;
        }
        public IEnumerable<ImagesDTO> GetImages()
        {
            return _repository.Get().Select(t => new ImagesDTO() { Id = t.Id, ImageF = t.ImageF , ImageS = t.ImageS , ImageT=t.ImageT }).ToList();
        }
    }
}

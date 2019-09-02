using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCompressImage.Entities;

namespace BLL.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Categories_id { get; set; }
        public string Decription { get; set; }
        public ImagesDTO images { get; set; }
    }
}

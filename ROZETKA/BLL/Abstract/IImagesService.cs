using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCompressImage.Entities;

namespace BLL.Abstract
{
    public interface IImagesService
    {
        IEnumerable<ImagesDTO> GetImages();
    }
}

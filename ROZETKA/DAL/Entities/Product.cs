using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCompressImage.Entities;

namespace ROZETKA.Entities
{
    [Table("tbl.Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        [ForeignKey("CategoriesOf")]
        public int Categories_id { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ProductAccess ProductAccessOf { get; set; }
        public virtual ICollection<Images> Images { get; set; }
        public virtual Categories CategoriesOf { get; set; }
    }
}

using ROZETKA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCompressImage.Entities
{
    [Table("tbl.Images")]
    public class Images
    {
        [Key, ForeignKey("ProductOf")]
        public int Id { get; set; }
        [Required]
        public string ImageF { get; set; }
        [Required]
        public string ImageS { get; set; }
        [Required]
        public string ImageT { get; set; }
        [Required]
        public virtual Product ProductOf { get; set; }
    }
}

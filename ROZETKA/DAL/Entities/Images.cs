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
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProductOf")]
        public int ProductId { get; set; }
        [Required]
        public string ImageF { get; set; }

        public string ImageS { get; set; }

        public string ImageT { get; set; }

        public virtual Product ProductOf { get; set; }
    }
}

using ROZETKA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("tbl.ProductAccesses")]
    public class ProductAccess
    {
        [Key, ForeignKey("ProductOf")]
        public int Id { get; set; }
        [Required]
        public DateTime DateOfLock { get; set; }
        public virtual Product ProductOf { get; set; }
    }
}

using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class ProductCategory:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required(ErrorMessage = "Please provide the Product")]
        [Index("IX_ProductAndCategory", 1)]
        public virtual Product Product { get; set; }
        [Required(ErrorMessage = "Please provide the Category")]
        [Index("IX_ProductAndCategory", 2)]
        public virtual Category Category { get; set; }
    }
}

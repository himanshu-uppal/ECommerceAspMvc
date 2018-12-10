using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class ProductImage:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required(ErrorMessage = "Please provide the Product")]
        public virtual Product Product { get; set; }
        [Required(ErrorMessage = "Please provide the Image Path")]
        public string ImagePath { get; set; }
    }
}

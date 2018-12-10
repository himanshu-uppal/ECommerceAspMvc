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
    public class Category:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required(ErrorMessage = "Please provide the Category name")]
        [Index(IsUnique=true)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive count")]
        public int ProductCountSold { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public Category()
        {
            this.ProductCategories = new HashSet<ProductCategory>();
        }
    }
}

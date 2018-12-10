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
    public class Value:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required(ErrorMessage = "Please provide the value")]
        [Index(IsUnique=true)]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}

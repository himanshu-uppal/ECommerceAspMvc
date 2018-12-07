using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Shared.DTOs
{
    public class OrderDto
    {
        public IEnumerable<OrderProductVariantDto> OrderProductVariants { get; set; }
        public UserDto User { get; set; }
    }
}

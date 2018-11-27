using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Abstract
{
    public interface IEntity
    {
        Guid Key { get; set; }
    }
}

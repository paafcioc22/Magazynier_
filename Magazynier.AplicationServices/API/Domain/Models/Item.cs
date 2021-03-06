using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
    }
}

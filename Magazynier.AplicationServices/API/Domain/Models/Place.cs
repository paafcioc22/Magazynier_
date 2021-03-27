using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain.Models
{
    public class Place
    {
        public string PlaceName { get; set; }
        public string PlaceOpis { get; set; }
        public List<Item> Items { get; set; }
    }
}

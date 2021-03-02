using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.Entities
{
    public class Place :EntityBase
    {
        public List<Item> Items { get; set; }


        [Required]
        [MaxLength(5)]
        public string PlaceName { get; set; }

        [MaxLength(5)]
        public string PlaceOpis { get; set; }
        public int PlaceTwrNumer { get; set; }
        public int PlaceTrnNumer { get; set; }
        public int PlaceMagZrd { get; set; }
        public int PlaceQuantity { get; set; }
        public DateTime PlaceTime { get; set; }

    }
}

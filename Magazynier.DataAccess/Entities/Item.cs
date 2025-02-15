﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.DataAccess.Entities
{
    public class Item : EntityBase
    {


        public int? DocumentId { get; set; }
        public Document Document { get; set; }


        public int? RaportId { get; set; }
        public Raport Raport { get; set; }

        public List<Place> Places { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(7)]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int QuantityScan{ get; set; }

    }
}

using Magazynier.AplicationServices.API.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain.Add
{
    public class AddItemRequest : IRequest<AddItemResponse>
    {
        public int DocId { get; set; }

        public Item Item { get; set; }
        //public string Name { get; set; }   
        //public decimal Price { get; set; }
        //public int Quantity { get; set; }
        //public int QuantityScan { get; set; }

    }
}

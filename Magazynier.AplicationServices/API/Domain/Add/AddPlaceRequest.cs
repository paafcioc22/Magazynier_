using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain.Add
{
    public class AddPlaceRequest : IRequest<AddPlaceResponse>
    {
        public string PlaceName { get; set; }  
        public string PlaceOpis { get; set; }
        public int PlaceTwrNumer { get; set; }
        public int PlaceTrnNumer { get; set; }
        public int PlaceMagZrd { get; set; }
        public DateTime PlaceTime { get; set; }
    }
}

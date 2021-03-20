using AutoMapper;
using Magazynier.AplicationServices.API.Domain.Add;
using Magazynier.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Mappings
{
    public class PlacesProfile : Profile
    {
        public PlacesProfile()
        {
            this.CreateMap<DataAccess.Entities.Place, Domain.Models.Place>()
        .ForMember(x => x.PlaceName, y => y.MapFrom(z => z.PlaceName))
        .ForMember(x => x.PlaceOpis, y => y.MapFrom(z => z.PlaceOpis));

        this.CreateMap<AddPlaceRequest, Place>()
          .ForMember(x => x.PlaceName, y => y.MapFrom(z => z.PlaceName))
          .ForMember(x => x.PlaceMagZrd, y => y.MapFrom(z => z.PlaceMagZrd))
          .ForMember(x => x.PlaceTrnNumer, y => y.MapFrom(z => z.PlaceTrnNumer))
          .ForMember(x => x.PlaceTwrNumer, y => y.MapFrom(z => z.PlaceTwrNumer))
          .ForMember(x => x.PlaceTime, y => y.MapFrom(z => z.PlaceTime))
          .ForMember(x => x.PlaceOpis, y => y.MapFrom(z => z.PlaceOpis));


        }
    }
}

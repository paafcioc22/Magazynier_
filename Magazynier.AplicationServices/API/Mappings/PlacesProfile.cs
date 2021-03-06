using AutoMapper;
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
        .ForMember(x => x.PlaceName, y => y.MapFrom(z => z.PlaceName));
        
        }
    }
}

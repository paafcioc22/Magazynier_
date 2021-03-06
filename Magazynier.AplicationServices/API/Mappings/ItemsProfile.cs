using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Mappings
{
    public class ItemsProfile : Profile
    {
        public ItemsProfile()
        {
            this.CreateMap<DataAccess.Entities.Item, Domain.Models.Item>()
        .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
        .ForMember(x => x.Price, y => y.MapFrom(z => z.Price))
        .ForMember(x => x.Quantity, y => y.MapFrom(z => z.Quantity));
        }
    }
}

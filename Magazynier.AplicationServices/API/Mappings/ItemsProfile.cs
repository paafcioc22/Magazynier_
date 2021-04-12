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
    public class ItemsProfile : Profile
    {
        public ItemsProfile()
        {
            
            this.CreateMap<DataAccess.Entities.Item, Domain.Models.Item>()
            .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
            .ForMember(x => x.Price, y => y.MapFrom(z => z.Price))
            .ForMember(x => x.QuantityScan, y => y.MapFrom(z => z.QuantityScan))
            .ForMember(x => x.Quantity, y => y.MapFrom(z => z.Quantity));

            this.CreateMap<AddItemRequest, Item>()
            .ForMember(x => x.Name, y => y.MapFrom(z => z.Item.Name))
            .ForMember(x => x.Price, y => y.MapFrom(z => z.Item.Price))
            .ForMember(x => x.Quantity, y => y.MapFrom(z => z.Item.Quantity))
            .ForMember(x => x.DocumentId, y => y.MapFrom(z => z.DocId))
            .ForMember(x => x.QuantityScan, y => y.MapFrom(z => z.Item.QuantityScan)); 

        }
    }
}

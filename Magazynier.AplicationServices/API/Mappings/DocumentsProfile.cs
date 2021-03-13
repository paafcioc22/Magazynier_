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
    public class DocumentsProfile:Profile
    {
        public DocumentsProfile()
        {
            this.CreateMap<DataAccess.Entities.Document, Domain.Models.Document>()
                .ForMember(x => x.Trn_NrDokumentu, y => y.MapFrom(z => z.Trn_NrDokumentu))
                .ForMember(x => x.Fmm_NrListu, y => y.MapFrom(z => z.Fmm_NrListu));


            this.CreateMap<AddDocRequest, Document>()
               .ForMember(x => x.Trn_NrDokumentu, y => y.MapFrom(z => z.Trn_NrDokumentu))
               .ForMember(x => x.Fmm_NrListu, y => y.MapFrom(z => z.Fmm_NrListu))
               .ForMember(x => x.Trn_GidNumer, y => y.MapFrom(z => z.Trn_GidNumer))
               .ForMember(x => x.DclMagKod, y => y.MapFrom(z => z.DclMagKod))
               .ForMember(x => x.Trn_Stan, y => y.MapFrom(z => z.Trn_Stan))
               .ForMember(x => x.Trn_DataSkan, y => y.MapFrom(z => z.Trn_DataSkan));
        }
    }
}

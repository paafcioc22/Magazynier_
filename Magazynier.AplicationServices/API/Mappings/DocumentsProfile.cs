using AutoMapper;
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
        }
    }
}

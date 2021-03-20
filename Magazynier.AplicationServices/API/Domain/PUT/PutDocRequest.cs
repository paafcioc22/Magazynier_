using Magazynier.AplicationServices.API.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Document = Magazynier.DataAccess.Entities.Document;
namespace Magazynier.AplicationServices.API.Domain.PUT
{
    public class PutDocRequest : IRequest<PutDocResponse>
    {
        public int DocId { get; set; }
        public Document Document { get; set; }

        //public string Trn_NrDokumentu { get; set; }
        //public string Fmm_NrListu { get; set; }
        //public int Trn_GidNumer { get; set; }

    }
}

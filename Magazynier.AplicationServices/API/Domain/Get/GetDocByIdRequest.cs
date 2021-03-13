using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain.Get
{
    public partial class GetDocByIdRequest : IRequest<GetDocByIdResponse>
    {
        public int DocId { get; set; }
    }
}

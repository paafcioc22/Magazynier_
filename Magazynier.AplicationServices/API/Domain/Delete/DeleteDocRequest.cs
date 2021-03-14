using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain.Delete
{
    
    public class DeleteDocRequest : IRequest<DeleteDocResponse>
    {
        public int DocId { get; set; }
    }
}

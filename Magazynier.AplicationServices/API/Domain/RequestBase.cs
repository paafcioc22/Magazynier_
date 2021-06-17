using Magazynier.AplicationServices.API.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain
{
    public class RequestBase: IRequest<GetDocsResponse>
    {
        [Flags]
        enum Role
        {
            Admin,
            User
        }


        public string AuthenticationName { get; set; }
        public string AuthenticationRole { get; set; }
    }
}

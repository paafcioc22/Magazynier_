using AutoMapper;
using Magazynier.AplicationServices.API.Domain.Get;
using Magazynier.AplicationServices.ErrorHandling;
using Magazynier.DataAccess;
using Magazynier.DataAccess.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Handlers.Get
{
    public class GetUsersHandler : IRequestHandler<GetUsersRequest, GetUsersResponse>
    {
        readonly IMapper mapper;
        readonly IQueryExecutor queryExecutor;
        public GetUsersHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }

        public async Task<GetUsersResponse> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUsersQuery()
            {
                // Username= 
            };

            var users = await this.queryExecutor.Execute(query);


            if (users == null)
            {
                return new GetUsersResponse()
                {
                    Error = new Domain.ErrorModel(ErrorType.NotFound)
                };
            }


            var mappedUsers = this.mapper.Map<List<Domain.Models.User>>(users);


            var response = new GetUsersResponse()
            {
                Data = mappedUsers
            };

            return response;
        }


        
    }
}

using AutoMapper;
using Magazynier.AplicationServices.API.Domain.Get;
using Magazynier.AplicationServices.ErrorHandling;
using Magazynier.DataAccess;
using Magazynier.DataAccess.CQRS.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Handlers.Get
{
    public class GetItemByDocIdHandler : IRequestHandler<GetItemByDocIdRequest, GetItemByDocIdResponse>
    {
        readonly IMapper mapper;
        readonly IQueryExecutor queryExecutor;
        public GetItemByDocIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }

        public async Task<GetItemByDocIdResponse> Handle(GetItemByDocIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetItemByDocIdQuery()
            {
                Id = request.DocId
            };

            var items = await this.queryExecutor.Execute(query);


            if (items == null)
            {
                return new GetItemByDocIdResponse()
                {
                    Error = new Domain.ErrorModel(ErrorType.NotFound)
                };
            }


            var mappedDocs = this.mapper.Map<List<Domain.Models.Item>>(items);

            var response = new GetItemByDocIdResponse()
            {
                Data = mappedDocs
            };

            return response;
        }
    }
}

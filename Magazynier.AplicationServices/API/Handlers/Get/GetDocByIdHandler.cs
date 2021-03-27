using AutoMapper;
using Magazynier.AplicationServices.API.Domain;
using Magazynier.AplicationServices.API.Domain.Get;
using Magazynier.AplicationServices.ErrorHandling;
using Magazynier.DataAccess;
using Magazynier.DataAccess.CQRS.Queries;
using Magazynier.DataAccess.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Handlers.Get
{
    public class GetDocByIdHandler : IRequestHandler<GetDocByIdRequest, GetDocByIdResponse>
    {
        readonly IMapper mapper;
        readonly IQueryExecutor queryExecutor;
        public GetDocByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }


        public async Task<GetDocByIdResponse> Handle(GetDocByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetDocumentQuery()
            {
                Id=request.DocId
            };

            var docs = await this.queryExecutor.Execute(query);

            if (docs == null)
            {
                return new GetDocByIdResponse()
                {
                    Error = new Domain.ErrorModel(ErrorType.NotFound)
                };
            }


            var mappedDocs = this.mapper.Map<Domain.Models.Document>(docs);

            var response = new GetDocByIdResponse()
            {
                Data = mappedDocs
            };

            return response;
        }
    }
}

using AutoMapper;
using Magazynier.AplicationServices.API.Domain.Models;
using Magazynier.AplicationServices.API.Domain.PUT;
using Magazynier.DataAccess;
using Magazynier.DataAccess.Entities;
using Magazynier.DataAccess.CQRS;
using Magazynier.DataAccess.CQRS.Commands;
using Magazynier.DataAccess.CQRS.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Document = Magazynier.DataAccess.Entities.Document;

namespace Magazynier.AplicationServices.API.Handlers.PUT
{
    public class PutDocumentByIdHandler : IRequestHandler<PutDocRequest, PutDocResponse>
    {
        readonly ICommandExecutor commandExecutor;
        readonly IMapper mapper;
        readonly IQueryExecutor queryExecutor;

        public PutDocumentByIdHandler(
            IMapper mapper, 
            ICommandExecutor commandExecutor, 
            IQueryExecutor queryExecutor 
            )
        {
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<PutDocResponse> Handle(PutDocRequest request, CancellationToken cancellationToken)
        {

            var query = new GetDocumentQuery()
            {
                Id = request.DocId
            };

            var docs = await this.queryExecutor.Execute(query);

            var mappedDocs = this.mapper.Map<PutDocRequest, Document>(request,docs);

            var command = new PutDocumentCommand() 
            { 
                Parametr = mappedDocs 
            };

            var FromDb = await this.commandExecutor.Execute(command);

            return new PutDocResponse()
            {
                Data = this.mapper.Map<Domain.Models.Document>(FromDb)                
            };

             
        }
    }
}

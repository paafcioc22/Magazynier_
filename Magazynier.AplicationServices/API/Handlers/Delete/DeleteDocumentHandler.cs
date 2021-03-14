using AutoMapper;
using Magazynier.AplicationServices.API.Domain.Delete;
using Magazynier.DataAccess.CQRS;
using Magazynier.DataAccess.CQRS.Commands;
using Magazynier.DataAccess.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Handlers.Delete
{
    public class DeleteDocumentHandler : IRequestHandler<DeleteDocRequest, DeleteDocResponse>
    {
        readonly IMapper mapper;
        readonly ICommandExecutor commandExecutor;
        public DeleteDocumentHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeleteDocResponse> Handle(DeleteDocRequest request, CancellationToken cancellationToken)
        {
            
           // var doc = this.mapper.Map<Document>(request);

            var command = new DeleteDocumentCommand()
            {
                Id= request.DocId 
            };

            var fromDb = await this.commandExecutor.Execute(command);

            var response = new DeleteDocResponse()
            {
                Data = this.mapper.Map<Domain.Models.Document>(fromDb)
            };

            return response;
        }
    }
}

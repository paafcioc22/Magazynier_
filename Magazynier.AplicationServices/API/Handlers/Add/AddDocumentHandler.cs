using AutoMapper;
using Magazynier.AplicationServices.API.Domain.Add;
 
using Magazynier.DataAccess;
using Magazynier.DataAccess.CQRS;
using Magazynier.DataAccess.CQRS.Commands;
using Magazynier.DataAccess.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Handlers.Add
{
    public class AddDocumentHandler : IRequestHandler<AddDocRequest, AddDocResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public AddDocumentHandler (IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddDocResponse> Handle(AddDocRequest request, CancellationToken cancellationToken)
        {
            var doc = this.mapper.Map<Document>(request);

            var command = new AddDocumentCommand()
            {
                Parametr = doc
            };

            var docFromDb =await this.commandExecutor.Execute(command);

            return new AddDocResponse()
            {
                Data = this.mapper.Map<Domain.Models.Document>(docFromDb)
            };

        }
    }
}

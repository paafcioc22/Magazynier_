using AutoMapper;
using Magazynier.AplicationServices.API.Domain.Add;
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

namespace Magazynier.AplicationServices.API.Handlers.Add
{
    public class AddItemHandler : IRequestHandler<AddItemRequest, AddItemResponse>
    {
        readonly IMapper mapper;
        readonly ICommandExecutor commandExecutor;
        public AddItemHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddItemResponse> Handle(AddItemRequest request, CancellationToken cancellationToken)
        {
            var item = this.mapper.Map<Item>(request);

            var command = new AddItemCommand()
            {
                Parametr = item
            };

            var docFromDb = await this.commandExecutor.Execute(command);

            return new AddItemResponse()
            {
                Data = this.mapper.Map<Domain.Models.Item>(docFromDb)
            };
        }
    }
}

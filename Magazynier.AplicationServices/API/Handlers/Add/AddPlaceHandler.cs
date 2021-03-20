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
    public class AddPlaceHandler : IRequestHandler<AddPlaceRequest, AddPlaceResponse>
    {
        readonly IMapper mapper;
        readonly ICommandExecutor commandExecutor;
        public AddPlaceHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddPlaceResponse> Handle(AddPlaceRequest request, CancellationToken cancellationToken)
        {
            var place = this.mapper.Map<Place>(request);

            var command = new AddPlaceCommand()
            {
                Parametr = place
            };

            var docFromDb = await this.commandExecutor.Execute(command);

            return new AddPlaceResponse()
            {
                Data = this.mapper.Map<Domain.Models.Place>(docFromDb)
            };

        }
    }
}

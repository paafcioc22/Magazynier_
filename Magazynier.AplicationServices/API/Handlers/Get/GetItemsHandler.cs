using AutoMapper;
using Magazynier.AplicationServices.API.Domain.Models;
using Magazynier.AplicationServices.ErrorHandling;
using Magazynier.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Handlers
{
    public class GetItemsHandler : IRequestHandler<GetItemsRequest, GetItemsResponse>
    {
        private readonly IRepository<DataAccess.Entities.Item> itemRepository;
        private readonly IMapper mapper;

        public GetItemsHandler(IRepository<DataAccess.Entities.Item>itemRepository, IMapper mapper)
        {
            this.itemRepository = itemRepository;
            this.mapper = mapper;
        }

        public async  Task<GetItemsResponse> Handle(GetItemsRequest request, CancellationToken cancellationToken)
        {
            var items = await this.itemRepository.GetAll();



            if (items == null)
            {
                return new GetItemsResponse()
                {
                    Error = new Domain.ErrorModel(ErrorType.NotFound)
                };
            }


            var mappedItems = this.mapper.Map<List<Domain.Models.Item>>(items);            


            var response = new GetItemsResponse()
            {
                Data = mappedItems
            };


            return response;
        }
    }
}

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
    public class GetPlaceByIdHandler : IRequestHandler<GetPlaceByIdRequest, GetPlaceByIdResponse>
    {
        readonly IMapper mapper;
        readonly IQueryExecutor queryExectuor;
        public GetPlaceByIdHandler(IMapper mapper, IQueryExecutor queryExectuor)
        {
            this.queryExectuor = queryExectuor;
            this.mapper = mapper;
        }
        public async Task<GetPlaceByIdResponse> Handle(GetPlaceByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetPlaceQuery()
            {
                 Id= request.PlaceId
            };

            var places = await this.queryExectuor.Execute(query);


            if (places == null)
            {
                return new GetPlaceByIdResponse()
                {
                    Error = new Domain.ErrorModel(ErrorType.NotFound)
                };
            }

            var mappedPlaces = this.mapper.Map<Domain.Models.Place>(places);

            var response = new GetPlaceByIdResponse()
            {
                Data = mappedPlaces
            };

            return response;
        }
    }
}

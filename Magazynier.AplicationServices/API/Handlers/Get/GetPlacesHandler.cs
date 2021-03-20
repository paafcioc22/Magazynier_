using AutoMapper;
using Magazynier.AplicationServices.API.Domain;
using Magazynier.AplicationServices.API.Domain.Models;
using Magazynier.DataAccess;
using Magazynier.DataAccess.CQRS.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Handlers
{
    public class GetPlacesHandler : IRequestHandler<GetPlacesRequest, GetPlacesResponse>
    {
        
        private readonly IMapper mapper;
        readonly IQueryExecutor queryExecutor;

        public GetPlacesHandler(IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.queryExecutor = queryExecutor; 
            this.mapper = mapper;
        }
        public async Task<GetPlacesResponse> Handle(GetPlacesRequest request, CancellationToken cancellationToken)
        {

            var query = new GetPlacesQuery()
            {
                PlaceName= request.PlaceName
            };

            var places = await this.queryExecutor.Execute(query);

            var mappedPlaces= this.mapper.Map<List<Domain.Models.Place>>(places); 

            var response = new GetPlacesResponse()
            {
                Data = mappedPlaces
            };

            return response;
        }
    }
}

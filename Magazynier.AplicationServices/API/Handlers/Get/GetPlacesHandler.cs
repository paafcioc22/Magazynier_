using AutoMapper;
using Magazynier.AplicationServices.API.Domain;
using Magazynier.AplicationServices.API.Domain.Models;
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
    public class GetPlacesHandler : IRequestHandler<GetPlacesRequest, GetPlacesResponse>
    {
        private readonly IRepository<DataAccess.Entities.Place> placeRepository;
        private readonly IMapper mapper;

        public GetPlacesHandler(IRepository<DataAccess.Entities.Place> placeRepository, IMapper mapper)
        {
            this.placeRepository = placeRepository;
            this.mapper = mapper;
        }
        public async Task<GetPlacesResponse> Handle(GetPlacesRequest request, CancellationToken cancellationToken)
        {
            var places = await placeRepository.GetAll();

            var mappedPlaces= this.mapper.Map<List<Domain.Models.Place>>(places); 

            var response = new GetPlacesResponse()
            {
                Data = mappedPlaces
            };

            return response;
        }
    }
}

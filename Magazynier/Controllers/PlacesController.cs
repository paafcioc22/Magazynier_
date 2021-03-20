using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Magazynier.AplicationServices.API.Domain;
using Magazynier.AplicationServices.API.Domain.Get;
using Magazynier.AplicationServices.API.Domain.Add;

namespace Magazynier.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlacesController :ApiControllerBase
    {
        
        public PlacesController(IMediator mediator) :base(mediator)
        {
            
        }


        [HttpGet]
        // [Route("{docId}")]
        public Task<IActionResult> GetAllPlaces([FromQuery] GetPlacesRequest placesRequest)
        {

            return this.HandleRequest<GetPlacesRequest, GetPlacesResponse>(placesRequest);            
            
            //var response = await this.mediator.Send(placesRequest);

            //if (response.Data.Count != 0)
            //    return this.Ok(response);
            //else return this.NotFound(response);
        }


        [HttpGet]
        [Route("{placeId}")]
        public   Task<IActionResult> GetPlaceById([FromRoute] int placeId)
        {

            var request = new GetPlaceByIdRequest()
            {
                PlaceId = placeId
            };

            return this.HandleRequest<GetPlaceByIdRequest, GetPlaceByIdResponse>(request);

      
        }

        [HttpPost]
        public Task<IActionResult> AddPlace([FromBody] AddPlaceRequest placeRequest)
        {
             
            //if (!this.ModelState.IsValid)
            //{
            //    return this.BadRequest("BAD_REQUEST");
            //}

            return this.HandleRequest<AddPlaceRequest, AddPlaceResponse>(placeRequest);


            //var response = await this.mediator.Send(placeRequest);
            //return this.Ok(response);
        }

    }
}

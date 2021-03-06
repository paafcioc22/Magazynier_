using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Magazynier.AplicationServices.API.Domain;

namespace Magazynier.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlacesController :ControllerBase
    {
        private readonly IMediator mediator;

        public PlacesController(IMediator mediator)
        {
            this.mediator = mediator;
        }



        [HttpGet]
        // [Route("{docId}")]
        public async Task<IActionResult> GetAllPlaces([FromQuery] GetPlacesRequest placesRequest)
        {
            var response = await this.mediator.Send(placesRequest);
            return this.Ok(response);
        }
    }
}

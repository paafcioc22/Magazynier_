using Magazynier.AplicationServices.API.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Magazynier.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ItemsController :ControllerBase
    {
      
        private readonly IMediator mediator;

        public ItemsController(IMediator mediator)
        {
         
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllItems([FromQuery] GetItemsRequest itemRequest)
        {
            var response = await this.mediator.Send(itemRequest);
            return this.Ok(response);
        }






    }
}

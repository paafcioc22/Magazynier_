using Magazynier.AplicationServices.API.Domain.Get;
using Magazynier.AplicationServices.API.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Magazynier.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ApiControllerBase
    {
      
        private readonly IMediator mediator;

        public ItemsController(IMediator mediator, ILogger<ItemsController> logger) : base(mediator)
        {

            logger.LogInformation("We are in Items");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllItems([FromQuery] GetItemsRequest itemRequest)
        {
            var response = await this.mediator.Send(itemRequest);
            return this.Ok(response);
        }


        [HttpGet]
        [Route("{docId}")]
        public  Task<IActionResult> GetItemsByDocId([FromRoute] int docId)
        {

            var request = new GetItemByDocIdRequest()
            {
                DocId = docId
            };

          
            return this.HandleRequest<GetItemByDocIdRequest, GetItemByDocIdResponse>(request);

        }





    }
}

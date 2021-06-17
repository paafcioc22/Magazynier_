using Magazynier.AplicationServices.API.Domain.Add;
using Magazynier.AplicationServices.API.Domain.Get;
using Magazynier.AplicationServices.API.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Magazynier.Controllers
{
    [Authorize]
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
        public   Task<IActionResult> GetAllItems([FromQuery] GetItemsRequest itemRequest)
        {
            //var response = await this.mediator.Send(itemRequest);
            //return this.Ok(response);

            return this.HandleRequest<GetItemsRequest, GetItemsResponse>(itemRequest);
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

        [HttpPost]
        [Route("{docId}")]
        public Task<IActionResult> AddItemsByDocId(int docId, [FromBody] Item item)
        {

            var request = new AddItemRequest()
            {
                DocId = docId,
                Item = item
            };

            return this.HandleRequest<AddItemRequest, AddItemResponse>(request);

        }



    }
}

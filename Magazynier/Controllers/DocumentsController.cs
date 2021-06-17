using Magazynier.AplicationServices.API.Domain;
using Magazynier.AplicationServices.API.Domain.Add;
using Magazynier.AplicationServices.API.Domain.Get;
using Magazynier.AplicationServices.API.Domain.PUT;
using Magazynier.AplicationServices.API.Domain.Models;
//using Magazynier.DataAccess.Entities; 
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magazynier.AplicationServices.API.Domain.Delete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
//using Document = Magazynier.DataAccess.Entities.Document;

namespace Magazynier.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DocumentsController : ApiControllerBase
    { 

         
        private readonly IMediator mediator;

        public DocumentsController(IMediator mediator, ILogger<DocumentsController> logger) : base(mediator)
        {

            logger.LogInformation("We are in DOcs");
        }


        [HttpGet]
        // [Route("{docId}")]
        public Task<IActionResult> GetAllDocs([FromQuery] GetDocsRequest docsRequest)
        {
            //var response = await this.mediator.Send(docsRequest);
            //return this.Ok(response);


            //User user = new User()
            //{
            //    UserName = this.User.FindFirstValue(ClaimTypes.Name),
                
            //};
            //docsRequest.User = user;

            return this.HandleRequest<GetDocsRequest, GetDocsResponse>(docsRequest);
        }


        [HttpGet]
        [Route("{docId}")]
        public async Task<IActionResult> GetDocsById([FromRoute] int docId)
        {

            var request = new GetDocByIdRequest()
            {
                DocId=docId
            };


            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> AddDoc([FromBody] AddDocRequest docRequest)
        {
            var response = await this.mediator.Send(docRequest);
            return this.Ok(response);
        }


        [HttpPut]
        [Route("{docId}")]
        public async Task<IActionResult> UpdateDocById(int docId,[FromBody] Document document)
        {

            var docRequest = new PutDocRequest()
            {
                DocId = docId,
                Document = document                
            };


            var response = await this.mediator.Send(docRequest);
            return this.Ok(response);
        }


        [HttpDelete]
        [Route("{docId}")]
        public async Task<IActionResult> DeleteDocById([FromRoute] int docId)
        {

            var docRequest = new DeleteDocRequest()
            {
                DocId = docId                
            };


            var response = await this.mediator.Send(docRequest);
            return this.Ok(response);
        }


    }
}

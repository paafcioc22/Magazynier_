using Magazynier.AplicationServices.API.Domain;
using Magazynier.AplicationServices.API.Domain.Add;
using Magazynier.AplicationServices.API.Domain.Get;
using Magazynier.DataAccess;
using Magazynier.DataAccess.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazynier.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DocumentsController : ControllerBase 
    { 

         
        private readonly IMediator mediator;

        public DocumentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

       

        [HttpGet]
       // [Route("{docId}")]
        public async Task<IActionResult> GetAllDocs([FromQuery] GetDocsRequest docsRequest)
        {
            var response = await this.mediator.Send(docsRequest);
            return this.Ok(response);
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
        public async Task<IActionResult> PutDoc([FromBody] AddDocRequest docRequest)
        {
            var response = await this.mediator.Send(docRequest);
            return this.Ok(response);
        }

    }
}

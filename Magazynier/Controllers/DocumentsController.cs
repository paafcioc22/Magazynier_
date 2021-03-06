using Magazynier.AplicationServices.API.Domain;
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
        
    }
}

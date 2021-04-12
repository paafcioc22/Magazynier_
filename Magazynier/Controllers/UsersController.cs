using Magazynier.AplicationServices.API.Domain.Add;
using Magazynier.AplicationServices.API.Domain.Get;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazynier.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ApiControllerBase
    {
        public UsersController(IMediator mediator) : base(mediator)
        {

        }


        [HttpGet]        
        [Route("")]
        public   Task<IActionResult> GetAllUser([FromQuery] GetUsersRequest request)
        {
            return this.HandleRequest<GetUsersRequest, GetUsersResponse>(request);
            //var response = await this.mediator.Send(request);
            //return this.Ok(response);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("")]
        public Task<IActionResult> CreateUser([FromBody] AddUserRequest request)
        {
              
            return this.HandleRequest<AddUserRequest, AddUserResponse>(request);
 
        }

    }
}

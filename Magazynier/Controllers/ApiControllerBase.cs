using Magazynier.AplicationServices.API.Domain;
using Magazynier.AplicationServices.ErrorHandling;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Magazynier.Controllers
{
    abstract public class ApiControllerBase : ControllerBase
    {
        protected IMediator mediator;
        public ApiControllerBase(IMediator mediator)
        {
            this.mediator = mediator;
        }

        protected async Task<IActionResult> HandleRequest<TRequest,TResponse>(TRequest request)
            where TRequest : IRequest<TResponse>
            where TResponse : ErrorResponseBase
        {

            if (!this.ModelState.IsValid)
            {               
                return this.BadRequest(
                        this.ModelState
                        .Where(x => x.Value.Errors.Any())
                        .Select(x=> new {property=x.Key, errors=x.Value.Errors })
                    );                              
            }



            if (User.Claims.FirstOrDefault() != null)
            {
                (request as RequestBase).AuthenticationName= this.User.FindFirstValue(ClaimTypes.Name);
                (request as RequestBase).AuthenticationRole= this.User.FindFirstValue(ClaimTypes.Name);

            }
                //var userName = this.User.FindFirstValue(ClaimTypes.Name);

            



            var response = await this.mediator.Send(request);

            if (response.Error != null)
            {
                return this.ErrorResponse(response.Error);
            }
            return this.Ok(response);
        }

        IActionResult ErrorResponse(ErrorModel error)
        {
            var httpCode = GetHttpStatusCode(error.Error);
            return StatusCode((int)httpCode, error);
        }

        private static HttpStatusCode GetHttpStatusCode(string errorType)
        {
            switch(errorType)
            {
                case ErrorType.NotFound:
                    return HttpStatusCode.NotFound;
                case ErrorType.InternalServerError:
                    return HttpStatusCode.InternalServerError;
                case ErrorType.Unauthorize:
                    return HttpStatusCode.Unauthorized;
                case ErrorType.RequestTooLarge:
                    return HttpStatusCode.RequestEntityTooLarge;
                case ErrorType.UnsupportedMediaType:
                    return HttpStatusCode.UnsupportedMediaType;
                case ErrorType.UnsupportedMethod:
                    return HttpStatusCode.MethodNotAllowed;
                case ErrorType.TooManyRequest:
                    return HttpStatusCode.TooManyRequests;
                  
                default:
                    return HttpStatusCode.BadRequest;
            }
        }
    }
}

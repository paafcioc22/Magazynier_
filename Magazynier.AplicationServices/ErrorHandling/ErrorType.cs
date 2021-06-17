using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.ErrorHandling
{
    public static class ErrorType
    {
        public const string InternalServerError = "INTERNAL_SERVER_ERROR";
        public const string ValidationError = "VALIDATION_ERROR";
        public const string NotAuthenticated = "NOT_AUTHENTICATED";
        public const string Unauthorize = "UNAUTHORIZE";
        public const string NotFound = "NOT_FOUND";
        public const string UnsupportedMediaType = "UNSUPPORTED_MEDIATYPE";
        public const string UnsupportedMethod = "UNSUPPORTED_METHOD";
        public const string RequestTooLarge = "REQUEST_TOO_LARGE";
        public const string TooManyRequest = "TOO_MANY_REQUEST";
        public const string UserExists = "UserExists";
    }
}

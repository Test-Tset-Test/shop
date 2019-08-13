using System;
using System.Net;

namespace Shop.Helpers
{
    public class ApiException : Exception
    {
        private readonly HttpStatusCode _statusCode;

        public ApiException (HttpStatusCode statusCode, string message, Exception ex)
            : base(message, ex)
        {
            this._statusCode = statusCode;
        }

        public ApiException (HttpStatusCode statusCode, string message)
            : base(message)
        {
            this._statusCode = statusCode;
        }

        public ApiException (HttpStatusCode statusCode)
        {
            this._statusCode = statusCode;
        }

        public HttpStatusCode StatusCode
        {
            get { return this._statusCode; }
        }
    }
}
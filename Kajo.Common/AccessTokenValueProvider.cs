using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host.Bindings;

namespace Kajo.Common
{
    public class AccessTokenValueProvider : IValueProvider
    {
        private HttpRequest _request;

        public AccessTokenValueProvider(HttpRequest request)
        {
            _request = request;
        }

        public Task<object> GetValueAsync()
        {
            // Get the token from the header
            var result = Security.VerifyJwtToken(_request, out var princ, out _);
            return Task.FromResult((object)princ);
        }

        public Type Type => typeof(ClaimsPrincipal);

        public string ToInvokeString() => string.Empty;
    }
}
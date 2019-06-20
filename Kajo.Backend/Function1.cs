using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Kajo.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Kajo.Backend
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log, [AccessToken] ClaimsPrincipal claimsPrincipal)
        {
            if (req.VerifyJwtToken(out var principal, out _))
            {
                
            }
            
            return new OkObjectResult(principal);
        }

        
    }


}

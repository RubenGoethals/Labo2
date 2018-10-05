
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace NMCT.IoTCloud._GarbageServices
{
    public static class History
    {
        [FunctionName("History")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, ILogger log)
        {
            string from = string.Empty, to = string.Empty;

            foreach (var key in req.Query.Keys)
            {
                if (key == "from")
                {
                    from = req.Query["from"];
                }
                if (key == "to")
                {
                    to = req.Query["to"];
                }
            }

            string result = $"Van {from} tot {to}";
            return new OkObjectResult("result");
        }
    }
}

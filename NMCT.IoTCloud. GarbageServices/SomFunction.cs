
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
    public static class SomFunction
    {
        [FunctionName("SomFunction")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "calculator/som/{number1}/{number2}")]HttpRequest req, int number1, int number2, ILogger log)
        {
            try
            {
                log.LogInformation("C# HTTP trigger function processed a request.");

                int som = number1 + number2;

                return new OkObjectResult(som);
            }
            catch
            {
                return null;
            }
            

        }
    }
}

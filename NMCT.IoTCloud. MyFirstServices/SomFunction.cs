using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace NMCT.IoTCloud. MyFirstServices
{
    public static class SomFunction
    {
        [FunctionName("SomFunction")]
        public static async Task<HttpResponseMessage> Som([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route ="calculator/som/{number1}/{number2}")]HttpRequestMessage req,int number1, int number2, TraceWriter log)
        {
            log.logInformation("C# HTTP trigger function processed a request.");
            int som = number1 + number2;

            return new OkO(som);
           
        }
    }
}

using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Test.Function
{
  public static class RandomNumber
  {
    [FunctionName("RandomNumber")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
        ILogger log)
    {
      log.LogInformation("[HTTP] Randon number function processed a request.");
      Random _random = new Random();
      var maxNumber = String.IsNullOrEmpty(req.Query["max"]) ? 100 : Int32.Parse(req.Query["max"]);

      return new OkObjectResult(new { status = "ok", max = maxNumber, random = _random.Next(maxNumber) });
    }
  }
}

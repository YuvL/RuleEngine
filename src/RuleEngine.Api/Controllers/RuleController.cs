using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;

namespace RuleEngine.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("addNumbers")]
        public async Task<IActionResult> MyAction([FromServices] INodeServices nodeServices)
        {
            var result = await nodeServices.InvokeAsync<int>("./addNumbers", 1, 2);
            return Content("1 + 2 = " + result);
        }
    }
}

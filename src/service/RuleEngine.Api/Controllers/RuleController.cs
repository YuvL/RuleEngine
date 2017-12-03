using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RuleEngine.Core;
using RuleEngine.Core.Abstractions.Services;

namespace RuleEngine.Api.Controllers
{
    [Route("api/[controller]")]
    public class RuleController : Controller
    {
        private IRuleEngineService _ruleEngineService;

        public RuleController(IRuleEngineService ruleEngineService)
        {
            _ruleEngineService = ruleEngineService;
        }

        [HttpGet("{name}/execute")]
        public async Task<IActionResult> MyAction(string name)
        {
            var result = await _ruleEngineService.InvokeAsync(name, 1);
            return Ok(result);
        }
    }
}

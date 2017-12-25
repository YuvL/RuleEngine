using Microsoft.AspNetCore.Mvc;
using RuleEngine.Board.Core.Abstractions.Dto;
using RuleEngine.Core.Abstractions.Services;

namespace RuleEngine_Board.Controllers
{
    [Route("api/[controller]")]
    public class RuleController : Controller
    {
        private readonly IRuleService _ruleService;

        public RuleController(IRuleService ruleService)
        {
            _ruleService = ruleService;
        }
        
        [HttpPost]
        public CreatedAtRouteResult Create(RuleDto rule)
        {
            var ruleDto = _ruleService.CreateRule(rule);
            return CreatedAtRoute(
                routeName: nameof(GetById), 
                routeValues: new {ruleId = ruleDto.Id}, 
                value: ruleDto);
        }
        
        [HttpGet("{id}", Name = nameof(GetById))]
        public IActionResult GetById(int ruleId)
        {
            var ruleDto = _ruleService.GetRule(ruleId);
            return ruleDto == null ? (IActionResult) NotFound(ruleId) : Ok(ruleDto);
        }
    }
}

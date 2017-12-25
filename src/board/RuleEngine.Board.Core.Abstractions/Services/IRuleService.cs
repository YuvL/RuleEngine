using System;
using System.Threading.Tasks;
using RuleEngine.Board.Core.Abstractions.Dto;

namespace RuleEngine.Core.Abstractions.Services
{
    public interface IRuleService
    {
        RuleDto CreateRule(RuleDto rule);
        RuleDto GetRule(int ruleId);
    }
}

using System;
using RuleEngine.Board.Core.Abstractions.BusinessObjets;

namespace RuleEngine.Abstractions.Repositories
{
    public interface IRuleRepository
    {
        IRuleAggregate CreateRule(string name, string lang, string code);
    }
}

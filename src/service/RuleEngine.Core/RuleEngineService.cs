using System;
using System.Threading.Tasks;
using RuleEngine.Core.Abstractions.Services;

namespace RuleEngine.Core
{
    public class RuleEngineService : IRuleEngineService
    {
        public RuleEngineService()
        {
        }

        public Task<object> InvokeAsync(string name, object arg)
        {
            throw new NotImplementedException();
        }
    }
}

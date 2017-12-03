using System;
using System.Threading.Tasks;

namespace RuleEngine.Core.Abstractions.Services
{
    public interface IRuleEngineService
    {
        Task<object> InvokeAsync(string name, object arg);
    }
}

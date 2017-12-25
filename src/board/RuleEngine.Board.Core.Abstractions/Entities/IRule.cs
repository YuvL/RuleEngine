namespace RuleEngine.Abstractions
{
    public interface IRule
    {
        string Name { get; set; }
        string SourceCode { get; set; }
        string SourceCodeLang { get; set; }
    }
}

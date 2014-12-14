using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public interface IStatementGenerator
    {
        string Generate(IStatement statement);
    }
}
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public interface IDeclarationGenerator
    {
        string Generate(Declaration declaration);
    }
}
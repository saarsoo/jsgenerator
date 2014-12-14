using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public interface IConstantGenerator
    {
        string Generate(Constant constant);
    }
}
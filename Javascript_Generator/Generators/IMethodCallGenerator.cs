using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public interface IMethodCallGenerator
    {
        string Generate(MethodCall methodCall);
    }
}
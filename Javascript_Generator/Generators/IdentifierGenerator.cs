using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class IdentifierGenerator : IIdentifierGenerator
    {
        public string Generate(Identifier identifier)
        {
            return identifier.Name;
        }
    }
}

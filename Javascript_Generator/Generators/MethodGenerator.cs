using System;
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class MethodGenerator : IMethodGenerator, IDependency<IBlockGenerator>
    {
        private IBlockGenerator _blockGenerator;

        public string Generate(Method method)
        {
            return String.Format("function(){{{0}}}", _blockGenerator.Generate(method.Body));
        }

        public void InjectDependency(IBlockGenerator dependency)
        {
            _blockGenerator = dependency;
        }
    }
}

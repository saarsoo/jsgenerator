using System;
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class AccessorGenerator : IAccessorGenerator, IDependency<IStatementGenerator>
    {
        private IStatementGenerator _statementGenerator;

        public string Generate(Accessor accessor)
        {
            var from = _statementGenerator.Generate(accessor.From);
            var to = _statementGenerator.Generate(accessor.To);

            return String.Format("{0}.{1}", from, to);
        }

        public void InjectDependency(IStatementGenerator dependency)
        {
            _statementGenerator = dependency;
        }
    }
}

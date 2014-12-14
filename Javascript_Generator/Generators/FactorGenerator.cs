using System;
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class FactorGenerator : IFactorGenerator, IDependency<IStatementGenerator>
    {
        private IStatementGenerator _statementGenerator;

        public string Generate(Factor factor)
        {
            return String.Format("({0})", _statementGenerator.Generate(factor.Statement));
        }

        public void InjectDependency(IStatementGenerator dependency)
        {
            _statementGenerator = dependency;
        }
    }
}

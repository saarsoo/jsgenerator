using System;
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class DeclarationGenerator : IDeclarationGenerator, IDependency<IStatementGenerator>
    {
        private IStatementGenerator _statementGenerator;

        public string Generate(Declaration declaration)
        {
            return String.Format("var {0}", _statementGenerator.Generate(declaration.To));
        }

        public void InjectDependency(IStatementGenerator dependency)
        {
            _statementGenerator = dependency;
        }
    }
}

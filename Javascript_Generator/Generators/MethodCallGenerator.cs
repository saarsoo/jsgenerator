using System;
using System.Linq;
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class MethodCallGenerator : IMethodCallGenerator, IDependency<IStatementGenerator>
    {
        private IStatementGenerator _statementGenerator;

        public string Generate(MethodCall methodCall)
        {
            var from = _statementGenerator.Generate(methodCall.From);
            var arguments = String.Join(",", methodCall.Arguments.Select(a => _statementGenerator.Generate(a)));

            return String.Format("{0}({1})", from, arguments);
        }

        public void InjectDependency(IStatementGenerator dependency)
        {
            _statementGenerator = dependency;
        }
    }
}

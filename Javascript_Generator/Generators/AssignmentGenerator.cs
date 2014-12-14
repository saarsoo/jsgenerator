using System;
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class AssignmentGenerator : IAssignmentGenerator, IDependency<IStatementGenerator>
    {
        private IStatementGenerator _statementGenerator;

        public string Generate(Assignment assignment)
        {
            var from = _statementGenerator.Generate(assignment.From);
            var to = _statementGenerator.Generate(assignment.To);

            return String.Format("{0}={1}", @from, to);
        }

        public void InjectDependency(IStatementGenerator dependency)
        {
            _statementGenerator = dependency;
        }
    }
}
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class BlockGenerator : IBlockGenerator, IDependency<IStatementGenerator>
    {
        private IStatementGenerator _statementGenerator;

        public string Generate(Block body)
        {
            var code = "";

            foreach (var statement in body.Statements)
            {
                code += _statementGenerator.Generate(statement);
                code += ";";
            }

            return code;
        }

        public void InjectDependency(IStatementGenerator dependency)
        {
            _statementGenerator = dependency;
        }
    }
}

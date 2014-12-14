using System.Collections.Generic;

namespace Javascript_Generator.Structures
{
    public class Block : IStatement
    {
        public IEnumerable<IStatement> Statements { get; set; }

        public Block()
        {
            Statements = new IStatement[] { };
        }

        public Block(IEnumerable<IStatement> statements)
        {
            Statements = statements;
        }
    }
}

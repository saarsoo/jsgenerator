using System.Collections.Generic;

namespace Javascript_Generator.Structures
{
    public class MethodCall : IStatement
    {
        public IStatement From { get; set; }
        public IEnumerable<IStatement> Arguments { get; set; }

        public MethodCall(IStatement from)
        {
            From = from;
            Arguments = new IStatement[] { };
        }
    }
}
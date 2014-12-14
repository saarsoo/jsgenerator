namespace Javascript_Generator.Structures
{
    public class Accessor : IStatement
    {
        public IStatement From { get; set; }
        public IStatement To { get; set; }

        public Accessor(IStatement from, IStatement to)
        {
            From = from;
            To = to;
        }
    }
}
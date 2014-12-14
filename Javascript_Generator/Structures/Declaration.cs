namespace Javascript_Generator.Structures
{
    public class Declaration : IStatement
    {
        public IStatement To { get; set; }

        public Declaration(IStatement to)
        {
            To = to;
        }
    }
}

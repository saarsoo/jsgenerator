namespace Javascript_Generator.Structures
{
    public class Factor : IStatement
    {
        public IStatement Statement { get; set; }

        public Factor(IStatement statement)
        {
            Statement = statement;
        }
    }
}
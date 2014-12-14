namespace Javascript_Generator.Structures
{
    public class Method : IStatement
    {
        public Block Body { get; set; }

        public Method(Block body)
        {
            Body = body;
        }
    }
}
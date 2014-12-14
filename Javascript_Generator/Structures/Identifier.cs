namespace Javascript_Generator.Structures
{
    public class Identifier : IStatement
    {
        public string Name { get; set; }

        public Identifier(string name)
        {
            Name = name;
        }
    }
}

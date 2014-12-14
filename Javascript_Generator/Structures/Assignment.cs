﻿namespace Javascript_Generator.Structures
{
    public class Assignment : IStatement
    {
        public IStatement From { get; set; }
        public IStatement To { get; set; }

        public Assignment(IStatement from, IStatement to)
        {
            From = from;
            To = to;
        }
    }
}

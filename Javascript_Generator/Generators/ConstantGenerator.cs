using System;
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class ConstantGenerator : IConstantGenerator
    {
        public string Generate(Constant constant)
        {
            var value = constant.Value;

            if (value == null)
            {
                return "null";
            }

            if (value is Boolean)
            {
                return value.ToString().ToLower();
            }

            if (value is String)
            {
                return String.Format("\"{0}\"", constant.Value);
            }

            return value.ToString();
        }
    }
}

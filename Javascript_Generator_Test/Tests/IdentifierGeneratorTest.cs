using Javascript_Generator.Generators;
using Javascript_Generator.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Javascript_Generator_Test.Tests
{
    [TestClass]
    public class IdentifierGeneratorTest
    {
        private IdentifierGenerator _generator;

        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new IdentifierGenerator();
        }

        [TestMethod]
        public void TestGenerate()
        {
            var code = _generator.Generate(new Identifier("foo"));

            Assert.AreEqual("foo", code);
        }
    }
}

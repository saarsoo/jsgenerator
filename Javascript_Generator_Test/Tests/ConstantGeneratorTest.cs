using Javascript_Generator.Generators;
using Javascript_Generator.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Javascript_Generator_Test.Tests
{
    [TestClass]
    public class ConstantGeneratorTest
    {
        private ConstantGenerator _generator;

        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new ConstantGenerator();
        }

        [TestMethod]
        public void TestGenerateString()
        {
            var code = _generator.Generate(new Constant("foo"));

            Assert.AreEqual("\"foo\"", code);
        }

        [TestMethod]
        public void TestGenerateNumber()
        {
            var code = _generator.Generate(new Constant(5));

            Assert.AreEqual("5", code);
        }

        [TestMethod]
        public void TestGenerateBoolean()
        {
            var code = _generator.Generate(new Constant(false));

            Assert.AreEqual("false", code);
        }

        [TestMethod]
        public void TestGenerateNull()
        {
            var code = _generator.Generate(new Constant(null));

            Assert.AreEqual("null", code);
        }
    }
}

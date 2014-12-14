using Javascript_Generator.Generators;
using Javascript_Generator.Structures;
using Javascript_Generator_Test.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Javascript_Generator_Test.Tests
{
    [TestClass]
    public class FileGeneratorTest
    {
        private FileGenerator _generator;
        private BlockGeneratorStub _blockGenerator;

        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new FileGenerator();
            _generator.InjectDependency(_blockGenerator = new BlockGeneratorStub());
        }

        [TestMethod]
        public void TestGenerateEmpty()
        {
            _blockGenerator.Results = new[] { "" };

            var code = _generator.Generate(new File());

            Assert.AreEqual("", code);
        }

        [TestMethod]
        public void TestGenerateBody()
        {
            _blockGenerator.Results = new[] { "var foo = \"bar\";" };

            var code = _generator.Generate(new File
            {
                Body = new Block(new[] { new Assignment(new Identifier("foo"), new Constant("bar")) })
            });

            Assert.AreEqual("var foo = \"bar\";", code);
        }
    }
}

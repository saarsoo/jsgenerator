using Javascript_Generator.Generators;
using Javascript_Generator.Structures;
using Javascript_Generator_Test.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Javascript_Generator_Test.Tests
{
    [TestClass]
    public class MethodGeneratorTest
    {
        private MethodGenerator _generator;
        private BlockGeneratorStub _blockGenerator;

        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new MethodGenerator();
            _generator.InjectDependency(_blockGenerator = new BlockGeneratorStub());
        }

        [TestMethod]
        public void TestGenerateEmpty()
        {
            _blockGenerator.Results = new[] { "" };

            var code = _generator.Generate(new Method(new Block()));

            Assert.AreEqual("function(){}", code);
        }

        [TestMethod]
        public void TestGenerate()
        {
            _blockGenerator.Results = new[] { "\"use strict\";" };

            var code = _generator.Generate(new Method(new Block(new[]
            {
                new Constant("use strict"), 
            })));

            Assert.AreEqual("function(){\"use strict\";}", code);
        }
    }
}
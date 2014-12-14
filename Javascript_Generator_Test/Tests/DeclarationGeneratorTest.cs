using Javascript_Generator.Generators;
using Javascript_Generator.Structures;
using Javascript_Generator_Test.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Javascript_Generator_Test.Tests
{
    [TestClass]
    public class DeclarationGeneratorTest
    {
        private DeclarationGenerator _generator;
        private StatementGeneratorStub _statementGenerator;

        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new DeclarationGenerator();
            _generator.InjectDependency(_statementGenerator = new StatementGeneratorStub());
        }

        [TestMethod]
        public void TestGenerate()
        {
            _statementGenerator.Results = new[] { "foo" };

            var code = _generator.Generate(new Declaration(new Identifier("foo")));

            Assert.AreEqual("var foo", code);
        }
    }
}

using Javascript_Generator.Generators;
using Javascript_Generator.Structures;
using Javascript_Generator_Test.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Javascript_Generator_Test.Tests
{
    [TestClass]
    public class FactorGeneratorTest
    {
        private FactorGenerator _generator;
        private StatementGeneratorStub _statementGenerator;

        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new FactorGenerator();
            _generator.InjectDependency(_statementGenerator = new StatementGeneratorStub());
        }

        [TestMethod]
        public void TestGenerate()
        {
            _statementGenerator.Results = new[] { "foo" };

            var code = _generator.Generate(new Factor(new Identifier("foo")));

            Assert.AreEqual("(foo)", code);
        }
    }
}

using Javascript_Generator.Generators;
using Javascript_Generator.Structures;
using Javascript_Generator_Test.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Javascript_Generator_Test.Tests
{
    [TestClass]
    public class AssignmentGeneratorTest
    {
        private AssignmentGenerator _generator;
        private StatementGeneratorStub _statementGenerator;

        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new AssignmentGenerator();
            _generator.InjectDependency(_statementGenerator = new StatementGeneratorStub());
        }

        [TestMethod]
        public void TestGenerate()
        {
            _statementGenerator.Results = new[] { "foo", "\"bar\"" };

            var code = _generator.Generate(new Assignment(new Identifier("foo"), new Constant("bar")));

            Assert.AreEqual("foo=\"bar\"", code);
        }
    }
}

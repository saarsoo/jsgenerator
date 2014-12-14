using System;
using Javascript_Generator.Generators;
using Javascript_Generator.Structures;
using Javascript_Generator_Test.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Javascript_Generator_Test.Tests
{
    [TestClass]
    public class AccessorGeneratorTest
    {
        private AccessorGenerator _generator;
        private StatementGeneratorStub _statementGenerator;

        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new AccessorGenerator();
            _generator.InjectDependency(_statementGenerator = new StatementGeneratorStub());
        }

        [TestMethod]
        public void TestGenerate()
        {
            _statementGenerator.Results = new[] { "foo", "bar" };

            var code = _generator.Generate(new Accessor(new Identifier("foo"), new Identifier("bar")));

            Assert.AreEqual("foo.bar", code);
        }
    }
}

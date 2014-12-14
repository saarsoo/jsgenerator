using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Javascript_Generator.Generators;
using Javascript_Generator.Structures;
using Javascript_Generator_Test.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Javascript_Generator_Test.Tests
{
    [TestClass]
    public class StatementGeneratorTest
    {
        private StatementGenerator _generator;
        private ConstantGeneratorStub _constantGenerator;
        private IdentifierGeneratorStub _identifierGenerator;
        private FactorGeneratorStub _factorGeenrator;
        private MethodGeneratorStub _methodGenerator;
        private MethodCallGeneratorStub _methodCallGenerator;
        private DeclarationGeneratorStub _declarationGenerator;
        private AssignmentGeneratorStub _assignmentGenerator;
        private AccessorGeneratorStub _accessorGenerator;

        [TestInitialize]
        public void TestInitialize()
        {
            _generator = new StatementGenerator();
            _generator.InjectDependency(_constantGenerator = new ConstantGeneratorStub());
            _generator.InjectDependency(_identifierGenerator = new IdentifierGeneratorStub());
            _generator.InjectDependency(_factorGeenrator = new FactorGeneratorStub());
            _generator.InjectDependency(_methodGenerator = new MethodGeneratorStub());
            _generator.InjectDependency(_methodCallGenerator = new MethodCallGeneratorStub());
            _generator.InjectDependency(_declarationGenerator = new DeclarationGeneratorStub());
            _generator.InjectDependency(_assignmentGenerator = new AssignmentGeneratorStub());
            _generator.InjectDependency(_accessorGenerator = new AccessorGeneratorStub());
        }

        [TestMethod]
        public void TestGenerateIdentifier()
        {
            _identifierGenerator.Results = new[] { "foo" };

            var code = _generator.Generate(new Identifier("foo"));

            Assert.AreEqual("foo", code);
        }

        [TestMethod]
        public void TestGenerateConstant()
        {
            _constantGenerator.Results = new[] { "\"foo\"" };

            var code = _generator.Generate(new Constant("foo"));

            Assert.AreEqual("\"foo\"", code);
        }

        [TestMethod]
        public void TestGenerateFactor()
        {
            _factorGeenrator.Results = new[] { "(\"foo\")" };

            var code = _generator.Generate(new Factor(new Constant("foo")));

            Assert.AreEqual("(\"foo\")", code);
        }

        [TestMethod]
        public void TestGenerateMethod()
        {
            _methodGenerator.Results = new[] { "function(){}" };

            var code = _generator.Generate(new Method(new Block()));

            Assert.AreEqual("function(){}", code);
        }

        [TestMethod]
        public void TestGenerateMethodCall()
        {
            _methodCallGenerator.Results = new[] { "foo()" };

            var code = _generator.Generate(new MethodCall(new Identifier("foo")));

            Assert.AreEqual("foo()", code);
        }

        [TestMethod]
        public void TestGenerateDeclaration()
        {
            _declarationGenerator.Results = new[] { "var foo" };

            var code = _generator.Generate(new Declaration(new Identifier("foo")));

            Assert.AreEqual("var foo", code);
        }

        [TestMethod]
        public void TestGenerateAssignment()
        {
            _assignmentGenerator.Results = new[] { "foo=\"bar\"" };

            var code = _generator.Generate(new Assignment(new Identifier("foo"), new Constant("bar")));

            Assert.AreEqual("foo=\"bar\"", code);
        }

        [TestMethod]
        public void TestGenerateAccessor()
        {
            _accessorGenerator.Results = new[] { "foo.bar" };

            var code = _generator.Generate(new Accessor(new Identifier("foo"), new Identifier("bar")));

            Assert.AreEqual("foo.bar", code);
        }
    }
}

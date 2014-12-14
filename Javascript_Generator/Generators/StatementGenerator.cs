using System;
using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class StatementGenerator : IStatementGenerator,
        IDependency<IConstantGenerator>,
        IDependency<IIdentifierGenerator>,
        IDependency<IFactorGenerator>,
        IDependency<IMethodGenerator>,
        IDependency<IMethodCallGenerator>,
        IDependency<IDeclarationGenerator>,
        IDependency<IAssignmentGenerator>,
        IDependency<IAccessorGenerator>
    {
        private IConstantGenerator _constantGenerator;
        private IIdentifierGenerator _identifierGenerator;
        private IFactorGenerator _factorGenerator;
        private IMethodGenerator _methodGenerator;
        private IMethodCallGenerator _methodCallGenerator;
        private IDeclarationGenerator _declarationGenerator;
        private IAssignmentGenerator _assignmentGenerator;
        private IAccessorGenerator _accessorGenerator;

        public string Generate(IStatement statement)
        {
            if (statement is Constant)
            {
                return _constantGenerator.Generate((Constant) statement);
            }
            if (statement is Identifier)
            {
                return _identifierGenerator.Generate((Identifier) statement);
            }
            if (statement is Factor)
            {
                return _factorGenerator.Generate((Factor) statement);
            }
            if (statement is Method)
            {
                return _methodGenerator.Generate((Method) statement);
            }
            if (statement is MethodCall)
            {
                return _methodCallGenerator.Generate((MethodCall) statement);
            }
            if (statement is Declaration)
            {
                return _declarationGenerator.Generate((Declaration) statement);
            }
            if (statement is Assignment)
            {
                return _assignmentGenerator.Generate((Assignment) statement);
            }
            if (statement is Accessor)
            {
                return _accessorGenerator.Generate((Accessor) statement);
            }

            throw new NotImplementedException();
        }

        public void InjectDependency(IConstantGenerator dependency)
        {
            _constantGenerator = dependency;
        }

        public void InjectDependency(IIdentifierGenerator dependency)
        {
            _identifierGenerator = dependency;
        }

        public void InjectDependency(IFactorGenerator dependency)
        {
            _factorGenerator = dependency;
        }

        public void InjectDependency(IMethodGenerator dependency)
        {
            _methodGenerator = dependency;
        }

        public void InjectDependency(IMethodCallGenerator dependency)
        {
            _methodCallGenerator = dependency;
        }

        public void InjectDependency(IDeclarationGenerator dependency)
        {
            _declarationGenerator = dependency;
        }

        public void InjectDependency(IAssignmentGenerator dependency)
        {
            _assignmentGenerator = dependency;
        }

        public void InjectDependency(IAccessorGenerator dependency)
        {
            _accessorGenerator = dependency;
        }
    }
}

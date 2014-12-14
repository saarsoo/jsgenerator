using Javascript_Generator.Structures;

namespace Javascript_Generator.Generators
{
    public class FileGenerator : IDependency<IBlockGenerator>
    {
        private IBlockGenerator _blockGenerator;

        public static FileGenerator Create()
        {
            return new Resolver("Javascript_Generator").Resolve<FileGenerator>();
        }

        public string Generate(File file)
        {
            return _blockGenerator.Generate(file.Body);
        }

        public void InjectDependency(IBlockGenerator dependency)
        {
            _blockGenerator = dependency;
        }
    }
}

namespace OpenNISharp2.CppSharpUnsafeGenerator.Definitions
{
    internal class ConstantDefinition : IDefinition, ICanGenerateXmlDoc
    {
        public string Value { get; set; }
        public string TypeName { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
    }
}
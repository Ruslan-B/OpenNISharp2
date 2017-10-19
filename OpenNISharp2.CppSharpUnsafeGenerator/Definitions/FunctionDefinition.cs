namespace OpenNISharp2.CppSharpUnsafeGenerator.Definitions
{
    internal class FunctionDefinition : IDefinition, ICanGenerateXmlDoc
    {
        public TypeDefinition ReturnType { get; set; }
        public string LibraryName { get; set; }
        public int LibraryVersion { get; set; }
        public FunctionParameter[] Parameters { get; set; }
        public bool IsObsolete { get; set; }
        public string ObsoleteMessage { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
    }
}
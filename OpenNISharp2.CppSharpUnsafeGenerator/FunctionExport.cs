using System.Diagnostics;

namespace OpenNISharp2.CppSharpUnsafeGenerator
{
    [DebuggerDisplay("{Name}, {LibraryName}")]
    internal class FunctionExport
    {
        public string Name { get; set; }
        public string LibraryName { get; set; }
    }
}
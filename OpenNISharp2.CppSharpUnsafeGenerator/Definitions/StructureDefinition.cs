﻿namespace OpenNISharp2.CppSharpUnsafeGenerator.Definitions
{
    internal class StructureDefinition : NamedDefinition, IDefinition
    {
        public StructureField[] Fileds { get; set; } = { };
        public bool IsComplete { get; set; }
    }
}
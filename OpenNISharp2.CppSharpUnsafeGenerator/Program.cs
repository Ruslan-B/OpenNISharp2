using System;
using System.IO;
using System.Linq;
using OpenNISharp2.CppSharpUnsafeGenerator.Processors;

namespace OpenNISharp2.CppSharpUnsafeGenerator
{
    internal class Program
    {
        private const string SolutionDir = @"..\..\..\";
        private const string Namespace = "OpenNISharp2.Native";
        private const string ClassName = "OniCAPI";
        private static readonly string OpenNIDir = Environment.ExpandEnvironmentVariables(@"%ProgramFiles%\OpenNI2");
        private static readonly string OpenNIBinDir = Path.Combine(OpenNIDir, "Redist");
        private static readonly string OpenNIIncludeDir = Path.Combine(SolutionDir, "Include");
        private static readonly string OutputDir = Path.Combine(SolutionDir, "OpenNISharp2", @"Native\");

        private static readonly string[] IncludeDirs = {Path.GetFullPath(OpenNIIncludeDir)};
        private static readonly string[] Defines = { "__STDC_CONSTANT_MACROS" }; //{ "__cplusplus", "_WIN32" };// {"__STDC_CONSTANT_MACROS"};

        private static void Main(string[] args)
        {
            Console.WriteLine("Current directory: " + Environment.CurrentDirectory);
            Console.WriteLine("Is 64 bit process: " + Environment.Is64BitProcess);

            var exports = FunctionExportHelper.LoadFunctionExports(OpenNIBinDir).ToArray();

            var astProcessor = new ASTProcessor {FunctionExportMap = exports.GroupBy(x => x.Name).Select(x => x.First()).ToDictionary(x => x.Name)};
            astProcessor.IgnoreUnitNames.Add("__NSConstantString_tag");
            astProcessor.TypeAliases.Add("int64_t", typeof(long));

            var g = new Generator(astProcessor)
            {
                IncludeDirs = IncludeDirs,
                Defines = Defines,
                Exports = exports,
                Namespace = Namespace,
                ClassName = ClassName
            };
            
            g.Parse("OniVersion.h");
            g.Parse("OniCProperties.h");
            g.Parse("OniCEnums.h");
            g.Parse("OniCTypes.h");
            g.Parse("OniCAPI.h");
            g.Parse("PrimeSense.h");
            g.Parse("PS1080.h");
            g.Parse("PSLink.h");

            g.WriteMacros(OutputDir + "OniCAPI.macros.g.cs");
            g.WriteConst(OutputDir + "OniCAPI.consts.g.cs");
            g.WriteEnums(OutputDir + "OniCAPI.enums.g.cs");
            g.WriteDelegates(OutputDir + "OniCAPI.delegates.g.cs");
            g.WriteArrays(OutputDir + "OniCAPI.arrays.g.cs");
            g.WriteStructures(OutputDir + "OniCAPI.structs.g.cs");
            g.WriteIncompleteStructures(OutputDir + "OniCAPI.structs.incomplete.g.cs");
            g.WriteFunctions(OutputDir + "OniCAPI.functions.g.cs");
        }
    }
}
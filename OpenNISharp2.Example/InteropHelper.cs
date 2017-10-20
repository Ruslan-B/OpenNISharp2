using System;
using System.IO;
using OpenNISharp2.Native;

namespace OpenNISharp2.Example
{
    public static class InteropHelper
    {
        public const string LD_LIBRARY_PATH = "LD_LIBRARY_PATH";

        public static void RegisterLibrariesSearchPath(string path)
        {
            path = Environment.ExpandEnvironmentVariables(path);

            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                    WindowsNativeMethods.SetDllDirectory(path);
                    break;
                case PlatformID.Unix:
                case PlatformID.MacOSX:
                    var currentValue = Environment.GetEnvironmentVariable(LD_LIBRARY_PATH) ?? string.Empty;
                    var newValue = string.IsNullOrEmpty(currentValue) ? path : currentValue + Path.PathSeparator + path;
                    Environment.SetEnvironmentVariable(LD_LIBRARY_PATH, newValue);
                    break;
            }
        }
    }
}
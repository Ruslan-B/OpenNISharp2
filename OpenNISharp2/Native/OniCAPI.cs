using System;
using System.Collections.Generic;

namespace OpenNISharp2.Native
{
    public delegate IntPtr GetOrLoadLibrary(string libraryName);

    public static partial class OniCAPI
    {
        static OniCAPI()
        {
            var loadedLibraries = new Dictionary<string, IntPtr>();

            GetOrLoadLibrary = name =>
            {
                var key = $"{name}";
                if (loadedLibraries.TryGetValue(key, out var ptr)) return ptr;
                ptr = LibraryLoader.LoadNativeLibraryUsingPlatformNamingConvention(string.Empty, name);
                loadedLibraries.Add(key, ptr);
                return ptr;
            };
        }

        public static GetOrLoadLibrary GetOrLoadLibrary { get; set; }

        public static T GetFunctionDelegate<T>(IntPtr libraryHandle, string functionName)
            => FunctionLoader.GetFunctionDelegate<T>(libraryHandle, functionName);
    }
}
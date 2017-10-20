﻿using System;
using System.IO;
using System.Runtime.InteropServices;

namespace OpenNISharp2.Native
{
    public static class LibraryLoader
    {
        /// <summary>
        ///     Attempts to load a native library using platform nammig convention.
        /// </summary>
        /// <param name="path">Path of the library.</param>
        /// <param name="libraryName">Name of the library.</param>
        /// <returns>
        ///     A handle to the library when found; otherwise, <see cref="IntPtr.Zero" />.
        /// </returns>
        /// <remarks>
        ///     This function may return a null handle. If it does, individual functions loaded from it will throw a
        ///     DllNotFoundException,
        ///     but not until an attempt is made to actually use the function (rather than load it). This matches how PInvokes
        ///     behave.
        /// </remarks>
        public static IntPtr LoadNativeLibraryUsingPlatformNamingConvention(string path, string libraryName)
        {
#if NET46
            var fullName = Path.Combine(path, $"{libraryName}.dll");
            return LoadNativeLibrary(fullName);
#else
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var fullName = Path.Combine(path, $"{libraryName}.dll");
                return LoadNativeLibrary(fullName);
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                var fullName = Path.Combine(path, $"{libraryName}.so");
                return LoadNativeLibrary(fullName);
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                var fullName = Path.Combine(path, $"{libraryName}.dylib");
                return LoadNativeLibrary(fullName);
            }
            throw new PlatformNotSupportedException();
#endif
        }

        /// <summary>
        ///     Attempts to load a native library.
        /// </summary>
        /// <param name="path">Path of the library.</param>
        /// <param name="libraryName">Name of the library.</param>
        /// <returns>
        ///     A handle to the library when found; otherwise, <see cref="IntPtr.Zero" />.
        /// </returns>
        /// <remarks>
        ///     This function may return a null handle. If it does, individual functions loaded from it will throw a
        ///     DllNotFoundException,
        ///     but not until an attempt is made to actually use the function (rather than load it). This matches how PInvokes
        ///     behave.
        /// </remarks>
        public static IntPtr LoadNativeLibrary(string libraryName)
        {
#if NET46
            return WindowsNativeMethods.LoadLibrary(libraryName);
#else
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return WindowsNativeMethods.LoadLibrary(libraryName);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return LinuxNativeMethods.dlopen(libraryName, LinuxNativeMethods.RTLD_NOW);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return MacNativeMethods.dlopen(libraryName, MacNativeMethods.RTLD_NOW);
            throw new PlatformNotSupportedException();
#endif
        }
    }
}
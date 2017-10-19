using System;
using System.Runtime.InteropServices;

namespace OpenNISharp2.Native
{
    public unsafe static partial class OniCAPI
    {
        /// <summary>_CRT_SECURE_NO_DEPRECATE = 1</summary>
        internal const int _CRT_SECURE_NO_DEPRECATE = 0x1;
        /// <summary>_WIN32_IE = 0x0600</summary>
        internal const int _WIN32_IE = 0x600;
        /// <summary>_WIN32_WINDOWS = 0x0410</summary>
        internal const int _WIN32_WINDOWS = 0x410;
        /// <summary>_WIN32_WINNT = 0x0501</summary>
        internal const int _WIN32_WINNT = 0x501;
        // public static ONI_API_EXPORT = __declspec(dllexport);
        // public static ONI_API_IMPORT = __declspec(dllimport);
        // public static ONI_API_VERSION = ONI_CREATE_API_VERSION(ONI_VERSION_MAJOR, ONI_VERSION_MINOR);
        // public static ONI_BRIEF_VERSION_STRING = ONI_STRINGIFY(ONI_VERSION_MAJOR) "." ONI_STRINGIFY(ONI_VERSION_MINOR) "." ONI_STRINGIFY(ONI_VERSION_MAINTENANCE) " (Build " ONI_STRINGIFY(ONI_VERSION_BUILD) ")";
        // public static ONI_C_API = ONI_C_API_IMPORT;
        // public static ONI_C_API_EXPORT = ONI_API_EXPORT;
        // public static ONI_C_API_IMPORT = ONI_API_IMPORT;
        // public static ONI_C_DECL = __cdecl;
        // public static ONI_CALLBACK_TYPE = ONI_STDCALL;
        // public static ONI_CPP_API = ONI_CPP_API_IMPORT;
        /// <summary>ONI_DEFAULT_MEM_ALIGN = 16</summary>
        internal const int ONI_DEFAULT_MEM_ALIGN = 0x10;
        // public static ONI_FILE_MAX_PATH = MAX_PATH;
        /// <summary>ONI_MAX_SENSORS = 10</summary>
        internal const int ONI_MAX_SENSORS = 0xa;
        /// <summary>ONI_MAX_STR = 256</summary>
        internal const int ONI_MAX_STR = 0x100;
        /// <summary>ONI_PLATFORM = ONI_PLATFORM_WIN32</summary>
        internal const int ONI_PLATFORM = ONI_PLATFORM_WIN32;
        /// <summary>ONI_PLATFORM_ANDROID_ARM = 5</summary>
        internal const int ONI_PLATFORM_ANDROID_ARM = 0x5;
        // public static ONI_PLATFORM_ENDIAN_TYPE = ONI_PLATFORM_IS_LITTLE_ENDIAN;
        /// <summary>ONI_PLATFORM_LINUX_ARM = 3</summary>
        internal const int ONI_PLATFORM_LINUX_ARM = 0x3;
        /// <summary>ONI_PLATFORM_LINUX_X86 = 2</summary>
        internal const int ONI_PLATFORM_LINUX_X86 = 0x2;
        /// <summary>ONI_PLATFORM_MACOSX = 4</summary>
        internal const int ONI_PLATFORM_MACOSX = 0x4;
        /// <summary>ONI_PLATFORM_STRING = &quot;Win32&quot;</summary>
        internal const string ONI_PLATFORM_STRING = "Win32";
        /// <summary>ONI_PLATFORM_SUPPORTS_DYNAMIC_LIBS = 1</summary>
        internal const int ONI_PLATFORM_SUPPORTS_DYNAMIC_LIBS = 0x1;
        /// <summary>ONI_PLATFORM_WIN32 = 1</summary>
        internal const int ONI_PLATFORM_WIN32 = 0x1;
        // public static ONI_STDCALL = __stdcall;
        // public static ONI_THREAD_STATIC = __declspec(thread);
        // public static ONI_TIMESTAMP = __DATE__ " " __TIME__;
        /// <summary>ONI_VERSION = ONI_VERSION_MAJOR * 0x5f5e100 + ONI_VERSION_MINOR * 0xf4240 + ONI_VERSION_MAINTENANCE * 0x2710 + ONI_VERSION_BUILD</summary>
        internal const int ONI_VERSION = ONI_VERSION_MAJOR * 0x5f5e100 + ONI_VERSION_MINOR * 0xf4240 + ONI_VERSION_MAINTENANCE * 0x2710 + ONI_VERSION_BUILD;
        /// <summary>ONI_VERSION_BUILD = 0x21</summary>
        internal const int ONI_VERSION_BUILD = 0x21;
        /// <summary>ONI_VERSION_MAINTENANCE = 0x0</summary>
        internal const int ONI_VERSION_MAINTENANCE = 0x0;
        /// <summary>ONI_VERSION_MAJOR = 0x2</summary>
        internal const int ONI_VERSION_MAJOR = 0x2;
        /// <summary>ONI_VERSION_MINOR = 0x2</summary>
        internal const int ONI_VERSION_MINOR = 0x2;
        // public static ONI_VERSION_STRING = ONI_BRIEF_VERSION_STRING  "-" ONI_PLATFORM_STRING " (" ONI_TIMESTAMP ")";
        /// <summary>WINVER = 0x0501</summary>
        internal const int WINVER = 0x501;
        /// <summary>XN_DEVICE_MAX_STRING_LENGTH = 0xc8</summary>
        internal const int XN_DEVICE_MAX_STRING_LENGTH = 0xc8;
        /// <summary>XN_IO_MAX_I2C_BUFFER_SIZE = 0xa</summary>
        internal const int XN_IO_MAX_I2C_BUFFER_SIZE = 0xa;
        /// <summary>XN_MAX_LOG_SIZE = 0x6 * 0x400</summary>
        internal const int XN_MAX_LOG_SIZE = 0x6 * 0x400;
        /// <summary>XN_MAX_VERSION_MODIFIER_LENGTH = 16</summary>
        internal const int XN_MAX_VERSION_MODIFIER_LENGTH = 0x10;
    }
}

using System;
using System.Runtime.InteropServices;
using OpenNISharp2.Native;

namespace OpenNISharp2
{
    public static class OpenNI
    {
        public static string GetExtendedError()
        {
            var message = OniCAPI.oniGetExtendedError();
            return message;
        }

        public static void Initialize()
        {
            OniCAPI.oniInitialize(OniCAPI.ONI_VERSION).ThrowExectionIfStatusIsNotOk();
        }

        public static void Shutdown()
        {
            OniCAPI.oniShutdown();
        }

        public static OpenNIVersion GetVersion() => OniCAPI.oniGetVersion().ToManaged();

        public static unsafe DeviceInfo[] GetDevices()
        {
            OniDeviceInfo* pDevices = null;
            var count = 0;

            OniCAPI.oniGetDeviceList(&pDevices, &count).ThrowExectionIfStatusIsNotOk();

            var devices = new DeviceInfo[count];
            for (var i = 0; i < count; i++)
            {
                var oniDeviceInfo = pDevices[i];

                devices[i] = oniDeviceInfo.ToManaged();
            }

            OniCAPI.oniReleaseDeviceList(pDevices).ThrowExectionIfStatusIsNotOk();

            return devices;
        }

        public static void SetLogMinSeverity(int minSeverity)
        {
            OniCAPI.oniSetLogMinSeverity(minSeverity).ThrowExectionIfStatusIsNotOk();
        }

        public static void SetLogConsoleOutput(bool consoleOutput)
        {
            OniCAPI.oniSetLogConsoleOutput(consoleOutput ? 1 : 0).ThrowExectionIfStatusIsNotOk();
        }

        public static void SetLogFileOutput(bool fileOutput)
        {
            OniCAPI.oniSetLogFileOutput(fileOutput ? 1 : 0).ThrowExectionIfStatusIsNotOk();
        }

        public static void SetLogOutputFolder(string outputFolder)
        {
            OniCAPI.oniSetLogOutputFolder(outputFolder).ThrowExectionIfStatusIsNotOk();
        }

        public static unsafe string GetLogFileName()
        {
            const int MAX_PATH = 260;
            void* pFileName = stackalloc byte[MAX_PATH];
            OniCAPI.oniGetLogFileName((byte*) pFileName, MAX_PATH).ThrowExectionIfStatusIsNotOk();
            var fileName = Marshal.PtrToStringAnsi((IntPtr) pFileName);
            return fileName;
        }
    }
}
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenNISharp2.Native;

namespace OpenNISharp2
{
    public unsafe partial class SensorStream : DisposableBase
    {
        internal readonly _OniStream* Handler;

        internal SensorStream(_OniStream* handler) => Handler = handler;

        /// <summary>
        ///     Wait for a new frame from any of the streams provided. The function blocks until any of the streams
        ///     has a new frame available, or the timeout has passed.
        /// </summary>
        /// <param name="streams">An array of streams to wait for.</param>
        /// <param name="readyStreamIndex">The index of the first stream that has new frame available.</param>
        /// <param name="timeout">A timeout before returning if no stream has new data. Default value is TIMEOUT_FOREVER.</param>
        public static void WaitForAnyStream(SensorStream[] streams, out int readyStreamIndex, int timeout = OniCAPI.ONI_TIMEOUT_FOREVER)
        {
            if (streams == null) throw new ArgumentNullException("streams");
            if (streams.Length == 0) throw new ArgumentOutOfRangeException("streams");

            var pStreams = new _OniStream*[streams.Length];

            for (var i = 0; i < streams.Length; i++) pStreams[i] = streams[i].Handler;

            fixed (_OniStream** pps = &pStreams[0])
            fixed (int* pStreamIndex = &readyStreamIndex)
            {
                OniCAPI.oniWaitForAnyStream(pps, pStreams.Length, pStreamIndex, timeout).ThrowExectionIfStatusIsNotOk();
            }
        }

        public SensorInfo GetSensorInfo()
        {
            var pOniSensorInfo = OniCAPI.oniStreamGetSensorInfo(Handler);
            var oniSensorInfo = *pOniSensorInfo;
            var sensorInfo = oniSensorInfo.ToManaged();
            return sensorInfo;
        }

        public void Start()
        {
            OniCAPI.oniStreamStart(Handler).ThrowExectionIfStatusIsNotOk();
        }

        public void Stop()
        {
            OniCAPI.oniStreamStop(Handler);
        }

        public SensorFrame ReadFrame()
        {
            OniFrame* pFrame = null;
            OniCAPI.oniStreamReadFrame(Handler, &pFrame).ThrowExectionIfStatusIsNotOk();
            return new SensorFrame(pFrame);
        }

        public bool IsPropertySupported(int propertyId)
            => OniCAPI.oniStreamIsPropertySupported(Handler, propertyId) == 1;

        public T GetProperty<T>(int propertyId) where T : struct
        {
            var dataSize = Marshal.SizeOf(typeof(T));
            void* pData = stackalloc byte[dataSize];
            OniCAPI.oniStreamGetProperty(Handler, propertyId, pData, &dataSize).ThrowExectionIfStatusIsNotOk();
            Debug.Assert(dataSize == Marshal.SizeOf(typeof(T)), "dataSize == Marshal.SizeOf(typeof(T))");
            var value = Marshal.PtrToStructure<T>((IntPtr) pData);
            return value;
        }

        public void SetProperty<T>(int propertyId, T value) where T : struct
        {
            var dataSize = Marshal.SizeOf(typeof(T));
            void* pData = stackalloc byte[dataSize];
            Marshal.StructureToPtr(value, (IntPtr) pData, false);
            OniCAPI.oniStreamSetProperty(Handler, propertyId, pData, dataSize).ThrowExectionIfStatusIsNotOk();
        }

        public bool IsCommandSupported(int commandId) => OniCAPI.oniStreamIsCommandSupported(Handler, commandId) == 1;

        public void Invoke<T>(int commandId, T command) where T : struct
        {
            var dataSize = Marshal.SizeOf(typeof(T));
            void* pData = stackalloc byte[dataSize];
            Marshal.StructureToPtr(command, (IntPtr) pData, false);
            OniCAPI.oniStreamInvoke(Handler, commandId, pData, dataSize).ThrowExectionIfStatusIsNotOk();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == false) return;
            OniCAPI.oniStreamDestroy(Handler);
        }
    }
}
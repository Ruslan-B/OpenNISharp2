using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenNISharp2.Native;

namespace OpenNISharp2
{
    public unsafe partial class SensorStream : DisposableBase
    {
        internal readonly _OniStream* PStream;

        internal SensorStream(_OniStream* pStream)
        {
            PStream = pStream;
        }

        /// <summary>
        ///     Wait for a new frame from any of the streams provided. The function blocks until any of the streams
        /// has a new frame available, or the timeout has passed.
        /// </summary>
        /// <param name="streams">An array of streams to wait for.</param>
        /// <param name="readyStreamIndex">The index of the first stream that has new frame available.</param>
        /// <param name="timeout">A timeout before returning if no stream has new data. Default value is TIMEOUT_FOREVER.</param>
        public static void WaitForAnyStream(SensorStream[] streams, out int readyStreamIndex, int timeout = OniCAPI.ONI_TIMEOUT_FOREVER)
        {
            if (streams == null) throw new ArgumentNullException("streams");
            if (streams.Length == 0) throw new ArgumentOutOfRangeException("streams");

            _OniStream*[] pStreams = new _OniStream*[streams.Length];

            for (int i = 0; i < streams.Length; i++) pStreams[i] = streams[i].PStream;

            fixed(_OniStream** pps = &pStreams[0])
            fixed(int* pStreamIndex = &readyStreamIndex)
                OniCAPI.oniWaitForAnyStream(pps, pStreams.Length, pStreamIndex, timeout).ThrowExectionIfStatusIsNotOk();
        }

        public SensorInfo GetSensorInfo()
        {
            OniSensorInfo* pOniSensorInfo = OniCAPI.oniStreamGetSensorInfo(PStream);
            OniSensorInfo oniSensorInfo = *pOniSensorInfo;
            SensorInfo sensorInfo = oniSensorInfo.ToManaged();
            return sensorInfo;
        }

        public void Start()
        {
            OniCAPI.oniStreamStart(PStream).ThrowExectionIfStatusIsNotOk();
        }

        public void Stop()
        {
            OniCAPI.oniStreamStop(PStream);
        }

        public SensorFrame ReadFrame()
        {
            OniFrame* pFrame = null;
            OniCAPI.oniStreamReadFrame(PStream, &pFrame).ThrowExectionIfStatusIsNotOk();
            return new SensorFrame(pFrame);
        }
       
        public bool IsPropertySupported(int propertyId)
        {
            return OniCAPI.oniStreamIsPropertySupported(PStream, propertyId) == 1;
        }

        public T GetProperty<T>(int propertyId) where T : struct
        {
            int dataSize = Marshal.SizeOf(typeof(T));

            IntPtr pData = Marshal.AllocHGlobal(dataSize);
            try
            {
                OniCAPI.oniStreamGetProperty(PStream, propertyId, (void*)pData, &dataSize).ThrowExectionIfStatusIsNotOk();

                Debug.Assert(dataSize == Marshal.SizeOf(typeof(T)), "dataSize == Marshal.SizeOf(typeof(T))");

                var value = (T)Marshal.PtrToStructure(pData, typeof(T));
                return value;
            }
            finally
            {
                Marshal.FreeHGlobal(pData);
            }
        }

        public void SetProperty<T>(int propertyId, T value) where T : struct
        {
            int dataSize = Marshal.SizeOf(typeof(T));

            IntPtr pData = Marshal.AllocHGlobal(Marshal.SizeOf(dataSize));
            try
            {
                Marshal.StructureToPtr(value, pData, false);
                OniCAPI.oniStreamSetProperty(PStream, propertyId, (void*)pData, dataSize).ThrowExectionIfStatusIsNotOk();
            }
            finally
            {
                Marshal.FreeHGlobal(pData);
            }
        }

        public bool IsCommandSupported(int commandId)
        {
            return OniCAPI.oniStreamIsCommandSupported(PStream, commandId) == 1;
        }

        public void Invoke<T>(int commandId, T command) where T : struct
        {
            int dataSize = Marshal.SizeOf(typeof(T));

            IntPtr pData = Marshal.AllocHGlobal(Marshal.SizeOf(dataSize));
            try
            {
                Marshal.StructureToPtr(command, pData, false);
                OniCAPI.oniStreamInvoke(PStream, commandId, (void*)pData, dataSize).ThrowExectionIfStatusIsNotOk();
            }
            finally
            {
                Marshal.FreeHGlobal(pData);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == false)
                return;

            OniCAPI.oniStreamDestroy(PStream);
        }
    }
}
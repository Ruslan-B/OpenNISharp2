using System;
using System.IO;
using System.Runtime.InteropServices;
using OpenNISharp2.Native;

namespace OpenNISharp2
{
    public unsafe class SensorFrame : DisposableBase
    {
        private readonly OniFrame* _pFrame;

        internal SensorFrame(OniFrame* pFrame)
        {
            _pFrame = pFrame;
            Data = new FrameData((byte*) _pFrame->data, _pFrame->dataSize);
        }

        public FrameData Data { get; }

        public SensorType SensorType => _pFrame->sensorType.ToManaged();

        public ulong Timestamp => _pFrame->timestamp;

        public int FrameIndex => _pFrame->frameIndex;

        public int Width => _pFrame->width;

        public int Height => _pFrame->height;

        public VideoMode VideoMode => _pFrame->videoMode.ToManaged();

        public bool CroppingEnabled => _pFrame->croppingEnabled > 0;

        public int CropOriginX => _pFrame->cropOriginX;

        public int CropOriginY => _pFrame->cropOriginY;

        public int Stride => _pFrame->stride;

        protected override void Dispose(bool disposing)
        {
            if (disposing == false)
                return;
            OniCAPI.oniFrameRelease(_pFrame);
        }

        public class FrameData
        {
            private readonly byte* _pData;

            internal FrameData(byte* pData, int size)
            {
                _pData = pData;
                Size = size;
            }

            public IntPtr Handler => (IntPtr) _pData;

            public int Size { get; }

            public Stream CreateStream() => new UnmanagedMemoryStream(_pData, Size);

            public void CopyTo(byte[] buffer)
            {
                Marshal.Copy(Handler, buffer, 0, buffer.Length);
            }
        }
    }
}
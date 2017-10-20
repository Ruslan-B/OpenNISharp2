using OpenNISharp2.Native;

namespace OpenNISharp2
{
    public unsafe class Recorder : DisposableBase
    {
        private _OniRecorder* _pRecorder;

        internal Recorder(_OniRecorder* pRecorder) 
            => _pRecorder = pRecorder;

        public static Recorder Create(string fileName)
        {
            _OniRecorder* pRecorder = null;
            OniCAPI.oniCreateRecorder(fileName, &pRecorder).ThrowExectionIfStatusIsNotOk();
            return new Recorder(pRecorder);
        }

        public void AttachStream(SensorStream stream, bool allowLossyCompression)
        {
            OniCAPI.oniRecorderAttachStream(_pRecorder, stream.Handler, allowLossyCompression ? 1 : 0).ThrowExectionIfStatusIsNotOk();
        }

        public void Start()
        {
            OniCAPI.oniRecorderStart(_pRecorder).ThrowExectionIfStatusIsNotOk();
        }

        public void Stop()
        {
            OniCAPI.oniRecorderStop(_pRecorder);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == false)
                return;
            fixed (_OniRecorder** ppRecorder = &_pRecorder)
            {
                OniCAPI.oniRecorderDestroy(ppRecorder).ThrowExectionIfStatusIsNotOk();
            }
        }
    }
}
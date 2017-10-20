using System;

namespace OpenNISharp2
{
    public abstract class DisposableBase : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected abstract void Dispose(bool disposing);

        ~DisposableBase()
        {
            Dispose(false);
        }
    }
}
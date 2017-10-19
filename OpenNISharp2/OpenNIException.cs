using System;

namespace OpenNISharp2
{
    public class OpenNIException : Exception
    {
        internal OpenNIException(string message) : base(message)
        {
        }

        internal OpenNIException()
        {
        }
    }
}
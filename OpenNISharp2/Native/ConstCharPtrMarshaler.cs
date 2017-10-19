using System;
using System.Runtime.InteropServices;

namespace OpenNISharp2.Native
{
    internal class ConstCharPtrMarshaler : ICustomMarshaler
    {
        public object MarshalNativeToManaged(IntPtr pNativeData) => Marshal.PtrToStringAnsi(pNativeData);

        public IntPtr MarshalManagedToNative(object managedObj) => IntPtr.Zero;

        public void CleanUpNativeData(IntPtr pNativeData)
        {
        }

        public void CleanUpManagedData(object managedObj)
        {
        }

        public int GetNativeDataSize() => IntPtr.Size;

        private static readonly ConstCharPtrMarshaler Instance = new ConstCharPtrMarshaler();

        public static ICustomMarshaler GetInstance(string cookie) => Instance;
    }
}
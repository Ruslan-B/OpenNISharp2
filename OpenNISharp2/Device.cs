using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenNISharp2.Native;

namespace OpenNISharp2
{
    public unsafe partial class Device : DisposableBase
    {
        private readonly _OniDevice* _pDevice;

        internal Device(_OniDevice* pDevice) => _pDevice = pDevice;

        public static Device Open()
        {
            _OniDevice* pDevice = null;
            OniCAPI.oniDeviceOpen(null, &pDevice).ThrowExectionIfStatusIsNotOk();
            return new Device(pDevice);
        }

        public static Device Open(string uri)
        {
            _OniDevice* pDevice = null;
            OniCAPI.oniDeviceOpen(uri, &pDevice).ThrowExectionIfStatusIsNotOk();
            return new Device(pDevice);
        }

        internal static Device Open(string uri, string mode)
        {
            _OniDevice* pDevice = null;
            OniCAPI.oniDeviceOpenEx(uri, mode, &pDevice).ThrowExectionIfStatusIsNotOk();
            return new Device(pDevice);
        }

        public DeviceInfo GetDeviceInfo()
        {
            var oniDeviceInfo = new OniDeviceInfo();
            OniCAPI.oniDeviceGetInfo(_pDevice, &oniDeviceInfo).ThrowExectionIfStatusIsNotOk();
            var deviceInfo = oniDeviceInfo.ToManaged();
            return deviceInfo;
        }

        public SensorInfo GetSensorInfo(SensorType sensorType)
        {
            var pOniSensorInfo = OniCAPI.oniDeviceGetSensorInfo(_pDevice, sensorType.ToNative());
            if (pOniSensorInfo == null)
                return new SensorInfo {SensorType = sensorType};

            var oniSensorInfo = *pOniSensorInfo;
            var sensorInfo = oniSensorInfo.ToManaged();
            return sensorInfo;
        }

        public bool HasSensor(SensorType sensorType) => OniCAPI.oniDeviceGetSensorInfo(_pDevice, sensorType.ToNative()) != null;

        public SensorStream CreateStream(SensorType sensorType)
        {
            _OniStream* pStream = null;
            OniCAPI.oniDeviceCreateStream(_pDevice, sensorType.ToNative(), &pStream).ThrowExectionIfStatusIsNotOk();
            return new SensorStream(pStream);
        }

        public bool IsPropertySupported(int propertyId) => OniCAPI.oniDeviceIsPropertySupported(_pDevice, propertyId) == 1;

        public T GetProperty<T>(int propertyId) where T : struct
        {
            var dataSize = Marshal.SizeOf(typeof(T));
            void* pData = stackalloc byte[dataSize];
            OniCAPI.oniDeviceGetProperty(_pDevice, propertyId, pData, &dataSize).ThrowExectionIfStatusIsNotOk();
            Debug.Assert(dataSize == Marshal.SizeOf(typeof(T)), "dataSize == Marshal.SizeOf(typeof(T))");
            var value = Marshal.PtrToStructure<T>((IntPtr) pData);
            return value;
        }

        public void SetProperty<T>(int propertyId, T value) where T : struct
        {
            var dataSize = Marshal.SizeOf(typeof(T));
            void* pData = stackalloc byte[dataSize];
            Marshal.StructureToPtr(value, (IntPtr) pData, false);
            OniCAPI.oniDeviceSetProperty(_pDevice, propertyId, pData, dataSize).ThrowExectionIfStatusIsNotOk();
        }

        public bool IsCommandSupported(int commandId) => OniCAPI.oniDeviceIsCommandSupported(_pDevice, commandId) == 1;

        public void Invoke<T>(int commandId, T command) where T : struct
        {
            var dataSize = Marshal.SizeOf(typeof(T));
            void* pData = stackalloc byte[dataSize];
            Marshal.StructureToPtr(command, (IntPtr) pData, false);
            OniCAPI.oniDeviceInvoke(_pDevice, commandId, pData, dataSize).ThrowExectionIfStatusIsNotOk();
        }

        public bool IsImageRegistrationModeSupported(ImageRegistrationMode mode) => OniCAPI.oniDeviceIsImageRegistrationModeSupported(_pDevice, mode.ToNative()) == 1;

        protected override void Dispose(bool disposing)
        {
            if (disposing == false)
                return;
            OniCAPI.oniDeviceClose(_pDevice).ThrowExectionIfStatusIsNotOk();
        }
    }
}
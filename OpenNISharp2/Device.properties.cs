using System.Runtime.InteropServices;
using OpenNISharp2.Native;

namespace OpenNISharp2
{
    partial class Device
    {
        public bool IsDriverVersionPropertySupported => IsPropertySupported(OniCAPI.ONI_DEVICE_PROPERTY_DRIVER_VERSION);

        public OpenNIVersion DriverVersion => GetProperty<OniVersion>(OniCAPI.ONI_DEVICE_PROPERTY_DRIVER_VERSION).ToManaged();

        public bool IsHardwareVersionPropertySupported => IsPropertySupported(OniCAPI.ONI_DEVICE_PROPERTY_DRIVER_VERSION);

        public int HardwareVersion => GetProperty<int>(OniCAPI.ONI_DEVICE_PROPERTY_HARDWARE_VERSION);

        public bool IsSerialNumberPropertySupported => IsPropertySupported(OniCAPI.ONI_DEVICE_PROPERTY_SERIAL_NUMBER);

        public unsafe string SerialNumber
        {
            get
            {
                var dataSize = OniCAPI.XN_DEVICE_MAX_STRING_LENGTH;
                var pData = Marshal.AllocHGlobal(dataSize);
                try
                {
                    OniCAPI.oniDeviceGetProperty(_pDevice, OniCAPI.ONI_DEVICE_PROPERTY_SERIAL_NUMBER, (void*) pData, &dataSize).ThrowExectionIfStatusIsNotOk();
                    var value = Marshal.PtrToStringAnsi(pData);
                    return value;
                }
                finally
                {
                    Marshal.FreeHGlobal(pData);
                }
            }
        }

        public bool IsImageRegistrationPropertySupported => IsPropertySupported(OniCAPI.ONI_DEVICE_PROPERTY_IMAGE_REGISTRATION);

        public ImageRegistrationMode ImageRegistration
        {
            get => GetProperty<OniImageRegistrationMode>(OniCAPI.ONI_DEVICE_PROPERTY_IMAGE_REGISTRATION).ToManaged();
            set => SetProperty(OniCAPI.ONI_DEVICE_PROPERTY_IMAGE_REGISTRATION, value.ToNative());
        }

        public unsafe bool DepthColorSync
        {
            get => OniCAPI.oniDeviceGetDepthColorSyncEnabled(_pDevice) == 1;
            set
            {
                if (value)
                    OniCAPI.oniDeviceEnableDepthColorSync(_pDevice).ThrowExectionIfStatusIsNotOk();
                else OniCAPI.oniDeviceDisableDepthColorSync(_pDevice);
            }
        }
    }
}
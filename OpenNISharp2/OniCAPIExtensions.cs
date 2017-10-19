using System;
using OpenNISharp2.Native;

namespace OpenNISharp2
{
    internal static class OniCAPIExtensions
    {
        public static void ThrowExectionIfStatusIsNotOk(this OniStatus status)
        {
            switch (status)
            {
                case OniStatus.ONI_STATUS_OK:
                    return;
                case OniStatus.ONI_STATUS_NOT_IMPLEMENTED:
                    throw new NotImplementedException();
                case OniStatus.ONI_STATUS_NOT_SUPPORTED:
                    throw new NotSupportedException();
                case OniStatus.ONI_STATUS_ERROR:
                case OniStatus.ONI_STATUS_BAD_PARAMETER:
                case OniStatus.ONI_STATUS_OUT_OF_FLOW:
                case OniStatus.ONI_STATUS_NO_DEVICE:
                    var message = OpenNI.GetExtendedError();
                    throw new OpenNIException(message);
                case OniStatus.ONI_STATUS_TIME_OUT:
                    throw new TimeoutException();
                default:
                    throw new ArgumentOutOfRangeException("status", string.Format("Unkown status :{0}.", status));
            }
        }

        public static DeviceInfo ToManaged(this OniDeviceInfo oniDeviceInfo)
        {
            return new DeviceInfo
            {
                Uri = oniDeviceInfo.uri.ToManaged(),
                Vendor = oniDeviceInfo.vendor.ToManaged(),
                Name = oniDeviceInfo.name.ToManaged(),
                UsbVendorId = oniDeviceInfo.usbVendorId,
                UsbProductId = oniDeviceInfo.usbProductId
            };
        }

        public static unsafe SensorInfo ToManaged(this OniSensorInfo oniSensorInfo)
        {
            var videoModes = new VideoMode[oniSensorInfo.numSupportedVideoModes];
            for (var i = 0; i < oniSensorInfo.numSupportedVideoModes; i++)
                videoModes[i] = oniSensorInfo.pSupportedVideoModes[i].ToManaged();

            return new SensorInfo
            {
                SensorType = oniSensorInfo.sensorType.ToManaged(),
                IsSupported = true,
                VideoModes = videoModes
            };
        }
    }
}
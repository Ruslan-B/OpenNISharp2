using System;
using System.IO;
using System.Linq;

namespace OpenNISharp2.Example
{
    internal static class MainClass
    {
        public static void Main(string[] args)
        {
            var OpenNIPathOnWindows = "%ProgramFiles%\\OpenNI2\\Redist";
            InteropHelper.RegisterLibrariesSearchPath(OpenNIPathOnWindows);

            Console.WriteLine("Runnung in {0}-bit mode.", Environment.Is64BitProcess ? "64" : "32");

            OpenNI.Initialize();

            var version = OpenNI.GetVersion();
            Console.WriteLine("OpenNI version: {0}.{1}.{2}.{3}.", version.Major, version.Minor, version.Maintenance, version.Build);
            Console.WriteLine();

            //OpenNI.SetLogMinSeverity(0);
            //OpenNI.SetLogConsoleOutput(true);
            //OpenNI.SetLogFileOutput(true);   
            //Console.WriteLine("Log file path: {0}", OpenNI.GetLogFileName());

            var devices = OpenNI.GetDevices();
            Console.WriteLine("Found {0} device(s):", devices.Length);
            devices.ToList().ForEach(x => Console.WriteLine("{0} from {1} @ {2} with usb id {3}:{4}.", x.Name, x.Vendor, x.Uri, x.UsbVendorId, x.UsbProductId));
            Console.WriteLine();

            if (devices.Length == 0) return;

            // open default device
            using (var device = Device.Open())
            {
                var deviceInfo = device.GetDeviceInfo();
                Console.WriteLine("Device {0} @ {1} was successfully opened.", deviceInfo.Name, deviceInfo.Uri);
                Console.WriteLine();

                if (device.IsDriverVersionPropertySupported)
                {
                    var driverVersion = device.DriverVersion;
                    Console.WriteLine("Driver version: {0}.{1}.{2}.{3}.", driverVersion.Major, driverVersion.Minor, driverVersion.Maintenance, driverVersion.Build);
                    Console.WriteLine("Hardware version: {0}.", device.HardwareVersion);
                    Console.WriteLine("Serial number: {0}.", device.SerialNumber);
                    Console.WriteLine();
                }

                var infraredSensorInfo = device.GetSensorInfo(SensorType.Infrared);
                DescribeSensor(infraredSensorInfo);
                Console.WriteLine();

                var colorSensorInfo = device.GetSensorInfo(SensorType.Color);
                DescribeSensor(colorSensorInfo);
                Console.WriteLine();

                var depthSensorInfo = device.GetSensorInfo(SensorType.Depth);
                DescribeSensor(depthSensorInfo);
                Console.WriteLine();

                using (var stream = device.CreateStream(SensorType.Depth))
                {
                    var streamSensorInfo = stream.GetSensorInfo();
                    DescribeVideoModes(streamSensorInfo);
                    Console.WriteLine();

                    stream.VideoMode = new VideoMode {Fps = 30, PixelFormat = PixelFormat.Depth100UM, ResolutionX = 640, ResolutionY = 480};

                    var videoMode = stream.VideoMode;

                    var hFov = stream.IsHorizontalFovPropertySupported ? stream.HorizontalFov : float.NaN;
                    var vFov = stream.IsVerticalFovPropertySupported ? stream.VerticalFov : float.NaN;
                    var minValue = stream.IsMinValuePropertySupported ? stream.MinValue : -1;
                    var maxValue = stream.IsMaxValuePropertySupported ? stream.MaxValue : -1;

                    Console.WriteLine("Stream properties:");
                    var rtdK = (float) (180.0 / Math.PI);
                    Console.WriteLine("Horizontal {0:0.0} (deg) and vertical {1:0.0} (deg) FOV.", hFov * rtdK, vFov * rtdK);
                    Console.WriteLine("Min {0} and max {1} values.", minValue, maxValue);

                    stream.Start();

                    for (int i = 0; i < 30; i++)
                    {
                        ReadFreame(stream);
                    }
               

                    stream.Stop();
                }
            }
            OpenNI.Shutdown();
        }

        private static void ReadFreame(SensorStream stream)
        {
            using (var frame = stream.ReadFrame())
            {
                Console.WriteLine("Video frame acquired:");
                DescribeFrame(frame);

                // write frame
                using (Stream fileStream = File.Open("sensor.frame", FileMode.Create))
                using (var writer = new BinaryWriter(fileStream))
                {
                    // stream properties
                    //writer.Write(hFov);
                    //writer.Write(vFov);
                    //writer.Write(minValue);
                    //writer.Write(maxValue);
                    //writer.Write(videoMode.PixelFormat.BytesPerPixel());

                    //// frame properties
                    //writer.Write(frame.CroppingEnabled);
                    //writer.Write(frame.CropOriginX);
                    //writer.Write(frame.CropOriginY);
                    //writer.Write(frame.Width);
                    //writer.Write(frame.Height);
                    //writer.Write(frame.Stride);
                    writer.Write(frame.Data.Size);

                    // data
                    using (var dataStream = frame.Data.CreateStream())
                    {
                        dataStream.CopyTo(fileStream);
                    }

                    fileStream.Flush();
                }
            }
        }

        private static void DescribeVideoModes(SensorInfo sensorInfo)
        {
            foreach (var videoMode in sensorInfo.VideoModes)
                Console.WriteLine("{0} {1}x{2} @ {3} fps.", videoMode.PixelFormat, videoMode.ResolutionX, videoMode.ResolutionY, videoMode.Fps);
        }

        public static void DescribeSensor(SensorInfo sensorInfo)
        {
            if (sensorInfo.IsSupported)
                Console.WriteLine("{0} sensor has {1} mode(s).", sensorInfo.SensorType, sensorInfo.VideoModes.Length);
            else
                Console.WriteLine("{0} sensor is not supported.", sensorInfo.SensorType);
        }

        public static void DescribeFrame(SensorFrame frame)
        {
            Console.WriteLine("Sensor type: {0}", frame.SensorType);
            Console.WriteLine("Timestamp: {0}", frame.Timestamp);
            Console.WriteLine("Index: {0}", frame.FrameIndex);
            Console.WriteLine("Video Mode: {0}, {1} byte(s) pps, {2}x{3} @ {4} fps.",
                frame.VideoMode.PixelFormat,
                frame.VideoMode.PixelFormat.BytesPerPixel(),
                frame.VideoMode.ResolutionX, frame.VideoMode.ResolutionY,
                frame.VideoMode.Fps);
            Console.WriteLine("Clipping: {0}", frame.CroppingEnabled);
            Console.WriteLine("Crop: x - {0}, y - {1}", frame.CropOriginX, frame.CropOriginY);
            Console.WriteLine("Stride: {0}", frame.Stride);
            Console.WriteLine("Data size: {0} byte(s)", frame.Data.Size);
        }
    }
}
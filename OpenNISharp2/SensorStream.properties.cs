using OpenNISharp2.Native;

namespace OpenNISharp2
{
    partial class SensorStream
    {
        public bool IsCroppingPropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_HORIZONTAL_FOV);

        public Cropping Cropping
        {
            get => GetProperty<OniCropping>(OniCAPI.ONI_STREAM_PROPERTY_CROPPING).ToManaged();
            set => SetProperty(OniCAPI.ONI_STREAM_PROPERTY_CROPPING, value.ToNative());
        }

        public bool IsHorizontalFovPropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_HORIZONTAL_FOV);

        public float HorizontalFov => GetProperty<float>(OniCAPI.ONI_STREAM_PROPERTY_HORIZONTAL_FOV);

        public bool IsVerticalFovPropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_VERTICAL_FOV);

        public float VerticalFov => GetProperty<float>(OniCAPI.ONI_STREAM_PROPERTY_VERTICAL_FOV);

        public bool IsVideoModePropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_VIDEO_MODE);

        public VideoMode VideoMode
        {
            get => GetProperty<OniVideoMode>(OniCAPI.ONI_STREAM_PROPERTY_VIDEO_MODE).ToManaged();
            set => SetProperty(OniCAPI.ONI_STREAM_PROPERTY_VIDEO_MODE, value.ToNative());
        }

        public bool IsMaxValuePropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_MAX_VALUE);

        public int MaxValue => GetProperty<int>(OniCAPI.ONI_STREAM_PROPERTY_MAX_VALUE);

        public bool IsMinValuePropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_MIN_VALUE);

        public int MinValue => GetProperty<int>(OniCAPI.ONI_STREAM_PROPERTY_MIN_VALUE);

        public bool IsStridePropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_STRIDE);

        public int Stride => GetProperty<int>(OniCAPI.ONI_STREAM_PROPERTY_STRIDE);

        public bool IsMirroringPropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_MIRRORING);

        public bool Mirroring
        {
            get => GetProperty<int>(OniCAPI.ONI_STREAM_PROPERTY_MIRRORING) == 1;
            set => SetProperty(OniCAPI.ONI_STREAM_PROPERTY_MIRRORING, value ? 1 : 0);
        }

        public bool IsNumberOfFramesPropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_NUMBER_OF_FRAMES);

        public int NumberOfFrames
        {
            get => GetProperty<int>(OniCAPI.ONI_STREAM_PROPERTY_NUMBER_OF_FRAMES);
            set => SetProperty(OniCAPI.ONI_STREAM_PROPERTY_NUMBER_OF_FRAMES, value);
        }

        // Camera

        public bool IsAutoWhiteBalancePropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_AUTO_WHITE_BALANCE);

        public bool AutoWhiteBalance
        {
            get => GetProperty<int>(OniCAPI.ONI_STREAM_PROPERTY_AUTO_WHITE_BALANCE) == 1;
            set => SetProperty(OniCAPI.ONI_STREAM_PROPERTY_AUTO_WHITE_BALANCE, value ? 1 : 0);
        }

        public bool IsAutoExposurePropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_AUTO_EXPOSURE);

        public bool AutoExposure
        {
            get => GetProperty<int>(OniCAPI.ONI_STREAM_PROPERTY_AUTO_EXPOSURE) == 1;
            set => SetProperty(OniCAPI.ONI_STREAM_PROPERTY_AUTO_EXPOSURE, value ? 1 : 0);
        }

        public bool IsExposurePropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_EXPOSURE);

        public int Exposure
        {
            get => GetProperty<int>(OniCAPI.ONI_STREAM_PROPERTY_EXPOSURE);
            set => SetProperty(OniCAPI.ONI_STREAM_PROPERTY_EXPOSURE, value);
        }

        public bool IsGainPropertySupported => IsPropertySupported(OniCAPI.ONI_STREAM_PROPERTY_GAIN);

        public int Gain
        {
            get => GetProperty<int>(OniCAPI.ONI_STREAM_PROPERTY_GAIN);
            set => SetProperty(OniCAPI.ONI_STREAM_PROPERTY_GAIN, value);
        }
    }
}
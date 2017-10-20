using System;
using System.Security;
using System.Runtime.InteropServices;

namespace OpenNISharp2.Native
{
    internal enum OniDeviceState : int
    {
        @ONI_DEVICE_STATE_OK = 0,
        @ONI_DEVICE_STATE_ERROR = 1,
        @ONI_DEVICE_STATE_NOT_READY = 2,
        @ONI_DEVICE_STATE_EOF = 3,
    }
    
    internal enum OniImageRegistrationMode : int
    {
        @ONI_IMAGE_REGISTRATION_OFF = 0,
        @ONI_IMAGE_REGISTRATION_DEPTH_TO_COLOR = 1,
    }
    
    /// <summary>All available formats of the output of a stream</summary>
    internal enum OniPixelFormat : int
    {
        @ONI_PIXEL_FORMAT_DEPTH_1_MM = 100,
        @ONI_PIXEL_FORMAT_DEPTH_100_UM = 101,
        @ONI_PIXEL_FORMAT_SHIFT_9_2 = 102,
        @ONI_PIXEL_FORMAT_SHIFT_9_3 = 103,
        @ONI_PIXEL_FORMAT_RGB888 = 200,
        @ONI_PIXEL_FORMAT_YUV422 = 201,
        @ONI_PIXEL_FORMAT_GRAY8 = 202,
        @ONI_PIXEL_FORMAT_GRAY16 = 203,
        @ONI_PIXEL_FORMAT_JPEG = 204,
        @ONI_PIXEL_FORMAT_YUYV = 205,
    }
    
    /// <summary>The source of the stream</summary>
    internal enum OniSensorType : int
    {
        @ONI_SENSOR_IR = 1,
        @ONI_SENSOR_COLOR = 2,
        @ONI_SENSOR_DEPTH = 3,
    }
    
    /// <summary>Possible failure values</summary>
    internal enum OniStatus : int
    {
        @ONI_STATUS_OK = 0,
        @ONI_STATUS_ERROR = 1,
        @ONI_STATUS_NOT_IMPLEMENTED = 2,
        @ONI_STATUS_NOT_SUPPORTED = 3,
        @ONI_STATUS_BAD_PARAMETER = 4,
        @ONI_STATUS_OUT_OF_FLOW = 5,
        @ONI_STATUS_NO_DEVICE = 6,
        @ONI_STATUS_TIME_OUT = 102,
    }
    
    internal enum XnBistError : int
    {
        @XN_BIST_RAM_TEST_FAILURE = 1,
        @XN_BIST_IR_CMOS_CONTROL_BUS_FAILURE = 2,
        @XN_BIST_IR_CMOS_DATA_BUS_FAILURE = 4,
        @XN_BIST_IR_CMOS_BAD_VERSION = 8,
        @XN_BIST_IR_CMOS_RESET_FAILUE = 16,
        @XN_BIST_IR_CMOS_TRIGGER_FAILURE = 32,
        @XN_BIST_IR_CMOS_STROBE_FAILURE = 64,
        @XN_BIST_COLOR_CMOS_CONTROL_BUS_FAILURE = 128,
        @XN_BIST_COLOR_CMOS_DATA_BUS_FAILURE = 256,
        @XN_BIST_COLOR_CMOS_BAD_VERSION = 512,
        @XN_BIST_COLOR_CMOS_RESET_FAILUE = 1024,
        @XN_BIST_FLASH_WRITE_LINE_FAILURE = 2048,
        @XN_BIST_FLASH_TEST_FAILURE = 4096,
        @XN_BIST_POTENTIOMETER_CONTROL_BUS_FAILURE = 8192,
        @XN_BIST_POTENTIOMETER_FAILURE = 16384,
        @XN_BIST_AUDIO_TEST_FAILURE = 32768,
        @XN_BIST_PROJECTOR_TEST_LD_FAIL = 65536,
        @XN_BIST_PROJECTOR_TEST_LD_FAILSAFE_TRIG_FAIL = 131072,
        @XN_BIST_PROJECTOR_TEST_FAILSAFE_HIGH_FAIL = 262144,
        @XN_BIST_PROJECTOR_TEST_FAILSAFE_LOW_FAIL = 524288,
        @XN_TEC_TEST_HEATER_CROSSED = 1048576,
        @XN_TEC_TEST_HEATER_DISCONNETED = 2097152,
        @XN_TEC_TEST_TEC_CROSSED = 4194304,
        @XN_TEC_TEST_TEC_FAULT = 8388608,
    }
    
    internal enum XnBistType : int
    {
        @XN_BIST_IMAGE_CMOS = 1,
        @XN_BIST_IR_CMOS = 2,
        @XN_BIST_POTENTIOMETER = 4,
        @XN_BIST_FLASH = 8,
        @XN_BIST_FULL_FLASH = 16,
        @XN_BIST_PROJECTOR_TEST_MASK = 32,
        @XN_BIST_TEC_TEST_MASK = 64,
        @XN_BIST_NESA_TEST_MASK = 128,
        @XN_BIST_NESA_UNLIMITED_TEST_MASK = 256,
        @XN_BIST_ALL = -385,
    }
    
    internal enum XnBootErrorCode : int
    {
        @XN_BOOT_OK = 0,
        @XN_BOOT_BAD_CRC = 1,
        @XN_BOOT_UPLOAD_IN_PROGRESS = 2,
        @XN_BOOT_FW_LOAD_FAILED = 3,
    }
    
    internal enum XnChipVer : int
    {
        @XN_SENSOR_CHIP_VER_UNKNOWN = 0,
        @XN_SENSOR_CHIP_VER_PS1000 = 1,
        @XN_SENSOR_CHIP_VER_PS1080 = 2,
        @XN_SENSOR_CHIP_VER_PS1080A6 = 3,
    }
    
    internal enum XnCMOSType : int
    {
        @XN_CMOS_TYPE_IMAGE = 0,
        @XN_CMOS_TYPE_DEPTH = 1,
        @XN_CMOS_COUNT = 2,
    }
    
    internal enum XnCroppingMode : int
    {
        @XN_CROPPING_MODE_NORMAL = 1,
        @XN_CROPPING_MODE_INCREASED_FPS = 2,
        @XN_CROPPING_MODE_SOFTWARE_ONLY = 3,
    }
    
    internal enum XnDepthCMOSType : int
    {
        @XN_DEPTH_CMOS_NONE = 0,
        @XN_DEPTH_CMOS_MT9M001 = 1,
        @XN_DEPTH_CMOS_AR130 = 2,
    }
    
    internal enum XnFilePossibleAttributes : int
    {
        @XnFileAttributeReadOnly = 32768,
    }
    
    internal enum XnFileZone : int
    {
        @XN_ZONE_FACTORY = 0,
        @XN_ZONE_UPDATE = 1,
    }
    
    internal enum XnFirmwareCroppingMode : int
    {
        @XN_FIRMWARE_CROPPING_MODE_DISABLED = 0,
        @XN_FIRMWARE_CROPPING_MODE_NORMAL = 1,
        @XN_FIRMWARE_CROPPING_MODE_INCREASED_FPS = 2,
    }
    
    internal enum XnFlashFileType : int
    {
        @XnFlashFileTypeFileTable = 0,
        @XnFlashFileTypeScratchFile = 1,
        @XnFlashFileTypeBootSector = 2,
        @XnFlashFileTypeBootManager = 3,
        @XnFlashFileTypeCodeDownloader = 4,
        @XnFlashFileTypeMonitor = 5,
        @XnFlashFileTypeApplication = 6,
        @XnFlashFileTypeFixedParams = 7,
        @XnFlashFileTypeDescriptors = 8,
        @XnFlashFileTypeDefaultParams = 9,
        @XnFlashFileTypeImageCmos = 10,
        @XnFlashFileTypeDepthCmos = 11,
        @XnFlashFileTypeAlgorithmParams = 12,
        @XnFlashFileTypeReferenceQVGA = 13,
        @XnFlashFileTypeReferenceVGA = 14,
        @XnFlashFileTypeMaintenance = 15,
        @XnFlashFileTypeDebugParams = 16,
        @XnFlashFileTypePrimeProcessor = 17,
        @XnFlashFileTypeGainControl = 18,
        @XnFlashFileTypeRegistartionParams = 19,
        @XnFlashFileTypeIDParams = 20,
        @XnFlashFileTypeSensorTECParams = 21,
        @XnFlashFileTypeSensorAPCParams = 22,
        @XnFlashFileTypeSensorProjectorFaultParams = 23,
        @XnFlashFileTypeProductionFile = 24,
        @XnFlashFileTypeUpgradeInProgress = 25,
        @XnFlashFileTypeWavelengthCorrection = 26,
        @XnFlashFileTypeGMCReferenceOffset = 27,
        @XnFlashFileTypeSensorNESAParams = 28,
        @XnFlashFileTypeSensorFault = 29,
        @XnFlashFileTypeVendorData = 30,
    }
    
    internal enum XnFwCompressionType : int
    {
        @XN_FW_COMPRESSION_NONE = 0,
        @XN_FW_COMPRESSION_8Z = 1,
        @XN_FW_COMPRESSION_16Z = 2,
        @XN_FW_COMPRESSION_24Z = 3,
        @XN_FW_COMPRESSION_6_BIT_PACKED = 4,
        @XN_FW_COMPRESSION_10_BIT_PACKED = 5,
        @XN_FW_COMPRESSION_11_BIT_PACKED = 6,
        @XN_FW_COMPRESSION_12_BIT_PACKED = 7,
    }
    
    internal enum XnFwFileFlags : int
    {
        @XN_FILE_FLAG_BAD_CRC = 1,
    }
    
    internal enum XnFwPixelFormat : int
    {
        @XN_FW_PIXEL_FORMAT_NONE = 0,
        @XN_FW_PIXEL_FORMAT_SHIFTS_9_3 = 1,
        @XN_FW_PIXEL_FORMAT_GRAYSCALE16 = 2,
        @XN_FW_PIXEL_FORMAT_YUV422 = 3,
        @XN_FW_PIXEL_FORMAT_BAYER8 = 4,
    }
    
    internal enum XnFwStreamType : int
    {
        @XN_FW_STREAM_TYPE_COLOR = 1,
        @XN_FW_STREAM_TYPE_IR = 2,
        @XN_FW_STREAM_TYPE_SHIFTS = 3,
        @XN_FW_STREAM_TYPE_AUDIO = 4,
        @XN_FW_STREAM_TYPE_DY = 5,
        @XN_FW_STREAM_TYPE_LOG = 8,
    }
    
    internal enum XnFWVer : int
    {
        @XN_SENSOR_FW_VER_UNKNOWN = 0,
        @XN_SENSOR_FW_VER_0_17 = 1,
        @XN_SENSOR_FW_VER_1_1 = 2,
        @XN_SENSOR_FW_VER_1_2 = 3,
        @XN_SENSOR_FW_VER_3_0 = 4,
        @XN_SENSOR_FW_VER_4_0 = 5,
        @XN_SENSOR_FW_VER_5_0 = 6,
        @XN_SENSOR_FW_VER_5_1 = 7,
        @XN_SENSOR_FW_VER_5_2 = 8,
        @XN_SENSOR_FW_VER_5_3 = 9,
        @XN_SENSOR_FW_VER_5_4 = 10,
        @XN_SENSOR_FW_VER_5_5 = 11,
        @XN_SENSOR_FW_VER_5_6 = 12,
        @XN_SENSOR_FW_VER_5_7 = 13,
        @XN_SENSOR_FW_VER_5_8 = 14,
    }
    
    internal enum XnHWVer : int
    {
        @XN_SENSOR_HW_VER_UNKNOWN = 0,
        @XN_SENSOR_HW_VER_FPDB_10 = 1,
        @XN_SENSOR_HW_VER_CDB_10 = 2,
        @XN_SENSOR_HW_VER_RD_3 = 3,
        @XN_SENSOR_HW_VER_RD_5 = 4,
        @XN_SENSOR_HW_VER_RD1081 = 5,
        @XN_SENSOR_HW_VER_RD1082 = 6,
        @XN_SENSOR_HW_VER_RD109 = 7,
    }
    
    internal enum XnImageCMOSType : int
    {
        @XN_IMAGE_CMOS_NONE = 0,
        @XN_IMAGE_CMOS_MT9M112 = 1,
        @XN_IMAGE_CMOS_MT9D131 = 2,
        @XN_IMAGE_CMOS_MT9M114 = 3,
    }
    
    internal enum XnIODepthFormats : int
    {
        @XN_IO_DEPTH_FORMAT_UNCOMPRESSED_16_BIT = 0,
        @XN_IO_DEPTH_FORMAT_COMPRESSED_PS = 1,
        @XN_IO_DEPTH_FORMAT_UNCOMPRESSED_10_BIT = 2,
        @XN_IO_DEPTH_FORMAT_UNCOMPRESSED_11_BIT = 3,
        @XN_IO_DEPTH_FORMAT_UNCOMPRESSED_12_BIT = 4,
    }
    
    internal enum XnIOImageFormats : int
    {
        @XN_IO_IMAGE_FORMAT_BAYER = 0,
        @XN_IO_IMAGE_FORMAT_YUV422 = 1,
        @XN_IO_IMAGE_FORMAT_JPEG = 2,
        @XN_IO_IMAGE_FORMAT_JPEG_420 = 3,
        @XN_IO_IMAGE_FORMAT_JPEG_MONO = 4,
        @XN_IO_IMAGE_FORMAT_UNCOMPRESSED_YUV422 = 5,
        @XN_IO_IMAGE_FORMAT_UNCOMPRESSED_BAYER = 6,
        @XN_IO_IMAGE_FORMAT_UNCOMPRESSED_YUYV = 7,
    }
    
    internal enum XnLogFilter : int
    {
        @XnLogFilterDebug = 1,
        @XnLogFilterInfo = 2,
        @XnLogFilterError = 4,
        @XnLogFilterProtocol = 8,
        @XnLogFilterAssert = 16,
        @XnLogFilterConfig = 32,
        @XnLogFilterFrameSync = 64,
        @XnLogFilterAGC = 128,
        @XnLogFilterTelems = 256,
        @XnLogFilterAll = 65535,
    }
    
    internal enum XnParamResetType : int
    {
        @XN_RESET_TYPE_POWER = 0,
        @XN_RESET_TYPE_SOFT = 1,
        @XN_RESET_TYPE_SOFT_FIRST = 2,
    }
    
    internal enum XnProcessingType : int
    {
        @XN_PROCESSING_DONT_CARE = 0,
        @XN_PROCESSING_HARDWARE = 1,
        @XN_PROCESSING_SOFTWARE = 2,
    }
    
    internal enum XnSensorUsbInterface : int
    {
        @XN_SENSOR_USB_INTERFACE_DEFAULT = 0,
        @XN_SENSOR_USB_INTERFACE_ISO_ENDPOINTS = 1,
        @XN_SENSOR_USB_INTERFACE_BULK_ENDPOINTS = 2,
        @XN_SENSOR_USB_INTERFACE_ISO_ENDPOINTS_LOW_DEPTH = 3,
    }
    
    internal enum XnSensorVer : int
    {
        @XN_SENSOR_VER_UNKNOWN = 0,
        @XN_SENSOR_VER_2_0 = 1,
        @XN_SENSOR_VER_3_0 = 2,
        @XN_SENSOR_VER_4_0 = 3,
        @XN_SENSOR_VER_5_0 = 4,
    }
    
    internal enum XnUsbInterfaceType : int
    {
        @PS_USB_INTERFACE_DONT_CARE = 0,
        @PS_USB_INTERFACE_ISO_ENDPOINTS = 1,
        @PS_USB_INTERFACE_BULK_ENDPOINTS = 2,
    }
    
}

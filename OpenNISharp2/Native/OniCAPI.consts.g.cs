using System;
using System.Security;
using System.Runtime.InteropServices;

namespace OpenNISharp2.Native
{
    public unsafe static partial class OniCAPI
    {
        /// <summary>** Device commands ***</summary>
        internal const int LINK_COMMAND_CREATE_FW_STREAM = 302051330;
        
        /// <summary>** Device commands ***</summary>
        internal const int LINK_COMMAND_DESTROY_FW_STREAM = 302051331;
        
        /// <summary>** Device commands ***</summary>
        internal const int LINK_COMMAND_GET_FW_STREAM_LIST = 302051329;
        
        /// <summary>** Device commands ***</summary>
        internal const int LINK_COMMAND_GET_FW_STREAM_VIDEO_MODE = 302051336;
        
        /// <summary>** Device commands ***</summary>
        internal const int LINK_COMMAND_GET_FW_STREAM_VIDEO_MODE_LIST = 302051334;
        
        /// <summary>** Device commands ***</summary>
        internal const int LINK_COMMAND_SET_FW_STREAM_VIDEO_MODE = 302051335;
        
        /// <summary>** Device commands ***</summary>
        internal const int LINK_COMMAND_START_FW_STREAM = 302051332;
        
        /// <summary>** Device commands ***</summary>
        internal const int LINK_COMMAND_STOP_FW_STREAM = 302051333;
        
        /// <summary>** Device properties ***</summary>
        internal const int LINK_PROP_BOOT_STATUS = 301989899;
        
        /// <summary>** Stream properties ***</summary>
        internal const int LINK_PROP_COMPRESSION = 301993986;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_CONST_SHIFT = 301998083;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_DEPTH_SCALE = 301989899;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_DEPTH_TO_SHIFT_TABLE = 301998090;
        
        /// <summary>** Device properties ***</summary>
        internal const int LINK_PROP_EMITTER_ACTIVE = 301989896;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_EMITTER_DEPTH_CMOS_DISTANCE = 301998088;
        
        /// <summary>** Device properties ***</summary>
        internal const int LINK_PROP_FW_VERSION = 301989889;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_MAX_SHIFT = 301998081;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_PARAM_COEFF = 301998084;
        
        /// <summary>** Stream properties ***</summary>
        internal const int LINK_PROP_PIXEL_FORMAT = 301993985;
        
        /// <summary>** Device properties ***</summary>
        internal const int LINK_PROP_PRESET_FILE = 301989898;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_SHIFT_SCALE = 301998085;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_SHIFT_TO_DEPTH_TABLE = 301998089;
        
        /// <summary>** Device properties ***</summary>
        internal const int LINK_PROP_VERSIONS_INFO = 301989891;
        
        /// <summary>** Device properties ***</summary>
        internal const int LINK_PROP_VERSIONS_INFO_COUNT = 301989890;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_ZERO_PLANE_DISTANCE = 301998082;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_ZERO_PLANE_OUTPUT_PIXEL_SIZE = 301998087;
        
        /// <summary>** Depth Stream properties ***</summary>
        internal const int LINK_PROP_ZERO_PLANE_PIXEL_SIZE = 301998086;
        
        internal const int ONI_DEVICE_COMMAND_SEEK = 1;
        
        internal const int ONI_DEVICE_PROPERTY_DRIVER_VERSION = 1;
        
        internal const int ONI_DEVICE_PROPERTY_ERROR_STATE = 4;
        
        internal const int ONI_DEVICE_PROPERTY_FIRMWARE_VERSION = 0;
        
        internal const int ONI_DEVICE_PROPERTY_HARDWARE_VERSION = 2;
        
        internal const int ONI_DEVICE_PROPERTY_IMAGE_REGISTRATION = 5;
        
        internal const int ONI_DEVICE_PROPERTY_PLAYBACK_REPEAT_ENABLED = 101;
        
        internal const int ONI_DEVICE_PROPERTY_PLAYBACK_SPEED = 100;
        
        internal const int ONI_DEVICE_PROPERTY_SERIAL_NUMBER = 3;
        
        internal const int ONI_STREAM_PROPERTY_AUTO_EXPOSURE = 101;
        
        internal const int ONI_STREAM_PROPERTY_AUTO_WHITE_BALANCE = 100;
        
        internal const int ONI_STREAM_PROPERTY_CROPPING = 0;
        
        internal const int ONI_STREAM_PROPERTY_EXPOSURE = 102;
        
        internal const int ONI_STREAM_PROPERTY_GAIN = 103;
        
        internal const int ONI_STREAM_PROPERTY_HORIZONTAL_FOV = 1;
        
        internal const int ONI_STREAM_PROPERTY_MAX_VALUE = 4;
        
        internal const int ONI_STREAM_PROPERTY_MIN_VALUE = 5;
        
        internal const int ONI_STREAM_PROPERTY_MIRRORING = 7;
        
        internal const int ONI_STREAM_PROPERTY_NUMBER_OF_FRAMES = 8;
        
        internal const int ONI_STREAM_PROPERTY_STRIDE = 6;
        
        internal const int ONI_STREAM_PROPERTY_VERTICAL_FOV = 2;
        
        internal const int ONI_STREAM_PROPERTY_VIDEO_MODE = 3;
        
        internal const int ONI_TIMEOUT_FOREVER = -1;
        
        internal const int ONI_TIMEOUT_NONE = 0;
        
        internal const int PS_COMMAND_AHB_READ = 489152513;
        
        internal const int PS_COMMAND_AHB_WRITE = 489152514;
        
        internal const int PS_COMMAND_BEGIN_FIRMWARE_UPDATE = 489152519;
        
        internal const int PS_COMMAND_DOWNLOAD_FILE = 489152522;
        
        internal const int PS_COMMAND_DUMP_ENDPOINT = 489152525;
        
        internal const int PS_COMMAND_END_FIRMWARE_UPDATE = 489152520;
        
        internal const int PS_COMMAND_EXECUTE_BIST = 489152528;
        
        internal const int PS_COMMAND_FORMAT_ZONE = 489152524;
        
        internal const int PS_COMMAND_GET_BIST_LIST = 489152527;
        
        internal const int PS_COMMAND_GET_FILE_LIST = 489152523;
        
        internal const int PS_COMMAND_GET_I2C_DEVICE_LIST = 489152526;
        
        internal const int PS_COMMAND_GET_LOG_MASK_LIST = 489152530;
        
        internal const int PS_COMMAND_I2C_READ = 489152515;
        
        internal const int PS_COMMAND_I2C_WRITE = 489152516;
        
        internal const int PS_COMMAND_POWER_RESET = 489152518;
        
        internal const int PS_COMMAND_SET_LOG_MASK_STATE = 489152531;
        
        internal const int PS_COMMAND_SOFT_RESET = 489152517;
        
        internal const int PS_COMMAND_START_LOG = 489152532;
        
        internal const int PS_COMMAND_STOP_LOG = 489152533;
        
        internal const int PS_COMMAND_UPLOAD_FILE = 489152521;
        
        internal const int PS_COMMAND_USB_TEST = 489152529;
        
        internal const int PS_PROPERTY_DUMP_DATA = 489095169;
        
        internal const int PS_PROPERTY_USB_INTERFACE = 489156609;
        
        internal const int XN_ERROR_STATE_DEVICE_OVERHEAT = 2;
        
        internal const int XN_ERROR_STATE_DEVICE_PROJECTOR_FAULT = 1;
        
        internal const int XN_ERROR_STATE_OK = 0;
        
        /// <summary>XnAHBData</summary>
        internal const int XN_MODULE_PROPERTY_AHB = 276881413;
        
        /// <summary>Boolean, set only</summary>
        internal const int XN_MODULE_PROPERTY_APC_ENABLED = 276889489;
        
        /// <summary>Integer, set only</summary>
        internal const int XN_MODULE_PROPERTY_BIST = 276889487;
        
        /// <summary>Boolean</summary>
        internal const int XN_MODULE_PROPERTY_CLOSE_STREAMS_ON_SHUTDOWN = 276889464;
        
        /// <summary>XnCmosBlankingTime</summary>
        internal const int XN_MODULE_PROPERTY_CMOS_BLANKING_TIME = 276889461;
        
        /// <summary>XnCmosBlankingUnits</summary>
        internal const int XN_MODULE_PROPERTY_CMOS_BLANKING_UNITS = 276889460;
        
        /// <summary>Integer</summary>
        internal const int XN_MODULE_PROPERTY_DELETE_FILE = 276889479;
        
        /// <summary>XnControlProcessingData</summary>
        internal const int XN_MODULE_PROPERTY_DEPTH_CONTROL = 276881412;
        
        /// <summary>get only</summary>
        internal const int XN_MODULE_PROPERTY_EMITTER_SET_POINT = 276889484;
        
        /// <summary>Boolean</summary>
        internal const int XN_MODULE_PROPERTY_EMITTER_STATE = 276881415;
        
        /// <summary>get only</summary>
        internal const int XN_MODULE_PROPERTY_EMITTER_STATUS = 276889485;
        
        /// <summary>XnParamFlashData, get only</summary>
        internal const int XN_MODULE_PROPERTY_FILE = 276889478;
        
        /// <summary>Integer</summary>
        internal const int XN_MODULE_PROPERTY_FILE_ATTRIBUTES = 276889480;
        
        /// <summary>XnFlashFileList, get only</summary>
        internal const int XN_MODULE_PROPERTY_FILE_LIST = 276889476;
        
        /// <summary>Integer</summary>
        internal const int XN_MODULE_PROPERTY_FIRMWARE_CPU_INTERVAL = 276889475;
        
        /// <summary>Boolean</summary>
        internal const int XN_MODULE_PROPERTY_FIRMWARE_FRAME_SYNC = 276885512;
        
        /// <summary>String, get only</summary>
        internal const int XN_MODULE_PROPERTY_FIRMWARE_LOG = 276889474;
        
        /// <summary>Integer</summary>
        internal const int XN_MODULE_PROPERTY_FIRMWARE_LOG_FILTER = 276889473;
        
        /// <summary>Integer</summary>
        internal const int XN_MODULE_PROPERTY_FIRMWARE_LOG_INTERVAL = 276889471;
        
        /// <summary>XnInnerParam</summary>
        internal const int XN_MODULE_PROPERTY_FIRMWARE_PARAM = 276881409;
        
        /// <summary>Boolean</summary>
        internal const int XN_MODULE_PROPERTY_FIRMWARE_TEC_DEBUG_PRINT = 276889490;
        
        /// <summary>XnParamFlashData, get only</summary>
        internal const int XN_MODULE_PROPERTY_FLASH_CHUNK = 276889477;
        
        /// <summary>Boolean</summary>
        internal const int XN_MODULE_PROPERTY_HOST_TIMESTAMPS = 276889463;
        
        /// <summary>get only</summary>
        internal const int XN_MODULE_PROPERTY_I2C = 276889486;
        
        /// <summary>XnControlProcessingData</summary>
        internal const int XN_MODULE_PROPERTY_IMAGE_CONTROL = 276881411;
        
        /// <summary>unsigned long long, get only</summary>
        internal const int XN_MODULE_PROPERTY_LEAN_INIT = 276885509;
        
        /// <summary>XnLedState</summary>
        internal const int XN_MODULE_PROPERTY_LED_STATE = 276881414;
        
        /// <summary>Boolean</summary>
        internal const int XN_MODULE_PROPERTY_MIRROR = 276885506;
        
        /// <summary>String, get only</summary>
        internal const int XN_MODULE_PROPERTY_PHYSICAL_DEVICE_NAME = 276889466;
        
        /// <summary>Boolean</summary>
        internal const int XN_MODULE_PROPERTY_PRINT_FIRMWARE_LOG = 276889472;
        
        /// <summary>XnProjectorFaultData, set only</summary>
        internal const int XN_MODULE_PROPERTY_PROJECTOR_FAULT = 276889488;
        
        /// <summary>unsigned long long, set only</summary>
        internal const int XN_MODULE_PROPERTY_RESET = 276881410;
        
        /// <summary>unsigned long long, get only</summary>
        internal const int XN_MODULE_PROPERTY_RESET_SENSOR_ON_STARTUP = 276885508;
        
        /// <summary>String, get only</summary>
        internal const int XN_MODULE_PROPERTY_SENSOR_PLATFORM_STRING = 276889468;
        
        /// <summary>char[XN_DEVICE_MAX_STRING_LENGTH], get only</summary>
        internal const int XN_MODULE_PROPERTY_SERIAL_NUMBER = 276885510;
        
        /// <summary>get only</summary>
        internal const int XN_MODULE_PROPERTY_TEC_FAST_CONVERGENCE_STATUS = 276889483;
        
        /// <summary>Integer</summary>
        internal const int XN_MODULE_PROPERTY_TEC_SET_POINT = 276889481;
        
        /// <summary>get only</summary>
        internal const int XN_MODULE_PROPERTY_TEC_STATUS = 276889482;
        
        /// <summary>unsigned long long (XnSensorUsbInterface)</summary>
        internal const int XN_MODULE_PROPERTY_USB_INTERFACE = 276885505;
        
        /// <summary>String, get only</summary>
        internal const int XN_MODULE_PROPERTY_VENDOR_SPECIFIC_DATA = 276889467;
        
        /// <summary>XnVersions, get only</summary>
        internal const int XN_MODULE_PROPERTY_VERSION = 276885511;
        
        /// <summary>XnDepthAGCBin*</summary>
        internal const int XN_STREAM_PROPERTY_AGC_BIN = 276828166;
        
        /// <summary>unsigned long long</summary>
        internal const int XN_STREAM_PROPERTY_CLOSE_RANGE = 276885507;
        
        /// <summary>unsigned long long, get only</summary>
        internal const int XN_STREAM_PROPERTY_CONST_SHIFT = 276828167;
        
        /// <summary>unsigned long long (XnCroppingMode)</summary>
        internal const int XN_STREAM_PROPERTY_CROPPING_MODE = 276824066;
        
        /// <summary>unsigned short[], get only</summary>
        internal const int XN_STREAM_PROPERTY_D2S_TABLE = 276828177;
        
        /// <summary>double, get only</summary>
        internal const int XN_STREAM_PROPERTY_DCMOS_RCMOS_DISTANCE = 276828175;
        
        /// <summary>get only</summary>
        internal const int XN_STREAM_PROPERTY_DEPTH_SENSOR_CALIBRATION_INFO = 276828178;
        
        /// <summary>double, get only</summary>
        internal const int XN_STREAM_PROPERTY_EMITTER_DCMOS_DISTANCE = 276828174;
        
        /// <summary>****************************************************************</summary>
        internal const int XN_STREAM_PROPERTY_FLICKER = 276832257;
        
        /// <summary>unsigned long long</summary>
        internal const int XN_STREAM_PROPERTY_GAIN = 276828163;
        
        /// <summary>Boolean</summary>
        internal const int XN_STREAM_PROPERTY_GMC_DEBUG = 276889413;
        
        /// <summary>Boolean</summary>
        internal const int XN_STREAM_PROPERTY_GMC_MODE = 276889412;
        
        /// <summary>unsigned long long</summary>
        internal const int XN_STREAM_PROPERTY_HOLE_FILTER = 276828164;
        
        /// <summary>unsigned long long</summary>
        internal const int XN_STREAM_PROPERTY_INPUT_FORMAT = 276824065;
        
        /// <summary>unsigned long long, get only</summary>
        internal const int XN_STREAM_PROPERTY_MAX_SHIFT = 276828169;
        
        /// <summary>unsigned long long, get only</summary>
        internal const int XN_STREAM_PROPERTY_PARAM_COEFF = 276828170;
        
        /// <summary>XnPixelRegistration - get only</summary>
        internal const int XN_STREAM_PROPERTY_PIXEL_REGISTRATION = 276828161;
        
        /// <summary>unsigned long long, get only</summary>
        internal const int XN_STREAM_PROPERTY_PIXEL_SIZE_FACTOR = 276828168;
        
        /// <summary>unsigned long long (XnProcessingType)</summary>
        internal const int XN_STREAM_PROPERTY_REGISTRATION_TYPE = 276828165;
        
        /// <summary>OniDepthPixel[], get only</summary>
        internal const int XN_STREAM_PROPERTY_S2D_TABLE = 276828176;
        
        /// <summary>unsigned long long, get only</summary>
        internal const int XN_STREAM_PROPERTY_SHIFT_SCALE = 276828171;
        
        /// <summary>Boolean</summary>
        internal const int XN_STREAM_PROPERTY_WAVELENGTH_CORRECTION = 276889414;
        
        /// <summary>Boolean</summary>
        internal const int XN_STREAM_PROPERTY_WAVELENGTH_CORRECTION_DEBUG = 276889415;
        
        /// <summary>unsigned long long</summary>
        internal const int XN_STREAM_PROPERTY_WHITE_BALANCE_ENABLED = 276828162;
        
        /// <summary>unsigned long long, get only</summary>
        internal const int XN_STREAM_PROPERTY_ZERO_PLANE_DISTANCE = 276828172;
        
        /// <summary>double, get only</summary>
        internal const int XN_STREAM_PROPERTY_ZERO_PLANE_PIXEL_SIZE = 276828173;
        
    }
}

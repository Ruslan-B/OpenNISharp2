using System;
using System.Runtime.InteropServices;

namespace OpenNISharp2.Native
{
    /// <summary>Holds an OpenNI version number, which consists of four separate numbers in the format: major.minor.maintenance.build. For example: 2.0.0.20.</summary>
    internal unsafe struct OniVersion
    {
        /// <summary>Major version number, incremented for major API restructuring.</summary>
        public int @major;
        /// <summary>Minor version number, incremented when significant new features added.</summary>
        public int @minor;
        /// <summary>Maintenance build number, incremented for new releases that primarily provide minor bug fixes.</summary>
        public int @maintenance;
        /// <summary>Build number. Incremented for each new API build. Generally not shown on the installer and download site.</summary>
        public int @build;
    }
    
    /// <summary>Description of the output: format and resolution</summary>
    internal unsafe struct OniVideoMode
    {
        public OniPixelFormat @pixelFormat;
        public int @resolutionX;
        public int @resolutionY;
        public int @fps;
    }
    
    /// <summary>List of supported video modes by a specific source</summary>
    internal unsafe struct OniSensorInfo
    {
        public OniSensorType @sensorType;
        public int @numSupportedVideoModes;
        public OniVideoMode* @pSupportedVideoModes;
    }
    
    /// <summary>Basic description of a device</summary>
    internal unsafe struct OniDeviceInfo
    {
        public byte_array256 @uri;
        public byte_array256 @vendor;
        public byte_array256 @name;
        public ushort @usbVendorId;
        public ushort @usbProductId;
    }
    
    /// <summary>All information of the current frame</summary>
    internal unsafe struct OniFrame
    {
        public int @dataSize;
        public void* @data;
        public OniSensorType @sensorType;
        public ulong @timestamp;
        public int @frameIndex;
        public int @width;
        public int @height;
        public OniVideoMode @videoMode;
        public int @croppingEnabled;
        public int @cropOriginX;
        public int @cropOriginY;
        public int @stride;
    }
    
    internal unsafe struct OniDeviceCallbacks
    {
        public void* @deviceConnected;
        public void* @deviceDisconnected;
        public void* @deviceStateChanged;
    }
    
    internal unsafe struct OniCropping
    {
        public int @enabled;
        public int @originX;
        public int @originY;
        public int @width;
        public int @height;
    }
    
    /// <summary>Holds the value of a single color image pixel in 24-bit RGB format.</summary>
    internal unsafe struct OniRGB888Pixel
    {
        public byte @r;
        public byte @g;
        public byte @b;
    }
    
    /// <summary>Holds the value of two pixels in YUV422 format (Luminance/Chrominance,16-bits/pixel). The first pixel has the values y1, u, v. The second pixel has the values y2, u, v.</summary>
    internal unsafe struct OniYUV422DoublePixel
    {
        /// <summary>First chrominance value for two pixels, stored as blue luminance difference signal.</summary>
        public byte @u;
        /// <summary>Overall luminance value of first pixel.</summary>
        public byte @y1;
        /// <summary>Second chrominance value for two pixels, stored as red luminance difference signal.</summary>
        public byte @v;
        /// <summary>Overall luminance value of second pixel.</summary>
        public byte @y2;
    }
    
    internal unsafe struct OniSeek
    {
        public int @frameIndex;
        public _OniStream* @stream;
    }
    
    internal unsafe struct XnFwFileVersion
    {
        public byte @major;
        public byte @minor;
        public byte @maintenance;
        public byte @build;
    }
    
    internal unsafe struct XnFwFileEntry
    {
        public byte_array32 @name;
        public XnFwFileVersion @version;
        public uint @address;
        public uint @size;
        public ushort @crc;
        public ushort @zone;
        public XnFwFileFlags @flags;
    }
    
    internal unsafe struct XnI2CDeviceInfo
    {
        public uint @id;
        public byte_array32 @name;
    }
    
    internal unsafe struct XnBistInfo
    {
        public uint @id;
        public byte_array32 @name;
    }
    
    internal unsafe struct XnFwLogMask
    {
        public uint @id;
        public byte_array32 @name;
    }
    
    internal unsafe struct XnUsbTestEndpointResult
    {
        public double @averageBytesPerSecond;
        public uint @lostPackets;
    }
    
    internal unsafe struct XnCommandAHB
    {
        public uint @address;
        public uint @offsetInBits;
        public uint @widthInBits;
        public uint @value;
    }
    
    internal unsafe struct XnCommandI2C
    {
        public uint @deviceID;
        public uint @addressSize;
        public uint @address;
        public uint @valueSize;
        public uint @mask;
        public uint @value;
    }
    
    internal unsafe struct XnCommandUploadFile
    {
        public byte* @filePath;
        public uint @uploadToFactory;
    }
    
    internal unsafe struct XnCommandDownloadFile
    {
        public ushort @zone;
        public byte* @firmwareFileName;
        public byte* @targetPath;
    }
    
    internal unsafe struct XnCommandGetFileList
    {
        public uint @count;
        public XnFwFileEntry* @files;
    }
    
    internal unsafe struct XnCommandFormatZone
    {
        public byte @zone;
    }
    
    internal unsafe struct XnCommandDumpEndpoint
    {
        public byte @endpoint;
        public bool @enabled;
    }
    
    internal unsafe struct XnCommandGetI2CDeviceList
    {
        public uint @count;
        public XnI2CDeviceInfo* @devices;
    }
    
    internal unsafe struct XnCommandGetBistList
    {
        public uint @count;
        public XnBistInfo* @tests;
    }
    
    internal unsafe struct XnCommandExecuteBist
    {
        public uint @id;
        public uint @errorCode;
        public uint @extraDataSize;
        public byte* @extraData;
    }
    
    internal unsafe struct XnCommandUsbTest
    {
        public uint @seconds;
        public uint @endpointCount;
        public XnUsbTestEndpointResult* @endpoints;
    }
    
    internal unsafe struct XnCommandGetLogMaskList
    {
        public uint @count;
        public XnFwLogMask* @masks;
    }
    
    internal unsafe struct XnCommandSetLogMaskState
    {
        public uint @mask;
        public bool @enabled;
    }
    
    internal unsafe struct XnSDKVersion
    {
        public byte @nMajor;
        public byte @nMinor;
        public byte @nMaintenance;
        public ushort @nBuild;
    }
    
    internal unsafe struct XnVersions
    {
        public byte @nMajor;
        public byte @nMinor;
        public ushort @nBuild;
        public uint @nChip;
        public ushort @nFPGA;
        public ushort @nSystemVersion;
        public XnSDKVersion @SDK;
        public XnHWVer @HWVer;
        public XnFWVer @FWVer;
        public XnSensorVer @SensorVer;
        public XnChipVer @ChipVer;
    }
    
    internal unsafe struct XnInnerParamData
    {
        public ushort @nParam;
        public ushort @nValue;
    }
    
    internal unsafe struct XnDepthAGCBin
    {
        public ushort @nBin;
        public ushort @nMin;
        public ushort @nMax;
    }
    
    internal unsafe struct XnControlProcessingData
    {
        public ushort @nRegister;
        public ushort @nValue;
    }
    
    internal unsafe struct XnAHBData
    {
        public uint @nRegister;
        public uint @nValue;
        public uint @nMask;
    }
    
    internal unsafe struct XnPixelRegistration
    {
        public uint @nDepthX;
        public uint @nDepthY;
        public ushort @nDepthValue;
        public uint @nImageXRes;
        public uint @nImageYRes;
        public uint @nImageX;
        public uint @nImageY;
    }
    
    internal unsafe struct XnLedState
    {
        public ushort @nLedID;
        public ushort @nState;
    }
    
    internal unsafe struct XnCmosBlankingTime
    {
        public XnCMOSType @nCmosID;
        public float @nTimeInMilliseconds;
        public ushort @nNumberOfFrames;
    }
    
    internal unsafe struct XnCmosBlankingUnits
    {
        public XnCMOSType @nCmosID;
        public ushort @nUnits;
        public ushort @nNumberOfFrames;
    }
    
    internal unsafe struct XnI2CWriteData
    {
        public ushort @nBus;
        public ushort @nSlaveAddress;
        public ushort_array10 @cpWriteBuffer;
        public ushort @nWriteSize;
    }
    
    internal unsafe struct XnI2CReadData
    {
        public ushort @nBus;
        public ushort @nSlaveAddress;
        public ushort_array10 @cpReadBuffer;
        public ushort_array10 @cpWriteBuffer;
        public ushort @nReadSize;
        public ushort @nWriteSize;
    }
    
    internal unsafe struct XnTecData
    {
        public ushort @m_SetPointVoltage;
        public ushort @m_CompensationVoltage;
        public ushort @m_TecDutyCycle;
        public ushort @m_HeatMode;
        public int @m_ProportionalError;
        public int @m_IntegralError;
        public int @m_DerivativeError;
        public ushort @m_ScanMode;
    }
    
    internal unsafe struct XnTecFastConvergenceData
    {
        public short @m_SetPointTemperature;
        public short @m_MeasuredTemperature;
        public int @m_ProportionalError;
        public int @m_IntegralError;
        public int @m_DerivativeError;
        public ushort @m_ScanMode;
        public ushort @m_HeatMode;
        public ushort @m_TecDutyCycle;
        public ushort @m_TemperatureRange;
    }
    
    internal unsafe struct XnEmitterData
    {
        public ushort @m_State;
        public ushort @m_SetPointVoltage;
        public ushort @m_SetPointClocks;
        public ushort @m_PD_Reading;
        public ushort @m_EmitterSet;
        public ushort @m_EmitterSettingLogic;
        public ushort @m_LightMeasureLogic;
        public ushort @m_IsAPCEnabled;
        public ushort @m_EmitterSetStepSize;
        public ushort @m_ApcTolerance;
        public ushort @m_SubClocking;
        public ushort @m_Precision;
    }
    
    internal unsafe struct XnFileAttributes
    {
        public ushort @nId;
        public ushort @nAttribs;
    }
    
    internal unsafe struct XnParamFileData
    {
        public uint @nOffset;
        public byte* @strFileName;
        public ushort @nAttributes;
    }
    
    internal unsafe struct XnParamFlashData
    {
        public uint @nOffset;
        public uint @nSize;
        public byte* @pData;
    }
    
    internal unsafe struct XnFlashFile
    {
        public ushort @nId;
        public ushort @nType;
        public uint @nVersion;
        public uint @nOffset;
        public uint @nSize;
        public ushort @nCrc;
        public ushort @nAttributes;
        public ushort @nReserve;
    }
    
    internal unsafe struct XnFlashFileList
    {
        public XnFlashFile* @pFiles;
        public ushort @nFiles;
    }
    
    internal unsafe struct XnProjectorFaultData
    {
        public ushort @nMinThreshold;
        public ushort @nMaxThreshold;
        public int @bProjectorFaultEvent;
    }
    
    internal unsafe struct XnBist
    {
        public uint @nTestsMask;
        public uint @nFailures;
    }
    
    internal unsafe struct XnDetailedVersion
    {
        public byte @m_nMajor;
        public byte @m_nMinor;
        public ushort @m_nMaintenance;
        public uint @m_nBuild;
        public byte_array16 @m_strModifier;
    }
    
    internal unsafe struct XnBootStatus
    {
        public XnFileZone @zone;
        public XnBootErrorCode @errorCode;
    }
    
    internal unsafe struct XnFwStreamInfo
    {
        public XnFwStreamType @type;
        public byte_array80 @creationInfo;
    }
    
    internal unsafe struct XnFwStreamVideoMode
    {
        public uint @m_nXRes;
        public uint @m_nYRes;
        public uint @m_nFPS;
        public XnFwPixelFormat @m_nPixelFormat;
        public XnFwCompressionType @m_nCompression;
    }
    
    internal unsafe struct XnCommandGetFwStreamList
    {
        public uint @count;
        public XnFwStreamInfo* @streams;
    }
    
    internal unsafe struct XnCommandCreateStream
    {
        public XnFwStreamType @type;
        public byte* @creationInfo;
        public uint @id;
    }
    
    internal unsafe struct XnCommandDestroyStream
    {
        public uint @id;
    }
    
    internal unsafe struct XnCommandStartStream
    {
        public uint @id;
    }
    
    internal unsafe struct XnCommandStopStream
    {
        public uint @id;
    }
    
    internal unsafe struct XnCommandGetFwStreamVideoModeList
    {
        public int @streamId;
        public uint @count;
        public XnFwStreamVideoMode* @videoModes;
    }
    
    internal unsafe struct XnCommandSetFwStreamVideoMode
    {
        public int @streamId;
        public XnFwStreamVideoMode @videoMode;
    }
    
    internal unsafe struct XnCommandGetFwStreamVideoMode
    {
        public int @streamId;
        public XnFwStreamVideoMode @videoMode;
    }
    
}

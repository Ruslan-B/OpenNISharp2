using System;
using System.Security;
using System.Runtime.InteropServices;

namespace OpenNISharp2.Native
{
    public unsafe static partial class OniCAPI
    {
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniCoordinateConverterDepthToColor_delegate(_OniStream* @depthStream, _OniStream* @colorStream, int @depthX, int @depthY, ushort @depthZ, int* @pColorX, int* @pColorY);
        private static oniCoordinateConverterDepthToColor_delegate oniCoordinateConverterDepthToColor_fptr = (_OniStream* @depthStream, _OniStream* @colorStream, int @depthX, int @depthY, ushort @depthZ, int* @pColorX, int* @pColorY) =>
        {
            oniCoordinateConverterDepthToColor_fptr = GetFunctionDelegate<oniCoordinateConverterDepthToColor_delegate>(GetOrLoadLibrary("OpenNI2"), "oniCoordinateConverterDepthToColor");
            if (oniCoordinateConverterDepthToColor_fptr == null)
            {
                oniCoordinateConverterDepthToColor_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniCoordinateConverterDepthToColor is not supported on this platform.");
                };
            }
            return oniCoordinateConverterDepthToColor_fptr(@depthStream, @colorStream, @depthX, @depthY, @depthZ, @pColorX, @pColorY);
        };
        internal static OniStatus oniCoordinateConverterDepthToColor(_OniStream* @depthStream, _OniStream* @colorStream, int @depthX, int @depthY, ushort @depthZ, int* @pColorX, int* @pColorY)
        {
            return oniCoordinateConverterDepthToColor_fptr(@depthStream, @colorStream, @depthX, @depthY, @depthZ, @pColorX, @pColorY);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniCoordinateConverterDepthToWorld_delegate(_OniStream* @depthStream, float @depthX, float @depthY, float @depthZ, float* @pWorldX, float* @pWorldY, float* @pWorldZ);
        private static oniCoordinateConverterDepthToWorld_delegate oniCoordinateConverterDepthToWorld_fptr = (_OniStream* @depthStream, float @depthX, float @depthY, float @depthZ, float* @pWorldX, float* @pWorldY, float* @pWorldZ) =>
        {
            oniCoordinateConverterDepthToWorld_fptr = GetFunctionDelegate<oniCoordinateConverterDepthToWorld_delegate>(GetOrLoadLibrary("OpenNI2"), "oniCoordinateConverterDepthToWorld");
            if (oniCoordinateConverterDepthToWorld_fptr == null)
            {
                oniCoordinateConverterDepthToWorld_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniCoordinateConverterDepthToWorld is not supported on this platform.");
                };
            }
            return oniCoordinateConverterDepthToWorld_fptr(@depthStream, @depthX, @depthY, @depthZ, @pWorldX, @pWorldY, @pWorldZ);
        };
        internal static OniStatus oniCoordinateConverterDepthToWorld(_OniStream* @depthStream, float @depthX, float @depthY, float @depthZ, float* @pWorldX, float* @pWorldY, float* @pWorldZ)
        {
            return oniCoordinateConverterDepthToWorld_fptr(@depthStream, @depthX, @depthY, @depthZ, @pWorldX, @pWorldY, @pWorldZ);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniCoordinateConverterWorldToDepth_delegate(_OniStream* @depthStream, float @worldX, float @worldY, float @worldZ, float* @pDepthX, float* @pDepthY, float* @pDepthZ);
        private static oniCoordinateConverterWorldToDepth_delegate oniCoordinateConverterWorldToDepth_fptr = (_OniStream* @depthStream, float @worldX, float @worldY, float @worldZ, float* @pDepthX, float* @pDepthY, float* @pDepthZ) =>
        {
            oniCoordinateConverterWorldToDepth_fptr = GetFunctionDelegate<oniCoordinateConverterWorldToDepth_delegate>(GetOrLoadLibrary("OpenNI2"), "oniCoordinateConverterWorldToDepth");
            if (oniCoordinateConverterWorldToDepth_fptr == null)
            {
                oniCoordinateConverterWorldToDepth_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniCoordinateConverterWorldToDepth is not supported on this platform.");
                };
            }
            return oniCoordinateConverterWorldToDepth_fptr(@depthStream, @worldX, @worldY, @worldZ, @pDepthX, @pDepthY, @pDepthZ);
        };
        internal static OniStatus oniCoordinateConverterWorldToDepth(_OniStream* @depthStream, float @worldX, float @worldY, float @worldZ, float* @pDepthX, float* @pDepthY, float* @pDepthZ)
        {
            return oniCoordinateConverterWorldToDepth_fptr(@depthStream, @worldX, @worldY, @worldZ, @pDepthX, @pDepthY, @pDepthZ);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniCreateRecorder_delegate([MarshalAs(UnmanagedType.LPStr)] string @fileName, _OniRecorder** @pRecorder);
        private static oniCreateRecorder_delegate oniCreateRecorder_fptr = (string @fileName, _OniRecorder** @pRecorder) =>
        {
            oniCreateRecorder_fptr = GetFunctionDelegate<oniCreateRecorder_delegate>(GetOrLoadLibrary("OpenNI2"), "oniCreateRecorder");
            if (oniCreateRecorder_fptr == null)
            {
                oniCreateRecorder_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniCreateRecorder is not supported on this platform.");
                };
            }
            return oniCreateRecorder_fptr(@fileName, @pRecorder);
        };
        /// <summary>Creates a recorder that records to a file.</summary>
        /// <param name="fileName">The name of the file that will contain the recording.</param>
        /// <param name="pRecorder">Points to the handle to the newly created recorder.  ONI_STATUS_OK Upon successful completion.  ONI_STATUS_ERROR Upon any kind of failure.</param>
        internal static OniStatus oniCreateRecorder([MarshalAs(UnmanagedType.LPStr)] string @fileName, _OniRecorder** @pRecorder)
        {
            return oniCreateRecorder_fptr(@fileName, @pRecorder);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniDeviceClose_delegate(_OniDevice* @device);
        private static oniDeviceClose_delegate oniDeviceClose_fptr = (_OniDevice* @device) =>
        {
            oniDeviceClose_fptr = GetFunctionDelegate<oniDeviceClose_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceClose");
            if (oniDeviceClose_fptr == null)
            {
                oniDeviceClose_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceClose is not supported on this platform.");
                };
            }
            return oniDeviceClose_fptr(@device);
        };
        /// <summary>Close a device</summary>
        internal static OniStatus oniDeviceClose(_OniDevice* @device)
        {
            return oniDeviceClose_fptr(@device);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniDeviceCreateStream_delegate(_OniDevice* @device, OniSensorType @sensorType, _OniStream** @pStream);
        private static oniDeviceCreateStream_delegate oniDeviceCreateStream_fptr = (_OniDevice* @device, OniSensorType @sensorType, _OniStream** @pStream) =>
        {
            oniDeviceCreateStream_fptr = GetFunctionDelegate<oniDeviceCreateStream_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceCreateStream");
            if (oniDeviceCreateStream_fptr == null)
            {
                oniDeviceCreateStream_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceCreateStream is not supported on this platform.");
                };
            }
            return oniDeviceCreateStream_fptr(@device, @sensorType, @pStream);
        };
        /// <summary>Create a new stream in the device. The stream will originate from the source.</summary>
        internal static OniStatus oniDeviceCreateStream(_OniDevice* @device, OniSensorType @sensorType, _OniStream** @pStream)
        {
            return oniDeviceCreateStream_fptr(@device, @sensorType, @pStream);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void oniDeviceDisableDepthColorSync_delegate(_OniDevice* @device);
        private static oniDeviceDisableDepthColorSync_delegate oniDeviceDisableDepthColorSync_fptr = (_OniDevice* @device) =>
        {
            oniDeviceDisableDepthColorSync_fptr = GetFunctionDelegate<oniDeviceDisableDepthColorSync_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceDisableDepthColorSync");
            if (oniDeviceDisableDepthColorSync_fptr == null)
            {
                oniDeviceDisableDepthColorSync_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceDisableDepthColorSync is not supported on this platform.");
                };
            }
            oniDeviceDisableDepthColorSync_fptr(@device);
        };
        internal static void oniDeviceDisableDepthColorSync(_OniDevice* @device)
        {
            oniDeviceDisableDepthColorSync_fptr(@device);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniDeviceEnableDepthColorSync_delegate(_OniDevice* @device);
        private static oniDeviceEnableDepthColorSync_delegate oniDeviceEnableDepthColorSync_fptr = (_OniDevice* @device) =>
        {
            oniDeviceEnableDepthColorSync_fptr = GetFunctionDelegate<oniDeviceEnableDepthColorSync_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceEnableDepthColorSync");
            if (oniDeviceEnableDepthColorSync_fptr == null)
            {
                oniDeviceEnableDepthColorSync_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceEnableDepthColorSync is not supported on this platform.");
                };
            }
            return oniDeviceEnableDepthColorSync_fptr(@device);
        };
        internal static OniStatus oniDeviceEnableDepthColorSync(_OniDevice* @device)
        {
            return oniDeviceEnableDepthColorSync_fptr(@device);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int oniDeviceGetDepthColorSyncEnabled_delegate(_OniDevice* @device);
        private static oniDeviceGetDepthColorSyncEnabled_delegate oniDeviceGetDepthColorSyncEnabled_fptr = (_OniDevice* @device) =>
        {
            oniDeviceGetDepthColorSyncEnabled_fptr = GetFunctionDelegate<oniDeviceGetDepthColorSyncEnabled_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceGetDepthColorSyncEnabled");
            if (oniDeviceGetDepthColorSyncEnabled_fptr == null)
            {
                oniDeviceGetDepthColorSyncEnabled_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceGetDepthColorSyncEnabled is not supported on this platform.");
                };
            }
            return oniDeviceGetDepthColorSyncEnabled_fptr(@device);
        };
        internal static int oniDeviceGetDepthColorSyncEnabled(_OniDevice* @device)
        {
            return oniDeviceGetDepthColorSyncEnabled_fptr(@device);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniDeviceGetInfo_delegate(_OniDevice* @device, OniDeviceInfo* @pInfo);
        private static oniDeviceGetInfo_delegate oniDeviceGetInfo_fptr = (_OniDevice* @device, OniDeviceInfo* @pInfo) =>
        {
            oniDeviceGetInfo_fptr = GetFunctionDelegate<oniDeviceGetInfo_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceGetInfo");
            if (oniDeviceGetInfo_fptr == null)
            {
                oniDeviceGetInfo_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceGetInfo is not supported on this platform.");
                };
            }
            return oniDeviceGetInfo_fptr(@device, @pInfo);
        };
        /// <summary>Get the OniDeviceInfo of a certain device.</summary>
        internal static OniStatus oniDeviceGetInfo(_OniDevice* @device, OniDeviceInfo* @pInfo)
        {
            return oniDeviceGetInfo_fptr(@device, @pInfo);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniDeviceGetProperty_delegate(_OniDevice* @device, int @propertyId, void* @data, int* @pDataSize);
        private static oniDeviceGetProperty_delegate oniDeviceGetProperty_fptr = (_OniDevice* @device, int @propertyId, void* @data, int* @pDataSize) =>
        {
            oniDeviceGetProperty_fptr = GetFunctionDelegate<oniDeviceGetProperty_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceGetProperty");
            if (oniDeviceGetProperty_fptr == null)
            {
                oniDeviceGetProperty_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceGetProperty is not supported on this platform.");
                };
            }
            return oniDeviceGetProperty_fptr(@device, @propertyId, @data, @pDataSize);
        };
        /// <summary>Get property in the device. Use the properties listed in OniTypes.h: ONI_DEVICE_PROPERTY_..., or specific ones supplied by the device.</summary>
        internal static OniStatus oniDeviceGetProperty(_OniDevice* @device, int @propertyId, void* @data, int* @pDataSize)
        {
            return oniDeviceGetProperty_fptr(@device, @propertyId, @data, @pDataSize);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniSensorInfo* oniDeviceGetSensorInfo_delegate(_OniDevice* @device, OniSensorType @sensorType);
        private static oniDeviceGetSensorInfo_delegate oniDeviceGetSensorInfo_fptr = (_OniDevice* @device, OniSensorType @sensorType) =>
        {
            oniDeviceGetSensorInfo_fptr = GetFunctionDelegate<oniDeviceGetSensorInfo_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceGetSensorInfo");
            if (oniDeviceGetSensorInfo_fptr == null)
            {
                oniDeviceGetSensorInfo_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceGetSensorInfo is not supported on this platform.");
                };
            }
            return oniDeviceGetSensorInfo_fptr(@device, @sensorType);
        };
        /// <summary>Get the possible configurations available for a specific source, or NULL if the source does not exist.</summary>
        internal static OniSensorInfo* oniDeviceGetSensorInfo(_OniDevice* @device, OniSensorType @sensorType)
        {
            return oniDeviceGetSensorInfo_fptr(@device, @sensorType);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniDeviceInvoke_delegate(_OniDevice* @device, int @commandId, void* @data, int @dataSize);
        private static oniDeviceInvoke_delegate oniDeviceInvoke_fptr = (_OniDevice* @device, int @commandId, void* @data, int @dataSize) =>
        {
            oniDeviceInvoke_fptr = GetFunctionDelegate<oniDeviceInvoke_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceInvoke");
            if (oniDeviceInvoke_fptr == null)
            {
                oniDeviceInvoke_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceInvoke is not supported on this platform.");
                };
            }
            return oniDeviceInvoke_fptr(@device, @commandId, @data, @dataSize);
        };
        /// <summary>Invoke an internal functionality of the device.</summary>
        internal static OniStatus oniDeviceInvoke(_OniDevice* @device, int @commandId, void* @data, int @dataSize)
        {
            return oniDeviceInvoke_fptr(@device, @commandId, @data, @dataSize);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int oniDeviceIsCommandSupported_delegate(_OniDevice* @device, int @commandId);
        private static oniDeviceIsCommandSupported_delegate oniDeviceIsCommandSupported_fptr = (_OniDevice* @device, int @commandId) =>
        {
            oniDeviceIsCommandSupported_fptr = GetFunctionDelegate<oniDeviceIsCommandSupported_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceIsCommandSupported");
            if (oniDeviceIsCommandSupported_fptr == null)
            {
                oniDeviceIsCommandSupported_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceIsCommandSupported is not supported on this platform.");
                };
            }
            return oniDeviceIsCommandSupported_fptr(@device, @commandId);
        };
        /// <summary>Check if a command is supported, for invoke</summary>
        internal static int oniDeviceIsCommandSupported(_OniDevice* @device, int @commandId)
        {
            return oniDeviceIsCommandSupported_fptr(@device, @commandId);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int oniDeviceIsImageRegistrationModeSupported_delegate(_OniDevice* @device, OniImageRegistrationMode @mode);
        private static oniDeviceIsImageRegistrationModeSupported_delegate oniDeviceIsImageRegistrationModeSupported_fptr = (_OniDevice* @device, OniImageRegistrationMode @mode) =>
        {
            oniDeviceIsImageRegistrationModeSupported_fptr = GetFunctionDelegate<oniDeviceIsImageRegistrationModeSupported_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceIsImageRegistrationModeSupported");
            if (oniDeviceIsImageRegistrationModeSupported_fptr == null)
            {
                oniDeviceIsImageRegistrationModeSupported_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceIsImageRegistrationModeSupported is not supported on this platform.");
                };
            }
            return oniDeviceIsImageRegistrationModeSupported_fptr(@device, @mode);
        };
        internal static int oniDeviceIsImageRegistrationModeSupported(_OniDevice* @device, OniImageRegistrationMode @mode)
        {
            return oniDeviceIsImageRegistrationModeSupported_fptr(@device, @mode);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int oniDeviceIsPropertySupported_delegate(_OniDevice* @device, int @propertyId);
        private static oniDeviceIsPropertySupported_delegate oniDeviceIsPropertySupported_fptr = (_OniDevice* @device, int @propertyId) =>
        {
            oniDeviceIsPropertySupported_fptr = GetFunctionDelegate<oniDeviceIsPropertySupported_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceIsPropertySupported");
            if (oniDeviceIsPropertySupported_fptr == null)
            {
                oniDeviceIsPropertySupported_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceIsPropertySupported is not supported on this platform.");
                };
            }
            return oniDeviceIsPropertySupported_fptr(@device, @propertyId);
        };
        /// <summary>Check if the property is supported by the device. Use the properties listed in OniTypes.h: ONI_DEVICE_PROPERTY_..., or specific ones supplied by the device.</summary>
        internal static int oniDeviceIsPropertySupported(_OniDevice* @device, int @propertyId)
        {
            return oniDeviceIsPropertySupported_fptr(@device, @propertyId);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniDeviceOpen_delegate([MarshalAs(UnmanagedType.LPStr)] string @uri, _OniDevice** @pDevice);
        private static oniDeviceOpen_delegate oniDeviceOpen_fptr = (string @uri, _OniDevice** @pDevice) =>
        {
            oniDeviceOpen_fptr = GetFunctionDelegate<oniDeviceOpen_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceOpen");
            if (oniDeviceOpen_fptr == null)
            {
                oniDeviceOpen_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceOpen is not supported on this platform.");
                };
            }
            return oniDeviceOpen_fptr(@uri, @pDevice);
        };
        /// <summary>Open a device. Uri can be taken from the matching OniDeviceInfo.</summary>
        internal static OniStatus oniDeviceOpen([MarshalAs(UnmanagedType.LPStr)] string @uri, _OniDevice** @pDevice)
        {
            return oniDeviceOpen_fptr(@uri, @pDevice);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniDeviceOpenEx_delegate([MarshalAs(UnmanagedType.LPStr)] string @uri, [MarshalAs(UnmanagedType.LPStr)] string @mode, _OniDevice** @pDevice);
        private static oniDeviceOpenEx_delegate oniDeviceOpenEx_fptr = (string @uri, string @mode, _OniDevice** @pDevice) =>
        {
            oniDeviceOpenEx_fptr = GetFunctionDelegate<oniDeviceOpenEx_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceOpenEx");
            if (oniDeviceOpenEx_fptr == null)
            {
                oniDeviceOpenEx_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceOpenEx is not supported on this platform.");
                };
            }
            return oniDeviceOpenEx_fptr(@uri, @mode, @pDevice);
        };
        internal static OniStatus oniDeviceOpenEx([MarshalAs(UnmanagedType.LPStr)] string @uri, [MarshalAs(UnmanagedType.LPStr)] string @mode, _OniDevice** @pDevice)
        {
            return oniDeviceOpenEx_fptr(@uri, @mode, @pDevice);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniDeviceSetProperty_delegate(_OniDevice* @device, int @propertyId, void* @data, int @dataSize);
        private static oniDeviceSetProperty_delegate oniDeviceSetProperty_fptr = (_OniDevice* @device, int @propertyId, void* @data, int @dataSize) =>
        {
            oniDeviceSetProperty_fptr = GetFunctionDelegate<oniDeviceSetProperty_delegate>(GetOrLoadLibrary("OpenNI2"), "oniDeviceSetProperty");
            if (oniDeviceSetProperty_fptr == null)
            {
                oniDeviceSetProperty_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniDeviceSetProperty is not supported on this platform.");
                };
            }
            return oniDeviceSetProperty_fptr(@device, @propertyId, @data, @dataSize);
        };
        /// <summary>Set property in the device. Use the properties listed in OniTypes.h: ONI_DEVICE_PROPERTY_..., or specific ones supplied by the device.</summary>
        internal static OniStatus oniDeviceSetProperty(_OniDevice* @device, int @propertyId, void* @data, int @dataSize)
        {
            return oniDeviceSetProperty_fptr(@device, @propertyId, @data, @dataSize);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int oniFormatBytesPerPixel_delegate(OniPixelFormat @format);
        private static oniFormatBytesPerPixel_delegate oniFormatBytesPerPixel_fptr = (OniPixelFormat @format) =>
        {
            oniFormatBytesPerPixel_fptr = GetFunctionDelegate<oniFormatBytesPerPixel_delegate>(GetOrLoadLibrary("OpenNI2"), "oniFormatBytesPerPixel");
            if (oniFormatBytesPerPixel_fptr == null)
            {
                oniFormatBytesPerPixel_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniFormatBytesPerPixel is not supported on this platform.");
                };
            }
            return oniFormatBytesPerPixel_fptr(@format);
        };
        /// <summary>Translate from format to number of bytes per pixel. Will return 0 for formats in which the number of bytes per pixel isn&apos;t fixed.</summary>
        internal static int oniFormatBytesPerPixel(OniPixelFormat @format)
        {
            return oniFormatBytesPerPixel_fptr(@format);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void oniFrameAddRef_delegate(OniFrame* @pFrame);
        private static oniFrameAddRef_delegate oniFrameAddRef_fptr = (OniFrame* @pFrame) =>
        {
            oniFrameAddRef_fptr = GetFunctionDelegate<oniFrameAddRef_delegate>(GetOrLoadLibrary("OpenNI2"), "oniFrameAddRef");
            if (oniFrameAddRef_fptr == null)
            {
                oniFrameAddRef_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniFrameAddRef is not supported on this platform.");
                };
            }
            oniFrameAddRef_fptr(@pFrame);
        };
        /// <summary>/ Mark another user of the frame.</summary>
        internal static void oniFrameAddRef(OniFrame* @pFrame)
        {
            oniFrameAddRef_fptr(@pFrame);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void oniFrameRelease_delegate(OniFrame* @pFrame);
        private static oniFrameRelease_delegate oniFrameRelease_fptr = (OniFrame* @pFrame) =>
        {
            oniFrameRelease_fptr = GetFunctionDelegate<oniFrameRelease_delegate>(GetOrLoadLibrary("OpenNI2"), "oniFrameRelease");
            if (oniFrameRelease_fptr == null)
            {
                oniFrameRelease_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniFrameRelease is not supported on this platform.");
                };
            }
            oniFrameRelease_fptr(@pFrame);
        };
        /// <summary>Mark that the frame is no longer needed.</summary>
        internal static void oniFrameRelease(OniFrame* @pFrame)
        {
            oniFrameRelease_fptr(@pFrame);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniGetDeviceList_delegate(OniDeviceInfo** @pDevices, int* @pNumDevices);
        private static oniGetDeviceList_delegate oniGetDeviceList_fptr = (OniDeviceInfo** @pDevices, int* @pNumDevices) =>
        {
            oniGetDeviceList_fptr = GetFunctionDelegate<oniGetDeviceList_delegate>(GetOrLoadLibrary("OpenNI2"), "oniGetDeviceList");
            if (oniGetDeviceList_fptr == null)
            {
                oniGetDeviceList_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniGetDeviceList is not supported on this platform.");
                };
            }
            return oniGetDeviceList_fptr(@pDevices, @pNumDevices);
        };
        /// <summary>Get the list of currently connected device. Each device is represented by its OniDeviceInfo. pDevices will be allocated inside.</summary>
        internal static OniStatus oniGetDeviceList(OniDeviceInfo** @pDevices, int* @pNumDevices)
        {
            return oniGetDeviceList_fptr(@pDevices, @pNumDevices);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string oniGetExtendedError_delegate();
        private static oniGetExtendedError_delegate oniGetExtendedError_fptr = () =>
        {
            oniGetExtendedError_fptr = GetFunctionDelegate<oniGetExtendedError_delegate>(GetOrLoadLibrary("OpenNI2"), "oniGetExtendedError");
            if (oniGetExtendedError_fptr == null)
            {
                oniGetExtendedError_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniGetExtendedError is not supported on this platform.");
                };
            }
            return oniGetExtendedError_fptr();
        };
        /// <summary>Get internal error</summary>
        internal static string oniGetExtendedError()
        {
            return oniGetExtendedError_fptr();
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniGetLogFileName_delegate(byte* @strFileName, int @nBufferSize);
        private static oniGetLogFileName_delegate oniGetLogFileName_fptr = (byte* @strFileName, int @nBufferSize) =>
        {
            oniGetLogFileName_fptr = GetFunctionDelegate<oniGetLogFileName_delegate>(GetOrLoadLibrary("OpenNI2"), "oniGetLogFileName");
            if (oniGetLogFileName_fptr == null)
            {
                oniGetLogFileName_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniGetLogFileName is not supported on this platform.");
                };
            }
            return oniGetLogFileName_fptr(@strFileName, @nBufferSize);
        };
        /// <summary>Get the current log file name</summary>
        internal static OniStatus oniGetLogFileName(byte* @strFileName, int @nBufferSize)
        {
            return oniGetLogFileName_fptr(@strFileName, @nBufferSize);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniVersion oniGetVersion_delegate();
        private static oniGetVersion_delegate oniGetVersion_fptr = () =>
        {
            oniGetVersion_fptr = GetFunctionDelegate<oniGetVersion_delegate>(GetOrLoadLibrary("OpenNI2"), "oniGetVersion");
            if (oniGetVersion_fptr == null)
            {
                oniGetVersion_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniGetVersion is not supported on this platform.");
                };
            }
            return oniGetVersion_fptr();
        };
        /// <summary>Get the current version of OpenNI2</summary>
        internal static OniVersion oniGetVersion()
        {
            return oniGetVersion_fptr();
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniInitialize_delegate(int @apiVersion);
        private static oniInitialize_delegate oniInitialize_fptr = (int @apiVersion) =>
        {
            oniInitialize_fptr = GetFunctionDelegate<oniInitialize_delegate>(GetOrLoadLibrary("OpenNI2"), "oniInitialize");
            if (oniInitialize_fptr == null)
            {
                oniInitialize_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniInitialize is not supported on this platform.");
                };
            }
            return oniInitialize_fptr(@apiVersion);
        };
        /// <summary>Initialize OpenNI2. Use ONI_API_VERSION as the version.</summary>
        internal static OniStatus oniInitialize(int @apiVersion)
        {
            return oniInitialize_fptr(@apiVersion);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniRecorderAttachStream_delegate(_OniRecorder* @recorder, _OniStream* @stream, int @allowLossyCompression);
        private static oniRecorderAttachStream_delegate oniRecorderAttachStream_fptr = (_OniRecorder* @recorder, _OniStream* @stream, int @allowLossyCompression) =>
        {
            oniRecorderAttachStream_fptr = GetFunctionDelegate<oniRecorderAttachStream_delegate>(GetOrLoadLibrary("OpenNI2"), "oniRecorderAttachStream");
            if (oniRecorderAttachStream_fptr == null)
            {
                oniRecorderAttachStream_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniRecorderAttachStream is not supported on this platform.");
                };
            }
            return oniRecorderAttachStream_fptr(@recorder, @stream, @allowLossyCompression);
        };
        /// <summary>Attaches a stream to a recorder. The amount of attached streams is virtually infinite. You cannot attach a stream after you have started a recording, if you do: an error will be returned by oniRecorderAttachStream.</summary>
        /// <param name="recorder">The handle to the recorder.</param>
        /// <param name="stream">The handle to the stream.</param>
        /// <param name="allowLossyCompression">Allows/denies lossy compression  ONI_STATUS_OK Upon successful completion.  ONI_STATUS_ERROR Upon any kind of failure.</param>
        internal static OniStatus oniRecorderAttachStream(_OniRecorder* @recorder, _OniStream* @stream, int @allowLossyCompression)
        {
            return oniRecorderAttachStream_fptr(@recorder, @stream, @allowLossyCompression);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniRecorderDestroy_delegate(_OniRecorder** @pRecorder);
        private static oniRecorderDestroy_delegate oniRecorderDestroy_fptr = (_OniRecorder** @pRecorder) =>
        {
            oniRecorderDestroy_fptr = GetFunctionDelegate<oniRecorderDestroy_delegate>(GetOrLoadLibrary("OpenNI2"), "oniRecorderDestroy");
            if (oniRecorderDestroy_fptr == null)
            {
                oniRecorderDestroy_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniRecorderDestroy is not supported on this platform.");
                };
            }
            return oniRecorderDestroy_fptr(@pRecorder);
        };
        /// <summary>Stops recording if needed, and destroys a recorder.</summary>
        internal static OniStatus oniRecorderDestroy(_OniRecorder** @pRecorder)
        {
            return oniRecorderDestroy_fptr(@pRecorder);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniRecorderStart_delegate(_OniRecorder* @recorder);
        private static oniRecorderStart_delegate oniRecorderStart_fptr = (_OniRecorder* @recorder) =>
        {
            oniRecorderStart_fptr = GetFunctionDelegate<oniRecorderStart_delegate>(GetOrLoadLibrary("OpenNI2"), "oniRecorderStart");
            if (oniRecorderStart_fptr == null)
            {
                oniRecorderStart_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniRecorderStart is not supported on this platform.");
                };
            }
            return oniRecorderStart_fptr(@recorder);
        };
        /// <summary>Starts recording. There must be at least one stream attached to the recorder, if not: oniRecorderStart will return an error.</summary>
        /// <param name="recorder">The handle to the recorder.  ONI_STATUS_OK Upon successful completion.  ONI_STATUS_ERROR Upon any kind of failure.</param>
        internal static OniStatus oniRecorderStart(_OniRecorder* @recorder)
        {
            return oniRecorderStart_fptr(@recorder);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void oniRecorderStop_delegate(_OniRecorder* @recorder);
        private static oniRecorderStop_delegate oniRecorderStop_fptr = (_OniRecorder* @recorder) =>
        {
            oniRecorderStop_fptr = GetFunctionDelegate<oniRecorderStop_delegate>(GetOrLoadLibrary("OpenNI2"), "oniRecorderStop");
            if (oniRecorderStop_fptr == null)
            {
                oniRecorderStop_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniRecorderStop is not supported on this platform.");
                };
            }
            oniRecorderStop_fptr(@recorder);
        };
        /// <summary>Stops recording. You can resume recording via oniRecorderStart.</summary>
        /// <param name="recorder">The handle to the recorder.  ONI_STATUS_OK Upon successful completion.  ONI_STATUS_ERROR Upon any kind of failure.</param>
        internal static void oniRecorderStop(_OniRecorder* @recorder)
        {
            oniRecorderStop_fptr(@recorder);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniRegisterDeviceCallbacks_delegate(OniDeviceCallbacks* @pCallbacks, void* @pCookie, OniCallbackHandleImpl** @pHandle);
        private static oniRegisterDeviceCallbacks_delegate oniRegisterDeviceCallbacks_fptr = (OniDeviceCallbacks* @pCallbacks, void* @pCookie, OniCallbackHandleImpl** @pHandle) =>
        {
            oniRegisterDeviceCallbacks_fptr = GetFunctionDelegate<oniRegisterDeviceCallbacks_delegate>(GetOrLoadLibrary("OpenNI2"), "oniRegisterDeviceCallbacks");
            if (oniRegisterDeviceCallbacks_fptr == null)
            {
                oniRegisterDeviceCallbacks_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniRegisterDeviceCallbacks is not supported on this platform.");
                };
            }
            return oniRegisterDeviceCallbacks_fptr(@pCallbacks, @pCookie, @pHandle);
        };
        internal static OniStatus oniRegisterDeviceCallbacks(OniDeviceCallbacks* @pCallbacks, void* @pCookie, OniCallbackHandleImpl** @pHandle)
        {
            return oniRegisterDeviceCallbacks_fptr(@pCallbacks, @pCookie, @pHandle);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniReleaseDeviceList_delegate(OniDeviceInfo* @pDevices);
        private static oniReleaseDeviceList_delegate oniReleaseDeviceList_fptr = (OniDeviceInfo* @pDevices) =>
        {
            oniReleaseDeviceList_fptr = GetFunctionDelegate<oniReleaseDeviceList_delegate>(GetOrLoadLibrary("OpenNI2"), "oniReleaseDeviceList");
            if (oniReleaseDeviceList_fptr == null)
            {
                oniReleaseDeviceList_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniReleaseDeviceList is not supported on this platform.");
                };
            }
            return oniReleaseDeviceList_fptr(@pDevices);
        };
        /// <summary>Release previously allocated device list</summary>
        internal static OniStatus oniReleaseDeviceList(OniDeviceInfo* @pDevices)
        {
            return oniReleaseDeviceList_fptr(@pDevices);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniSetLogConsoleOutput_delegate(int @bConsoleOutput);
        private static oniSetLogConsoleOutput_delegate oniSetLogConsoleOutput_fptr = (int @bConsoleOutput) =>
        {
            oniSetLogConsoleOutput_fptr = GetFunctionDelegate<oniSetLogConsoleOutput_delegate>(GetOrLoadLibrary("OpenNI2"), "oniSetLogConsoleOutput");
            if (oniSetLogConsoleOutput_fptr == null)
            {
                oniSetLogConsoleOutput_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniSetLogConsoleOutput is not supported on this platform.");
                };
            }
            return oniSetLogConsoleOutput_fptr(@bConsoleOutput);
        };
        /// <summary>Configures if log entries will be printed to console.</summary>
        internal static OniStatus oniSetLogConsoleOutput(int @bConsoleOutput)
        {
            return oniSetLogConsoleOutput_fptr(@bConsoleOutput);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniSetLogFileOutput_delegate(int @bFileOutput);
        private static oniSetLogFileOutput_delegate oniSetLogFileOutput_fptr = (int @bFileOutput) =>
        {
            oniSetLogFileOutput_fptr = GetFunctionDelegate<oniSetLogFileOutput_delegate>(GetOrLoadLibrary("OpenNI2"), "oniSetLogFileOutput");
            if (oniSetLogFileOutput_fptr == null)
            {
                oniSetLogFileOutput_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniSetLogFileOutput is not supported on this platform.");
                };
            }
            return oniSetLogFileOutput_fptr(@bFileOutput);
        };
        /// <summary>Configures if log entries will be printed to a log file.</summary>
        internal static OniStatus oniSetLogFileOutput(int @bFileOutput)
        {
            return oniSetLogFileOutput_fptr(@bFileOutput);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniSetLogMinSeverity_delegate(int @nMinSeverity);
        private static oniSetLogMinSeverity_delegate oniSetLogMinSeverity_fptr = (int @nMinSeverity) =>
        {
            oniSetLogMinSeverity_fptr = GetFunctionDelegate<oniSetLogMinSeverity_delegate>(GetOrLoadLibrary("OpenNI2"), "oniSetLogMinSeverity");
            if (oniSetLogMinSeverity_fptr == null)
            {
                oniSetLogMinSeverity_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniSetLogMinSeverity is not supported on this platform.");
                };
            }
            return oniSetLogMinSeverity_fptr(@nMinSeverity);
        };
        /// <summary>Set the Minimum severity for log produce</summary>
        internal static OniStatus oniSetLogMinSeverity(int @nMinSeverity)
        {
            return oniSetLogMinSeverity_fptr(@nMinSeverity);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniSetLogOutputFolder_delegate([MarshalAs(UnmanagedType.LPStr)] string @strOutputFolder);
        private static oniSetLogOutputFolder_delegate oniSetLogOutputFolder_fptr = (string @strOutputFolder) =>
        {
            oniSetLogOutputFolder_fptr = GetFunctionDelegate<oniSetLogOutputFolder_delegate>(GetOrLoadLibrary("OpenNI2"), "oniSetLogOutputFolder");
            if (oniSetLogOutputFolder_fptr == null)
            {
                oniSetLogOutputFolder_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniSetLogOutputFolder is not supported on this platform.");
                };
            }
            return oniSetLogOutputFolder_fptr(@strOutputFolder);
        };
        /// <summary>Change the log output folder</summary>
        internal static OniStatus oniSetLogOutputFolder([MarshalAs(UnmanagedType.LPStr)] string @strOutputFolder)
        {
            return oniSetLogOutputFolder_fptr(@strOutputFolder);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void oniShutdown_delegate();
        private static oniShutdown_delegate oniShutdown_fptr = () =>
        {
            oniShutdown_fptr = GetFunctionDelegate<oniShutdown_delegate>(GetOrLoadLibrary("OpenNI2"), "oniShutdown");
            if (oniShutdown_fptr == null)
            {
                oniShutdown_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniShutdown is not supported on this platform.");
                };
            }
            oniShutdown_fptr();
        };
        /// <summary>Shutdown OpenNI2</summary>
        internal static void oniShutdown()
        {
            oniShutdown_fptr();
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void oniStreamDestroy_delegate(_OniStream* @stream);
        private static oniStreamDestroy_delegate oniStreamDestroy_fptr = (_OniStream* @stream) =>
        {
            oniStreamDestroy_fptr = GetFunctionDelegate<oniStreamDestroy_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamDestroy");
            if (oniStreamDestroy_fptr == null)
            {
                oniStreamDestroy_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamDestroy is not supported on this platform.");
                };
            }
            oniStreamDestroy_fptr(@stream);
        };
        /// <summary>Destroy an existing stream</summary>
        internal static void oniStreamDestroy(_OniStream* @stream)
        {
            oniStreamDestroy_fptr(@stream);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniStreamGetProperty_delegate(_OniStream* @stream, int @propertyId, void* @data, int* @pDataSize);
        private static oniStreamGetProperty_delegate oniStreamGetProperty_fptr = (_OniStream* @stream, int @propertyId, void* @data, int* @pDataSize) =>
        {
            oniStreamGetProperty_fptr = GetFunctionDelegate<oniStreamGetProperty_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamGetProperty");
            if (oniStreamGetProperty_fptr == null)
            {
                oniStreamGetProperty_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamGetProperty is not supported on this platform.");
                };
            }
            return oniStreamGetProperty_fptr(@stream, @propertyId, @data, @pDataSize);
        };
        /// <summary>Get property in the stream. Use the properties listed in OniTypes.h: ONI_STREAM_PROPERTY_..., or specific ones supplied by the device for its streams.</summary>
        internal static OniStatus oniStreamGetProperty(_OniStream* @stream, int @propertyId, void* @data, int* @pDataSize)
        {
            return oniStreamGetProperty_fptr(@stream, @propertyId, @data, @pDataSize);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniSensorInfo* oniStreamGetSensorInfo_delegate(_OniStream* @stream);
        private static oniStreamGetSensorInfo_delegate oniStreamGetSensorInfo_fptr = (_OniStream* @stream) =>
        {
            oniStreamGetSensorInfo_fptr = GetFunctionDelegate<oniStreamGetSensorInfo_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamGetSensorInfo");
            if (oniStreamGetSensorInfo_fptr == null)
            {
                oniStreamGetSensorInfo_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamGetSensorInfo is not supported on this platform.");
                };
            }
            return oniStreamGetSensorInfo_fptr(@stream);
        };
        /// <summary>Get the OniSensorInfo of the certain stream.</summary>
        internal static OniSensorInfo* oniStreamGetSensorInfo(_OniStream* @stream)
        {
            return oniStreamGetSensorInfo_fptr(@stream);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniStreamInvoke_delegate(_OniStream* @stream, int @commandId, void* @data, int @dataSize);
        private static oniStreamInvoke_delegate oniStreamInvoke_fptr = (_OniStream* @stream, int @commandId, void* @data, int @dataSize) =>
        {
            oniStreamInvoke_fptr = GetFunctionDelegate<oniStreamInvoke_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamInvoke");
            if (oniStreamInvoke_fptr == null)
            {
                oniStreamInvoke_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamInvoke is not supported on this platform.");
                };
            }
            return oniStreamInvoke_fptr(@stream, @commandId, @data, @dataSize);
        };
        /// <summary>Invoke an internal functionality of the stream.</summary>
        internal static OniStatus oniStreamInvoke(_OniStream* @stream, int @commandId, void* @data, int @dataSize)
        {
            return oniStreamInvoke_fptr(@stream, @commandId, @data, @dataSize);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int oniStreamIsCommandSupported_delegate(_OniStream* @stream, int @commandId);
        private static oniStreamIsCommandSupported_delegate oniStreamIsCommandSupported_fptr = (_OniStream* @stream, int @commandId) =>
        {
            oniStreamIsCommandSupported_fptr = GetFunctionDelegate<oniStreamIsCommandSupported_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamIsCommandSupported");
            if (oniStreamIsCommandSupported_fptr == null)
            {
                oniStreamIsCommandSupported_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamIsCommandSupported is not supported on this platform.");
                };
            }
            return oniStreamIsCommandSupported_fptr(@stream, @commandId);
        };
        /// <summary>Check if a command is supported, for invoke</summary>
        internal static int oniStreamIsCommandSupported(_OniStream* @stream, int @commandId)
        {
            return oniStreamIsCommandSupported_fptr(@stream, @commandId);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int oniStreamIsPropertySupported_delegate(_OniStream* @stream, int @propertyId);
        private static oniStreamIsPropertySupported_delegate oniStreamIsPropertySupported_fptr = (_OniStream* @stream, int @propertyId) =>
        {
            oniStreamIsPropertySupported_fptr = GetFunctionDelegate<oniStreamIsPropertySupported_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamIsPropertySupported");
            if (oniStreamIsPropertySupported_fptr == null)
            {
                oniStreamIsPropertySupported_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamIsPropertySupported is not supported on this platform.");
                };
            }
            return oniStreamIsPropertySupported_fptr(@stream, @propertyId);
        };
        /// <summary>Check if the property is supported the stream. Use the properties listed in OniTypes.h: ONI_STREAM_PROPERTY_..., or specific ones supplied by the device for its streams.</summary>
        internal static int oniStreamIsPropertySupported(_OniStream* @stream, int @propertyId)
        {
            return oniStreamIsPropertySupported_fptr(@stream, @propertyId);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniStreamReadFrame_delegate(_OniStream* @stream, OniFrame** @pFrame);
        private static oniStreamReadFrame_delegate oniStreamReadFrame_fptr = (_OniStream* @stream, OniFrame** @pFrame) =>
        {
            oniStreamReadFrame_fptr = GetFunctionDelegate<oniStreamReadFrame_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamReadFrame");
            if (oniStreamReadFrame_fptr == null)
            {
                oniStreamReadFrame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamReadFrame is not supported on this platform.");
                };
            }
            return oniStreamReadFrame_fptr(@stream, @pFrame);
        };
        /// <summary>Get the next frame from the stream. This function is blocking until there is a new frame from the stream. For timeout, use oniWaitForStreams() first</summary>
        internal static OniStatus oniStreamReadFrame(_OniStream* @stream, OniFrame** @pFrame)
        {
            return oniStreamReadFrame_fptr(@stream, @pFrame);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniStreamRegisterNewFrameCallback_delegate(_OniStream* @stream, void* @handler, void* @pCookie, OniCallbackHandleImpl** @pHandle);
        private static oniStreamRegisterNewFrameCallback_delegate oniStreamRegisterNewFrameCallback_fptr = (_OniStream* @stream, void* @handler, void* @pCookie, OniCallbackHandleImpl** @pHandle) =>
        {
            oniStreamRegisterNewFrameCallback_fptr = GetFunctionDelegate<oniStreamRegisterNewFrameCallback_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamRegisterNewFrameCallback");
            if (oniStreamRegisterNewFrameCallback_fptr == null)
            {
                oniStreamRegisterNewFrameCallback_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamRegisterNewFrameCallback is not supported on this platform.");
                };
            }
            return oniStreamRegisterNewFrameCallback_fptr(@stream, @handler, @pCookie, @pHandle);
        };
        /// <summary>Register a callback to when the stream has a new frame.</summary>
        internal static OniStatus oniStreamRegisterNewFrameCallback(_OniStream* @stream, void* @handler, void* @pCookie, OniCallbackHandleImpl** @pHandle)
        {
            return oniStreamRegisterNewFrameCallback_fptr(@stream, @handler, @pCookie, @pHandle);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniStreamSetFrameBuffersAllocator_delegate(_OniStream* @stream, void* @alloc, void* @free, void* @pCookie);
        private static oniStreamSetFrameBuffersAllocator_delegate oniStreamSetFrameBuffersAllocator_fptr = (_OniStream* @stream, void* @alloc, void* @free, void* @pCookie) =>
        {
            oniStreamSetFrameBuffersAllocator_fptr = GetFunctionDelegate<oniStreamSetFrameBuffersAllocator_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamSetFrameBuffersAllocator");
            if (oniStreamSetFrameBuffersAllocator_fptr == null)
            {
                oniStreamSetFrameBuffersAllocator_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamSetFrameBuffersAllocator is not supported on this platform.");
                };
            }
            return oniStreamSetFrameBuffersAllocator_fptr(@stream, @alloc, @free, @pCookie);
        };
        /// <summary>Sets the stream buffer allocation functions. Note that this function may only be called while stream is not started.</summary>
        internal static OniStatus oniStreamSetFrameBuffersAllocator(_OniStream* @stream, void* @alloc, void* @free, void* @pCookie)
        {
            return oniStreamSetFrameBuffersAllocator_fptr(@stream, @alloc, @free, @pCookie);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniStreamSetProperty_delegate(_OniStream* @stream, int @propertyId, void* @data, int @dataSize);
        private static oniStreamSetProperty_delegate oniStreamSetProperty_fptr = (_OniStream* @stream, int @propertyId, void* @data, int @dataSize) =>
        {
            oniStreamSetProperty_fptr = GetFunctionDelegate<oniStreamSetProperty_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamSetProperty");
            if (oniStreamSetProperty_fptr == null)
            {
                oniStreamSetProperty_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamSetProperty is not supported on this platform.");
                };
            }
            return oniStreamSetProperty_fptr(@stream, @propertyId, @data, @dataSize);
        };
        /// <summary>Set property in the stream. Use the properties listed in OniTypes.h: ONI_STREAM_PROPERTY_..., or specific ones supplied by the device for its streams.</summary>
        internal static OniStatus oniStreamSetProperty(_OniStream* @stream, int @propertyId, void* @data, int @dataSize)
        {
            return oniStreamSetProperty_fptr(@stream, @propertyId, @data, @dataSize);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniStreamStart_delegate(_OniStream* @stream);
        private static oniStreamStart_delegate oniStreamStart_fptr = (_OniStream* @stream) =>
        {
            oniStreamStart_fptr = GetFunctionDelegate<oniStreamStart_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamStart");
            if (oniStreamStart_fptr == null)
            {
                oniStreamStart_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamStart is not supported on this platform.");
                };
            }
            return oniStreamStart_fptr(@stream);
        };
        /// <summary>Start generating data from the stream.</summary>
        internal static OniStatus oniStreamStart(_OniStream* @stream)
        {
            return oniStreamStart_fptr(@stream);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void oniStreamStop_delegate(_OniStream* @stream);
        private static oniStreamStop_delegate oniStreamStop_fptr = (_OniStream* @stream) =>
        {
            oniStreamStop_fptr = GetFunctionDelegate<oniStreamStop_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamStop");
            if (oniStreamStop_fptr == null)
            {
                oniStreamStop_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamStop is not supported on this platform.");
                };
            }
            oniStreamStop_fptr(@stream);
        };
        /// <summary>Stop generating data from the stream.</summary>
        internal static void oniStreamStop(_OniStream* @stream)
        {
            oniStreamStop_fptr(@stream);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void oniStreamUnregisterNewFrameCallback_delegate(_OniStream* @stream, OniCallbackHandleImpl* @handle);
        private static oniStreamUnregisterNewFrameCallback_delegate oniStreamUnregisterNewFrameCallback_fptr = (_OniStream* @stream, OniCallbackHandleImpl* @handle) =>
        {
            oniStreamUnregisterNewFrameCallback_fptr = GetFunctionDelegate<oniStreamUnregisterNewFrameCallback_delegate>(GetOrLoadLibrary("OpenNI2"), "oniStreamUnregisterNewFrameCallback");
            if (oniStreamUnregisterNewFrameCallback_fptr == null)
            {
                oniStreamUnregisterNewFrameCallback_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniStreamUnregisterNewFrameCallback is not supported on this platform.");
                };
            }
            oniStreamUnregisterNewFrameCallback_fptr(@stream, @handle);
        };
        /// <summary>Unregister a previously registered callback to when the stream has a new frame.</summary>
        internal static void oniStreamUnregisterNewFrameCallback(_OniStream* @stream, OniCallbackHandleImpl* @handle)
        {
            oniStreamUnregisterNewFrameCallback_fptr(@stream, @handle);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void oniUnregisterDeviceCallbacks_delegate(OniCallbackHandleImpl* @handle);
        private static oniUnregisterDeviceCallbacks_delegate oniUnregisterDeviceCallbacks_fptr = (OniCallbackHandleImpl* @handle) =>
        {
            oniUnregisterDeviceCallbacks_fptr = GetFunctionDelegate<oniUnregisterDeviceCallbacks_delegate>(GetOrLoadLibrary("OpenNI2"), "oniUnregisterDeviceCallbacks");
            if (oniUnregisterDeviceCallbacks_fptr == null)
            {
                oniUnregisterDeviceCallbacks_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniUnregisterDeviceCallbacks is not supported on this platform.");
                };
            }
            oniUnregisterDeviceCallbacks_fptr(@handle);
        };
        internal static void oniUnregisterDeviceCallbacks(OniCallbackHandleImpl* @handle)
        {
            oniUnregisterDeviceCallbacks_fptr(@handle);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate OniStatus oniWaitForAnyStream_delegate(_OniStream** @pStreams, int @numStreams, int* @pStreamIndex, int @timeout);
        private static oniWaitForAnyStream_delegate oniWaitForAnyStream_fptr = (_OniStream** @pStreams, int @numStreams, int* @pStreamIndex, int @timeout) =>
        {
            oniWaitForAnyStream_fptr = GetFunctionDelegate<oniWaitForAnyStream_delegate>(GetOrLoadLibrary("OpenNI2"), "oniWaitForAnyStream");
            if (oniWaitForAnyStream_fptr == null)
            {
                oniWaitForAnyStream_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("oniWaitForAnyStream is not supported on this platform.");
                };
            }
            return oniWaitForAnyStream_fptr(@pStreams, @numStreams, @pStreamIndex, @timeout);
        };
        /// <summary>Wait for any of the streams to have a new frame</summary>
        internal static OniStatus oniWaitForAnyStream(_OniStream** @pStreams, int @numStreams, int* @pStreamIndex, int @timeout)
        {
            return oniWaitForAnyStream_fptr(@pStreams, @numStreams, @pStreamIndex, @timeout);
        }
        
        
    }
}

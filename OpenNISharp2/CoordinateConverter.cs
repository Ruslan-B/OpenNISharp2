using OpenNISharp2.Native;

namespace OpenNISharp2
{
    internal static class CoordinateConverter
    {
        public static unsafe void DepthToWorld(SensorStream depthStream, float depthX, float depthY, float depthZ, ref float worldX, ref float worldY, ref float worldZ)
        {
            fixed (float* pWorldX = &worldX)
            fixed (float* pWorldY = &worldY)
            fixed (float* pWorldZ = &worldZ)
            {
                OniCAPI.oniCoordinateConverterDepthToWorld(depthStream.Handler, depthX, depthY, depthZ, pWorldX, pWorldY, pWorldZ).ThrowExectionIfStatusIsNotOk();
            }
        }

        public static unsafe void DepthToColor(SensorStream depthStream, SensorStream colorStream, int depthX, int depthY, ushort depthZ, ref int colorX, ref int colorY)
        {
            fixed (int* pColorX = &colorX)
            fixed (int* pColorY = &colorY)
            {
                OniCAPI.oniCoordinateConverterDepthToColor(depthStream.Handler, colorStream.Handler, depthX, depthY, depthZ, pColorX, pColorY).ThrowExectionIfStatusIsNotOk();
            }
        }

        public static unsafe void WorldToDepth(SensorStream depthStream, float worldX, float worldY, float worldZ, ref float depthX, ref float depthY, ref float depthZ)
        {
            fixed (float* pDepthX = &depthX)
            fixed (float* pDepthY = &depthY)
            fixed (float* pDepthZ = &depthZ)
            {
                OniCAPI.oniCoordinateConverterWorldToDepth(depthStream.Handler, worldX, worldY, worldZ, pDepthX, pDepthY, pDepthZ).ThrowExectionIfStatusIsNotOk();
            }
        }
    }
}
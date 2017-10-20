using OpenNISharp2.Native;

namespace OpenNISharp2
{
    public struct Cropping
    {
        public bool Enabled;
        public int OriginX;
        public int OriginY;
        public int Width;
        public int Height;
    }

    internal static class CroppingExtensions
    {
        public static Cropping ToManaged(this OniCropping oniCroppting)
            => new Cropping
            {
                Enabled = oniCroppting.enabled == 1,
                OriginX = oniCroppting.originX,
                OriginY = oniCroppting.originY,
                Width = oniCroppting.width,
                Height = oniCroppting.height
            };

        public static OniCropping ToNative(this Cropping croppting)
            => new OniCropping
            {
                enabled = croppting.Enabled ? 1 : 0,
                originX = croppting.OriginX,
                originY = croppting.OriginY,
                width = croppting.Width,
                height = croppting.Height
            };
    }
}
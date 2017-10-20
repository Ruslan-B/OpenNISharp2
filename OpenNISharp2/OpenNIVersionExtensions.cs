using OpenNISharp2.Native;

namespace OpenNISharp2
{
    internal static class OpenNIVersionExtensions
    {
        public static OpenNIVersion ToManaged(this OniVersion oniVersion)
            => new OpenNIVersion
            {
                Major = oniVersion.major,
                Minor = oniVersion.minor,
                Maintenance = oniVersion.maintenance,
                Build = oniVersion.build
            };
    }
}
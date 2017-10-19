namespace OpenNISharp2
{
    internal static class OpenNIVersionExtensions
    {
        public static OpenNIVersion ToManaged(this Native.OniVersion oniVersion)
        {
            return new OpenNIVersion {
                Major = oniVersion.major,
                Minor = oniVersion.minor,
                Maintenance = oniVersion.maintenance,
                Build = oniVersion.build
            };
        }
    }
}
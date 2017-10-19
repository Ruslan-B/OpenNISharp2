using System.Linq;
using System.Text;
using OpenNISharp2.Native;

namespace OpenNISharp2
{
    internal static class ArrayExtensions
    {
        public static string ToManaged(this byte_array256 @this)
        {
            var zeroTerminatedString = @this.ToArray().TakeWhile(x => x != 0).ToArray();
            return Encoding.ASCII.GetString(zeroTerminatedString);
        }
    }
}
using System.Drawing;
using System.Runtime.CompilerServices;
using APK_QSigner.Properties;

namespace APK_QSigner
{
    public class ResourceManager
    {
        public static Bitmap GetImageFromResources(string resource)
        {
            return (Bitmap) Resources.ResourceManager.GetObject("logo");
        }

        public static Icon BitmapToIcon(Bitmap bmp)
        {
            return Icon.FromHandle(bmp.GetHicon());
        }
    }
}
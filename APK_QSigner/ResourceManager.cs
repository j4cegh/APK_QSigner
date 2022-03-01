using System.Drawing;
using APK_QSigner.Properties;

namespace APK_QSigner
{
    /// <summary>
    /// A little class to help with the resources of the app.
    /// </summary>
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
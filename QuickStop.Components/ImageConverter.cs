using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace QuickStop.Components
{
    public static class ImageConverter
    {
        public static Image ConvertToImage(this string base64)
        {
            try
            {
                using (var ms = new MemoryStream(Convert.FromBase64String(base64)))
                {
                    return Image.FromStream(ms);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return null;
            }
        }
    }
}

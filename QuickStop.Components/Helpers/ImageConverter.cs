using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace QuickStop.Components.Helpers
{
    /// <summary>
    /// Allows Extension to convert an <see cref="Image"/> from a base-64 <see cref="string"/>.
    /// </summary>
    public static class ImageConverter
    {
        /// <summary>
        /// Converts an <see cref="Image"/> with a given base-64 string.
        /// </summary>
        /// <param name="base64">The string to be converted with.</param>
        /// <returns>If no errors persists, it returns an <see cref="Image"/>. Otherwise, <see langword="null"/> is returned.</returns>
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

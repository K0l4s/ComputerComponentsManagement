using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public static class DataConvert
    {
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        public static byte[] ImgToByteArray(Image img)
        {
            if (img != null)
            {
                Bitmap bmp = new Bitmap(img);
                using (var ms = new MemoryStream())
                {
                    bmp.Save(ms, img.RawFormat);
                    return ms.ToArray();
                }
            }
            else
                return null;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
namespace CZE_API.Util
{
    public class UIHelper
    {
        public static string GenerateSalt(int length=16)
        {
            byte[] arr = new byte[length];
            RNGCryptoServiceProvider cripto = new RNGCryptoServiceProvider();
            cripto.GetBytes(arr);
            return Convert.ToBase64String(arr);
        }
        public static string GenerateHash(string lozinka, string salt)
        {
            byte[] pass = Encoding.Unicode.GetBytes(lozinka);
            byte[] dodatak = Convert.FromBase64String(salt);
            byte[] forHash = new byte[pass.Length + dodatak.Length];

            System.Buffer.BlockCopy(pass, 0, forHash,0, pass.Length);
            System.Buffer.BlockCopy(dodatak, 0, forHash, pass.Length, dodatak.Length);

            HashAlgorithm hAlg = HashAlgorithm.Create("SHA1");
            byte[] hashed= hAlg.ComputeHash(forHash);
            return Convert.ToBase64String(hashed);

        }

        #region Slike
        public static Image CropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
                bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        #endregion
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection;
using System.Drawing;
using System.IO;


namespace UnitTestEdgeDetection
{
    [TestClass]
    public class UnitTestEdgeDetection
    {
        [TestMethod]
        public void TestPixelByPixel()
        {
            Bitmap originalBitmap;
            Bitmap imageToTransforme;
            Bitmap resultImage;
            //Take image already processed
            originalBitmap = Properties.Resources.test;

            //Take image wich will be process
            imageToTransforme = Properties.Resources._2016_10_21_14_59_46_X_Treme_X_Men__2012___4;

            resultImage = imageToTransforme.Laplacian3x3Filter(false);//Run Edge Detection
            //Compare pixel by pixel
            for (int width = 0; width < originalBitmap.Width; width++)
            {
                for (int height = 0; height < originalBitmap.Height; height++)
                {
                    Assert.AreEqual(originalBitmap.GetPixel(width, height), resultImage.GetPixel(width, height));
                }
            }
        }
    }
}

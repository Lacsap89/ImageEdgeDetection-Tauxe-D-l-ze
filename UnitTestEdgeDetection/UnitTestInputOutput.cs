using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection.Business;
using ImageEdgeDetection.Input_Output;
using System.Drawing;
using NSubstitute;
using System.Runtime.InteropServices;

namespace UnitTestEdgeDetection
{
    [TestClass]
    public class UnitTestInputOutput
    {
        [TestMethod]
        public void TestInput()
        {
            LaplacianFilter3x3 laf = new LaplacianFilter3x3();
            var importImage = Substitute.For< IImageManipulation > ();
            importImage.ImportBitmap();

            Bitmap bmp = laf.importImage();

            Assert.IsNotNull(bmp);
        }

        [TestMethod]
        public void TestOutput()
        {
            LaplacianFilter3x3 laf = new LaplacianFilter3x3();
            Bitmap image = new Bitmap(200,200);
            var importImage = Substitute.For<IImageManipulation>();
            importImage.SaveBitmap(image);

            laf.saveBitmap(image);

            //Assert.IsNotNull(bmp);
        }
        [TestMethod]
        public void TestOutput2()
        {
            LaplacianFilter3x3 laf = new LaplacianFilter3x3();
           // Bitmap image = importImageTest();
            Bitmap image = null;
            var importImage = Substitute.For<IImageManipulation>();
            importImage.SaveBitmap(image);

            laf.saveBitmap(image);

            Assert.IsNotNull(image); //TODO A CHANGER !!!
        }


        [TestMethod]
        public void TestOutputException()
        { 
            
            Bitmap image = new Bitmap(200, 200);
            var importImage = Substitute.For<IImageManipulation>();
            LaplacianFilter3x3 laf = new LaplacianFilter3x3(importImage);
            // importImage.SaveBitmap(image);
            importImage.When(x => x.SaveBitmap(image)).Do(x => { throw new NullReferenceException();});

            laf.saveBitmap(image);

            Assert.AreEqual(laf.isNullReferenceException, true);
        }

        public Bitmap importImageTest()
        {
            LaplacianFilter3x3 laf = new LaplacianFilter3x3();
            var importImage = Substitute.For<IImageManipulation>();
            importImage.ImportBitmap();

            Bitmap bmp = laf.importImage();
            return bmp;
        }


    }
}

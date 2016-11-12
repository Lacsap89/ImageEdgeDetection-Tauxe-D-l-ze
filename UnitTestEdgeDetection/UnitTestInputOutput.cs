using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection.Input_Output;
using System.Drawing;

namespace UnitTestEdgeDetection
{
    [TestClass]
    public class UnitTestInputOutput
    {
        [TestMethod]
        public void TestInput()
        {
            InputOutputFile iof = new InputOutputFile();
            iof.ImportBitmap();
        }

        [TestMethod]
        public void TestOutput()
        {
           InputOutputFile iof = new InputOutputFile();
            
            Bitmap img = iof.ImportBitmap();
            iof.SaveBitmap(img);
        }
    }
}

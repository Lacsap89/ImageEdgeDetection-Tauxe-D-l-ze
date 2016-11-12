using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Input_Output
{
    public interface IImageManipulation
    {
        Bitmap ImportBitmap();
        void SaveBitmap(Bitmap image); 
    }
}

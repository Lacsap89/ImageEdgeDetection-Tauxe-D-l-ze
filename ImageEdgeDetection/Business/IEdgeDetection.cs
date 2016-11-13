using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ImageEdgeDetection.Business
{
   public interface IEdgeDetection
    {
        Bitmap ApplyFilter(Bitmap originalImage);
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Business
{
    public class LaplacianFilter3x3 : IEdgeDetection
    {
        public Bitmap ApplyFilter(Bitmap originalImage)
        {
            Bitmap filteredImage = originalImage;
            filteredImage = filteredImage.Laplacian3x3Filter(false);
            return filteredImage;
        }
    }
}

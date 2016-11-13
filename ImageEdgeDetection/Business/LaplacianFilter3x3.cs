using ImageEdgeDetection.Input_Output;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ImageEdgeDetection.Business
{
    public class LaplacianFilter3x3 : IEdgeDetection
    {
        IImageManipulation image_IO;

        public LaplacianFilter3x3()
        {
            image_IO = new InputOutputFile();
        }
        public Bitmap ApplyFilter(Bitmap originalImage)
        {
            Bitmap filteredImage = originalImage;
            filteredImage = filteredImage.Laplacian3x3Filter(false);
            return filteredImage;
        }

       public Bitmap importImage()
        {
            return image_IO.ImportBitmap();
        }

        public void saveBitmap(Bitmap image)
        {
            
            try
            {
                image_IO.SaveBitmap(image);
            }
            catch(Exception e)
            {
                
                image = null;
                
            }

           
        }
    }
}

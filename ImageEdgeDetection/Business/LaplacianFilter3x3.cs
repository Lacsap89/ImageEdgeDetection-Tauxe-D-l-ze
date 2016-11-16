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
        private IImageManipulation image_IO;
        public Boolean isNullReferenceException = false;
        public LaplacianFilter3x3()
        {
            image_IO = new InputOutputFile();
        }

        public LaplacianFilter3x3(IImageManipulation Iimage)
        {
            image_IO = Iimage;
            


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
            isNullReferenceException = false;
            try
            {
                image_IO.SaveBitmap(image);
            }

            catch(NullReferenceException nre)
            {
                isNullReferenceException = true;
            }

           
        }
    }
}

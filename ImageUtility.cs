using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    public class ImageUtility
    {
        private string name;
        private Image<Bgr, byte> image;
        private int[] red = new int[256];
        private int[] green = new int[256];
        private int[] blue = new int[256];
        private int histMax = 0;
        private int histMin = 0;
        private Boolean isGray;
        
        
        public ImageUtility(String name, Image<Bgr, byte> image)
        {
            this.name = name;
            this.image = image;


            Bitmap img = image.ToBitmap();
            for (int height = 0; height < img.Height; ++height)
            {
                for (int width = 0; width < img.Width; ++width)
                {
                    ++red[(int) img.GetPixel(width, height).R];
                    ++green[(int) img.GetPixel(width, height).G];
                    ++blue[(int) img.GetPixel(width, height).B];
                }
            }
            this.isGray = checkIsGrayScale();
            if (isGray)
            {
                for (int i = 0; i < 256; i++)
                {
                    if (this.red[i] != 0)
                    {
                        this.histMin = i;
                        break;
                    }
                }

                for (int i = 255; i >= 0; i--)
                {
                    if (this.red[i] != 0)
                    {
                        this.histMax = i;
                        break;
                    }
                }
            }
        }

        public Boolean checkIsGrayScale()
        {
            Boolean isTrue = true;

            for (int i = 0; i < red.Length; ++i)
            {
                if (red[i] != green[i] && red[i] != blue[i] && green[i] != blue[i]) isTrue = false;
            }

            return isTrue;
        }

        //Gettery i Settery
        public string getName { get { return name; } }
        public void setName(string name) { this.name = name; }
        public Image<Bgr, byte> getImage { get { return image; } } 
        public int[] getRed() { return red; }
        public int[] getGreen() { return green; }
        public int[] getBlue() { return blue; }
        public int getHistMin() { return histMin; }
        public int getHistMax() { return histMax; }
        public Boolean getIsGray() { return isGray; }

    }
}

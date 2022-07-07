using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace APO
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            custoimizeDesign();
        }

        Dictionary<string, ImageUtility> images = new Dictionary<string, ImageUtility>();
        Histogram histogram = new Histogram();

        #region functionalButtons
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btMaximize.Visible = false;
            btRestoreDown.Visible = true;
        }

        private void btRestoreDown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btRestoreDown.Visible = false;
            btMaximize.Visible = true;
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region mouseMove
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void panelListWorkSpace_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelListWorkSpace_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panelListWorkSpace_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }
        #endregion

        #region subMenu
        private void custoimizeDesign()
        {
            panelFile.Visible = false;
            panelImage.Visible = false;
            panelOperations.Visible = false;
            panelSmooth.Visible = false;
            panelSharp.Visible = false;
            panelSegmentation.Visible = false;
            panelSteganography.Visible = false;
            
        }
        private void hideSubMenu()
        {
            if(panelFile.Visible) panelFile.Visible = false;
            if(panelImage.Visible) panelImage.Visible = false;
            if(panelOperations.Visible) panelOperations.Visible = false;
            if(panelSmooth.Visible) panelSmooth.Visible = false;
            if(panelSharp.Visible) panelSharp.Visible = false;
            if(panelSegmentation.Visible) panelSegmentation.Visible = false;
            if(panelSteganography.Visible) panelSteganography.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
        #endregion

        #region btFile
        private void btFile_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFile);
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.Filter = "Image File (*.bmp, *.png, *.jpg)| *.bmp;*.png;*.jpg;";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                string name = openFileDialog.SafeFileName;
                Image<Bgr, byte> image = new Image<Bgr, byte>(openFileDialog.FileName);

                int index = name.IndexOf('.');
                if (index >= 0)
                    name = name.Substring(0, index);

                addTab(new ImageUtility(name, image));
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tcWorkSpace.TabCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Image File (*.bmp, *.png, *.jpg)| *.bmp;*.png;*.jpg;";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    images[tcWorkSpace.SelectedTab.Text].getImage.Save(saveFileDialog.FileName);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {    
            if(tcWorkSpace.TabCount > 0)
                tcWorkSpace.TabPages.Remove(tcWorkSpace.SelectedTab);          
        }

        private void tcWorkSpace_ControlAdded(object sender, ControlEventArgs e)
        {
            tcWorkSpace.SelectTab(tcWorkSpace.Controls.Count-1);
            string name = e.Control.Text;
            e.Control.BackColor = Color.FromArgb(1, 17, 17, 17);
            e.Control.Controls.Add(createPictureBox(images[name].getImage, name));

            if(tcWorkSpace.TabCount == 1)
                histogram.updateHistogram(images[tcWorkSpace.SelectedTab.Text]);

        }

        private void tcWorkSpace_ControlRemoved(object sender, ControlEventArgs e)
        {
            images.Remove(e.Control.Text);

            if (tcWorkSpace.TabCount == 1)
                histogram.clearHistogram();
        }

        #endregion

        #region btImage
        private void btImage_Click(object sender, EventArgs e)
        {
            showSubMenu(panelImage);
        }

        private void btDuplicate_Click(object sender, EventArgs e)
        {
         
            if (tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text;
                Image<Bgr, byte> image = images[name].getImage;
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                     name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }

        private void btHistogram_Click(object sender, EventArgs e)
        {
            if(histogram.Visible) histogram.Visible = false;
            else histogram.Visible = true;
        }

        private void tcWorkSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tcWorkSpace.TabCount > 0) 
                histogram.updateHistogram(images[tcWorkSpace.SelectedTab.Text]);            
        }

        private void btLnStrHistogram_Click(object sender, EventArgs e)
        {
            if (tcWorkSpace.TabCount > 0 && images[tcWorkSpace.SelectedTab.Text].getIsGray())
            {
                String name = tcWorkSpace.SelectedTab.Text + "_stretch";
                Image<Bgr, byte> image = lnStrHistogram(images[tcWorkSpace.SelectedTab.Text]).ToImage<Bgr, byte>();
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
            else if (tcWorkSpace.TabCount > 0 && !images[tcWorkSpace.SelectedTab.Text].getIsGray())
                MessageBox.Show("Only Gray images!");
        }

        private void btEqualHistogram_Click(object sender, EventArgs e)
        {
            if (tcWorkSpace.TabCount > 0 && images[tcWorkSpace.SelectedTab.Text].getIsGray())
            {
                String name = tcWorkSpace.SelectedTab.Text + "_equal";
                Image<Bgr, byte> image = equalHistogram(images[tcWorkSpace.SelectedTab.Text]).ToImage<Bgr, byte>();
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
            else if (tcWorkSpace.TabCount > 0 && !images[tcWorkSpace.SelectedTab.Text].getIsGray())
                MessageBox.Show("Only Gray images!");
        }
        #endregion

        #region btOperations

        private void btOperations_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOperations);
        }

        private void btToMono_Click(object sender, EventArgs e)
        {
            if (tcWorkSpace.TabCount > 0 && !images[tcWorkSpace.SelectedTab.Text].getIsGray())
            {
                String name = tcWorkSpace.SelectedTab.Text + "_gray";
                Image<Bgr, byte> image = toMonoImg(images[tcWorkSpace.SelectedTab.Text].getImage.ToBitmap()).ToImage<Bgr, byte>();
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
            else if (tcWorkSpace.TabCount > 0 && images[tcWorkSpace.SelectedTab.Text].getIsGray())
                MessageBox.Show("Only color images!");
        }

        private void btNegative_Click(object sender, EventArgs e)
        {
            if (tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_negative";
                Image<Bgr, byte> image = negative(images[tcWorkSpace.SelectedTab.Text].getImage.ToBitmap()).ToImage<Bgr, byte>();
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }

        private void btThresholding_Click(object sender, EventArgs e)
        {
            Threshold threshold = new Threshold();
            threshold.ShowDialog();
            if(threshold.IsSet() && tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_threshold";
                Image<Bgr, byte> image = thresholding(images[tcWorkSpace.SelectedTab.Text].getImage.ToBitmap()
                    , threshold.getLMin(), threshold.getLMax()).ToImage<Bgr, byte>();
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }

        private void btThresholdingGray_Click(object sender, EventArgs e)
        {
            Threshold threshold = new Threshold();
            threshold.Text = "Threshold (Gray)";
            threshold.ShowDialog();
            if (threshold.IsSet() && tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_thresholdgray";
                Image<Bgr, byte> image = thresholdingGray(images[tcWorkSpace.SelectedTab.Text].getImage.ToBitmap()
                    , threshold.getLMin(), threshold.getLMax()).ToImage<Bgr, byte>();
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }

        private void btPosterize_Click(object sender, EventArgs e)
        {
            Posterize post = new Posterize();
            post.ShowDialog();
            if (tcWorkSpace.TabCount > 0 && post.getLevel() > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_posterize";
                Image<Bgr, byte> image = 
                    posterize(images[tcWorkSpace.SelectedTab.Text].getImage.ToBitmap(), post.getLevel()).ToImage<Bgr, byte>();
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }
        private void btSkeletonize_Click(object sender, EventArgs e)
        {
            if (tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_skeletonize";
                Image<Gray, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Copy().Convert<Gray, byte>();
                Image<Gray, byte> image2 = (new Image<Gray, byte>(image.Width, image.Height, new Gray(255))).Sub(image);
                Image<Gray, byte> eroded = new Image<Gray, byte>(image2.Size);
                Image<Gray, byte> temp = new Image<Gray, byte>(image2.Size);
                Image<Gray, byte> skel = new Image<Gray, byte>(image.Size);
                skel.SetValue(0);
                CvInvoke.Threshold(image2, image2, 127, 256, 0);
                var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
                bool done = false;

                while (!done)
                {
                    CvInvoke.Erode(image2, eroded, element, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar));
                    CvInvoke.Dilate(eroded, temp, element, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar));
                    CvInvoke.Subtract(image2, temp, temp);
                    CvInvoke.BitwiseOr(skel, temp, skel);
                    eroded.CopyTo(image2);
                    if (CvInvoke.CountNonZero(image2) == 0)
                        done = true;
                }

                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, skel.Convert<Bgr, byte>()));
            }
        }

        private void btDilate_Click(object sender, EventArgs e)
        {
            
            if (tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_dilate";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Dilate(1);
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }

        #endregion

        #region btSmooth
        private void btSmooth_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSmooth);
        }

        private void btBlur_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur();
            blur.ShowDialog();
            if (blur.IsSet && tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_blur";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.SmoothBlur(blur.getWidthX, blur.getWidthY);
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }

        private void btGaussianBlur_Click(object sender, EventArgs e)
        {
            GaussianBlur gB = new GaussianBlur();
            gB.ShowDialog();
            if (gB.IsSet && tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_gblur";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Clone();
                CvInvoke.GaussianBlur(image, image, 
                    new Size(gB.getRadius, gB.getRadius), gB.getSigmaX, gB.getSigmaY, gB.getBorderType());
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }

        private void btMedian_Click(object sender, EventArgs e)
        {
            MedianBlur medianBlur = new MedianBlur();
            medianBlur.ShowDialog();
            if (medianBlur.getK > 0 && tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_mblur";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Clone();
                CvInvoke.MedianBlur(image, image, medianBlur.getK);
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }
        #endregion

        #region btSharp
        private void btSharp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSharp);
        }
        private void btSobel_Click(object sender, EventArgs e)
        {
            Laplacian sobel = new Laplacian();
            sobel.Text = "Sobel";
            sobel.ShowDialog();
            if (sobel.IsSet && tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_sobel";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Clone();
                CvInvoke.Sobel(image, image, sobel.getDepthType(), 1, 1, sobel.getKernel);
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }
        private void btLaplacian_Click(object sender, EventArgs e)
        {
            Laplacian laplacian = new Laplacian();
            laplacian.ShowDialog();
            if (laplacian.IsSet && tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_laplacian";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Clone();
                CvInvoke.Laplacian(image, image, laplacian.getDepthType(), laplacian.getKernel, 1, 0, Emgu.CV.CvEnum.BorderType.Replicate);
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }
        private void btCanny_Click(object sender, EventArgs e)
        {
            Threshold threshold = new Threshold();
            threshold.Text = "Canny";
            threshold.ShowDialog();
            if (threshold.IsSet() && tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_canny";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Clone();
                Image<Bgr, byte> newimage = image.Canny(threshold.getLMin(), threshold.getLMax()).Convert<Bgr, byte>();
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, newimage));
            }
        }
        private void btPrewitt_Click(object sender, EventArgs e)
        {
            Prewitt prewitt = new Prewitt();
            prewitt.ShowDialog();
            if(prewitt.IsSet && tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_canny";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Clone();
                CvInvoke.Filter2D(image, image, new ConvolutionKernelF(prewitt.GetArray2d()), new Point(-1, -1), 0, Emgu.CV.CvEnum.BorderType.Replicate);
                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }
        #endregion

        #region Segmentation
        
        private void btSegmentation_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSegmentation);
        }
        private void btWatershed_Click(object sender, EventArgs e)
        {
            if (tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_watershed";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Copy();
                var mask = image.Copy().Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
                Mat distanceTransform = new Mat();
                CvInvoke.DistanceTransform(mask, distanceTransform, null, Emgu.CV.CvEnum.DistType.L2, 3);
                CvInvoke.Normalize(distanceTransform, distanceTransform, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);
                var markers = distanceTransform.ToImage<Gray, byte>().ThresholdBinary(new Gray(50), new Gray(255));
                CvInvoke.ConnectedComponents(markers, markers);
                var finalMarkers = markers.Convert<Gray, Int32>();
                CvInvoke.Watershed(image, finalMarkers);

                Image<Gray, byte> boundaries = finalMarkers.Convert<byte>(delegate (Int32 x)
                {
                    return (byte)(x == -1 ? 255 : 0);
                });
                boundaries.Dilate(2);
                image.SetValue(new Bgr(0, 255, 0), boundaries);

                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }
        private void btOtsu_Click(object sender, EventArgs e)
        {
            if (tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_otsu";
                Image<Bgr, byte> image = images[tcWorkSpace.SelectedTab.Text].getImage.Copy();
                Image<Gray, byte> imageGray = image.Copy().Convert<Gray, byte>();

                double x = CvInvoke.Threshold(imageGray, imageGray, 0, 255, Emgu.CV.CvEnum.ThresholdType.Otsu | Emgu.CV.CvEnum.ThresholdType.Binary);
                MessageBox.Show(x.ToString());
                image = imageGray.Convert<Bgr, byte>();

                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }
        #endregion

        #region Steganography
        private void btSteganography_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSteganography);
        }

        private void btMerge_Click(object sender, EventArgs e)
        {
            //Wybór obrazu ukrywanego oraz ukrywającego
            Merge merge = new Merge(images);
            merge.ShowDialog();

            //Jeżeli obrazy zostały wybrane
            if(merge.IsSet && tcWorkSpace.TabCount > 0)
            {
                String name = merge.CoverImage.getName + "_merge";

                //wykonanie funkcji steganographyMerge na zmiennych z klasy Merge
                Image<Bgr, byte> image = steganographyMerge(merge.CoverImage, merge.MergeImage);

                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }

        private void btUnmerge_Click(object sender, EventArgs e)
        {

            //jeżeli obraz jest wybrany
            if (tcWorkSpace.TabCount > 0)
            {
                String name = tcWorkSpace.SelectedTab.Text + "_unmerge";

                //wyknanie funkcji steganographyUnmerge na zmiennej wybranej w programie
                Image<Bgr, byte> image = steganographyUnmerge(images[tcWorkSpace.SelectedTab.Text]);

                int index = name.IndexOf('(');
                if (index == name.Length - 2)
                    name = name.Substring(0, index);
                addTab(new ImageUtility(name, image));
            }
        }

        //wymaga obrazu ukrywanego oraz ukrywającego
        private Image<Bgr, byte> steganographyMerge(ImageUtility cover, ImageUtility merge)
        {
            //przygotowanie wszystkich potrzebnych zmiennych do ukrycia obrazu w obrazie
            //obraz ukrywający
            Image<Bgr, byte> imageCover = cover.getImage;
            //obraz ukrywany
            Image<Bgr, byte> imageMerge = merge.getImage;
            //szerokość i wysokość obrazu ukrywającego
            int imageWidth = imageCover.Width;
            int imageHeight = imageCover.Height;
            //szerokość i wysokość obrazu ukrywanego
            int mergeWidth = imageMerge.Width;
            int mergeHeight = imageMerge.Height;
            //nowy obraz o wymiarach obrazu ukrywającego
            Image<Bgr, byte> image = new Image<Bgr, byte>(imageWidth, imageHeight);

            //dwie pętle przechodzące przez każdy piksel obrazu ukrywającego
            for(int row = 0; row < imageHeight; ++row)           
                for(int col = 0; col < imageWidth; ++col)
                {
                    //jeżeli obraz na aktualnej szerokości podzielonej przez 2 jest mniejszy od szerokości obrazu ukrywanego
                    // i aktualna wysokość jest mniejsza od wysokości obrazu ukrywanego
                    if(col/2 < mergeWidth && row < mergeHeight)
                    {
                        //to wykonaj funkcję merge Pixel dla każdego z 3 kanałów kolorów wykorzystując obraz ukrywany
                        for(int i = 0; i<3; ++i)
                            image.Data[row, col, i] = mergePixel(imageCover.Data[row, col, i], imageMerge.Data[row, col/2, i], col%2);
                    }
                    else
                    {
                        //w przeciwnym wypadku wykonaj funkcję merge Pixel dla każdego z 3 kanałów kolorów wykorzystując wartość 0
                        for (int i = 0; i<3; ++i)
                            image.Data[row, col, i] = mergePixel(imageCover.Data[row, col, i], (byte) 0, 0);
                    }
                }            
            //zwróć plik graficzny z ukrytym obrazem
            return image;
        }

        //wymaga bajtu obrazu ukrywającego, ukrywanego oraz informacji która to część ukrywania (czy 1 czy 2)
        private byte mergePixel(byte cover, byte merge, int part)
        {
            //zamienia oba piksele na ciągi znaków reprezentujące wartości binarne pikseli
            string coverBin = Convert.ToString(cover, 2).PadLeft(8, '0');
            string mergeBin = Convert.ToString(merge, 2).PadLeft(8, '0');

            //Jeżeli to 1 część
            if(part == 0)
                //połącz 6 najważniejszych bitów obrazu ukrywającego z 1 i 2 najważniejszym ukrywanego
                return Convert.ToByte(coverBin.Substring(0, 6) + mergeBin.Substring(0, 2), 2);
            //W przeciwnym wypadku (to część 2)
            else
                //połącz 6 najważniejszych bitów obrazu ukrywającego z 3 i 4 najważniejszym ukrywanego
                return Convert.ToByte(coverBin.Substring(0, 6) + mergeBin.Substring(2, 2), 2);
        }

        //wymaga pliku graficznego z ukrytym w nim obrazem
        private Image<Bgr, byte> steganographyUnmerge(ImageUtility mergedImage)
        {
            //przygotowani wszystkich potrzebnych zmiennych do odczytu obrazu ukrywanego w obrazie ukrywającym
            //plik graficzny z ukrytym obrazem
            Image<Bgr, byte> image = mergedImage.getImage;
            //szerokość i wysokość pliku graficznego
            int imageWidth = image.Width;
            int imageHeight = image.Height;
            //maksymalna kolumna i rząd z przechowywanym obrazem ukrywanym
            int maxCol = 0;
            int maxRow = 0;

            //dwie pętle przechodzące po wszystkich pikselach pliku graficznego
            for (int row = 0; row < imageHeight; ++row)
                for (int col = 0; col < imageWidth; ++col)
                {
                    //pętla przechodząca przez wszystkie 3 kanały kolorów
                    for (int i = 0; i < 3; ++i)
                    {
                        //jeżeli piskel ma ukrytą wartość i zmienna przechowująca maksymalną wysokość jest mniejsza od lokalizacji aktualnej
                        //to zmienia wartość zmiennej przechowującej maksymalną wysokość na lokalizację aktualnej
                        if (haveValue(image.Data[row, col, i]) && maxRow < row)
                            maxRow = row;

                        //jeżeli piskel ma ukrytą wartość i zmienna przechowująca maksymalną szerokość jest mniejsza od lokalizacji aktualnej
                        //to zmienia wartość zmiennej przechowującej maksymalną szerokość na lokalizację aktualnej
                        if (haveValue(image.Data[row, col, i]) && maxCol < col / 2)
                            maxCol = col/2;
                    }
                }


            //na podstawie aktualnych danych tworzy zmienne przechowujące wartości wysokości i szerokości obrazu do odczytu
            int newImageHeight = maxRow+1;
            int newImageWidth = maxCol+1;
            //tworzy zmienną która zostanie zwrócona jako obraz ukrywany
            Image<Bgr, byte> newImage = new Image<Bgr, byte>(newImageWidth, newImageHeight);
            
            //pętla przechodzi po wszystkich pikselach obrazu ukrywanego
            for (int row = 0; row < newImageHeight; ++row)
                for (int col = 0; col < newImageWidth * 2; col = col + 2)
                {
                    //pętla przechodzi przez wszystkie 3 kanały kolorów
                    //oraz wprowadza dane z pliku graficznego do obrazu ukrywanego
                    for (int i = 0; i < 3; ++i)
                        newImage.Data[row, col/2, i] = unmergePixel(image.Data[row, col, i], image.Data[row, col+1, i]);
                }


            //zwraca obraz ukrywany
            return newImage;
        }

        //wymaga obu pikseli w których plik graficzny zawiera bity obrazu ukrywanego
        private byte unmergePixel(byte firstPixel, byte secondPixel)
        {
            //zamienia oba piksele na ciągi znaków reprezentujące wartości binarne pikseli
            string firstPixelBin = Convert.ToString(firstPixel, 2).PadLeft(8, '0');
            string secondPixelBin = Convert.ToString(secondPixel, 2).PadLeft(8, '0');

            //zwraca nowy piksel złożony z 1 i 2 bitu pierwszego piksela oraz 3 i 4 drugiego piskela
            return Convert.ToByte(firstPixelBin.Substring(6, 2) + secondPixelBin.Substring(6, 2) + "0000", 2);
        }


        //wymaga pikselu sprawdzanego
        private bool haveValue(byte pixel)
        {
            //zamienia piksel na ciąg znaków reprezentujący wartość binarną piksela
            string pixelBin = Convert.ToString(pixel, 2).PadLeft(8, '0');
            //Jeżeli piksel nie posiada wartości na 7 i 8 bicie wtedy nie ma wartości ukrywanej
            if (pixelBin.Substring(6, 2).Equals("00"))
                return false;
            //w przeciwnym wypadku posiada wartość ukrywaną
            else
                return true;
        }

        #endregion

        #region About
        private void btAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja zbiorcza z ćwiczeń laboratoryjnych\n" +
                "Autor: Alan Hryncewicz\n" +
                "Prowadzący: mgr. inż. Łukasz Roszkowiak\n" +
                "Prowadząca: dr. hab. Anna Korzyńska\n" +
                "Algorytmy Obrazów 2022\n" +
                "Wit grupa ID: ID06IO2\n" +
                "Icons: https://icons8.com");
        }
        #endregion

        #region additionalFunctions

        public void addTab(ImageUtility image)
        {        
            if (images.ContainsKey(image.getName))
                image.setName(chooseAccessName(image.getName));

            TabPage tabPage = new TabPage();
            tabPage.Text = image.getName;
            tabPage.Name = "t" + image.getName;
            tabPage.Dock = DockStyle.Fill;

            images.Add(image.getName, image);
            tcWorkSpace.Controls.Add(tabPage);
        }

        public string chooseAccessName(string name, int i = 1)
        {
            while (images.ContainsKey(name + "(" + i + ")"))
                ++i;
 
            return name + "(" + i + ")";
        }

        bool isClick = false;
        Point mouseLoc = new Point(0, 0);

        public PictureBox createPictureBox(Image<Bgr, byte> image, string name)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;
            pictureBox.Image = image.ToBitmap();
            pictureBox.Name = "pb" + name;
            pictureBox.MouseWheel += delegate (object sender, MouseEventArgs e)
            {
                Control pB = tcWorkSpace.SelectedTab.Controls[0];
                if (e.Delta > 0)
                {                   
                    pB.Width += 50;
                    pB.Height += 50;
                }
                else if (pB.Width > 250)
                {
                    pB.Width -= 50;
                    pB.Height -= 50;
                }
            };
            pictureBox.MouseUp += delegate (object sender, MouseEventArgs e)
            {
                Control pB = tcWorkSpace.SelectedTab.Controls[0];
                if (e.Button == MouseButtons.Left)
                {
                    isClick = false;
                    pB.Location = new Point(pB.Location.X - (mouseLoc.X - e.X),pB.Location.Y - (mouseLoc.Y - e.Y));
                }
            };
            pictureBox.MouseDown += delegate (object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isClick = true;
                    mouseLoc = e.Location;
                }
            };
            pictureBox.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                Control pB = tcWorkSpace.SelectedTab.Controls[0];
                if (isClick)
                {
                    pB.Location = new Point(pB.Location.X - (mouseLoc.X - e.X), pB.Location.Y - (mouseLoc.Y - e.Y));
                }
            };
            return pictureBox;
        }
        private Bitmap lnStrHistogram(ImageUtility img)
        {
            Bitmap bmp = img.getImage.ToBitmap();
            Bitmap newBmp = img.getImage.ToBitmap();
            Color newColor = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    double r = (bmp.GetPixel(i, j).R - img.getHistMin()) * (255.0 / (img.getHistMax() - img.getHistMin()));
                    newColor = Color.FromArgb((int)r, (int)r, (int)r);
                    newBmp.SetPixel(i, j, newColor);
                }
            return newBmp;
        }
        private Bitmap equalHistogram(ImageUtility img)
        {
            Bitmap bmp = img.getImage.ToBitmap();
            int[] hist = img.getRed();
            int[] newHist = new int[256];
            double[] d = new double[256];
            int size = bmp.Width * bmp.Height;
            for (int i = 0; i < 256; i++)
            {
                d[i] = 0;
                for (int j = 0; j <= i; j++)
                {
                    d[i] += hist[j];
                }
                d[i] /= size;
            }

            int n = 0;
            double minD = 0;
            while (d[n] <= 0)
            {
                n++;
                minD = d[n];
            }

            for (int i = 0; i < 256; i++)
            {
                newHist[i] = (int)((d[i] - minD) / (1 - minD) * 255);
            }

            Bitmap newBmp = new Bitmap(bmp);
            Color newColor = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    int r = bmp.GetPixel(i, j).R;
                    newColor = Color.FromArgb(newHist[r], newHist[r], newHist[r]);
                    newBmp.SetPixel(i, j, newColor);
                }

            return newBmp;
        }
        public Bitmap toMonoImg(Bitmap bmp)
        {
            Bitmap newBmp = new Bitmap(bmp);
            Color newColor = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    double r = (bmp.GetPixel(i, j).R + bmp.GetPixel(i, j).G + bmp.GetPixel(i, j).B) / 3.0;
                    newColor = Color.FromArgb((int)r, (int)r, (int)r);
                    newBmp.SetPixel(i, j, newColor);
                }
            return newBmp;
        }

        private Bitmap negative(Bitmap bmp)
        {

            Bitmap newBmp = new Bitmap(bmp);
            Color newColor = new Color();

            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    int r = bmp.GetPixel(i, j).R;
                    int g = bmp.GetPixel(i, j).G;
                    int b = bmp.GetPixel(i, j).B;
                    newColor = Color.FromArgb(255 - r, 255 - g, 255 - b);
                    newBmp.SetPixel(i, j, newColor);
                }
            return newBmp;
        }

        private Bitmap thresholding(Bitmap bmp, int thMin, int thMax)
        {
            Bitmap newBmp = new Bitmap(bmp);
            Color newColor = new Color();

            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    int r = bmp.GetPixel(i, j).R;
                    if (r > thMin & r < thMax)
                        newColor = Color.FromArgb(255, 255, 255);
                    else
                        newColor = Color.FromArgb(0, 0, 0);
                    newBmp.SetPixel(i, j, newColor);
                }
            return newBmp;
        }

        private Bitmap thresholdingGray(Bitmap bmp, int thMin, int thMax)
        {
            Bitmap newBmp = new Bitmap(bmp);
            Color newColor = new Color();

            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    int r = bmp.GetPixel(i, j).R;
                    if (r >= thMin & r <= thMax)
                        newColor = Color.FromArgb(r, r, r);
                    else
                        newColor = Color.FromArgb(0, 0, 0);
                    newBmp.SetPixel(i, j, newColor);
                }
            return newBmp;
        }

        private Bitmap posterize(Bitmap bmp, int levels = 8)
        {
            int bmpWidth = bmp.Width;
            int bmpHeight = bmp.Height;
            int delta = 256 / levels;

            for(int height = 0; height < bmpHeight; ++height)
            {
                for(int width = 0; width < bmpWidth; ++width)
                {
                    Color color = bmp.GetPixel(width, height);

                    int r = color.R;
                    int g = color.G;
                    int b = color.B;

                    r = r < delta * (levels - 1) ? r / delta * 256 / levels : 255;
                    g = g < delta * (levels - 1) ? g / delta * 256 / levels : 255;
                    b = b < delta * (levels - 1) ? b / delta * 256 / levels : 255;
                    
                    bmp.SetPixel(width, height, Color.FromArgb(color.A, r, g, b));
                }
            }

            return bmp;
        }
        #endregion
    }
}

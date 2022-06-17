using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO
{
    public partial class Histogram : Form
    {

        private int[] red = new int[256];
        private int[] green = new int[256];
        private int[] blue = new int[256];
        private Boolean isGray;
        private int rgb = 0;

        public Histogram()
        {
            InitializeComponent();
        }

        public void updateHistogram(ImageUtility imageUtility)
        {
            chartHistogram.Series.Clear();

            red = imageUtility.getRed();
            green = imageUtility.getGreen();
            blue = imageUtility.getBlue();
            isGray = imageUtility.getIsGray();
            Bitmap image = imageUtility.getImage.ToBitmap();

            if (isGray)
            {
                chartHistogram.Series.Add("gray");
                chartHistogram.Series[0].Color = Color.Gray;
                for (int i = 0; i < 256; ++i)
                {
                    chartHistogram.Series[0].Points.AddXY(i, red[i]);
                }
            }
            else
            {
                chartHistogram.Series.Add("red");
                chartHistogram.Series[0].Color = Color.Red;
                chartHistogram.Series.Add("green");
                chartHistogram.Series[1].Color = Color.Green;
                chartHistogram.Series.Add("blue");
                chartHistogram.Series[2].Color = Color.Blue;
                for (int i = 0; i < 256; ++i)
                {
                    chartHistogram.Series[0].Points.AddXY(i, red[i]);
                    chartHistogram.Series[1].Points.AddXY(i, green[i]);
                    chartHistogram.Series[2].Points.AddXY(i, blue[i]);
                }
                rgb = 0;
            }

            chartHistogram.ChartAreas[0].RecalculateAxesScale();
        }

        public void clearHistogram()
        {
            chartHistogram.Series.Clear();
            chartHistogram.Series.Add("Pixels");

            for (int i = 0; i < 256; ++i)
            {
                chartHistogram.Series[0].Points.AddXY(i, 0);
            }
        }

        private void btnRGB_Click(object sender, EventArgs e)
        {
            if(!isGray)
            {
                chartHistogram.Series.Clear();

                if (rgb == 0)
                {
                    chartHistogram.Series.Add("red");
                    chartHistogram.Series[0].Color = Color.Red;

                    for (int i = 0; i < 256; ++i)
                    {
                        chartHistogram.Series[0].Points.AddXY(i, red[i]);
                    }

                    rgb = 1;
                }
                else if(rgb == 1)
                {
                    chartHistogram.Series.Add("green");
                    chartHistogram.Series[0].Color = Color.Green;

                    for (int i = 0; i < 256; ++i)
                    {
                        chartHistogram.Series[0].Points.AddXY(i, green[i]);
                    }

                    rgb = 2;
                }
                else if(rgb == 2)
                {
                    chartHistogram.Series.Add("blue");
                    chartHistogram.Series[0].Color = Color.Blue;

                    for (int i = 0; i < 256; ++i)
                    {
                        chartHistogram.Series[0].Points.AddXY(i, blue[i]);
                    }

                    rgb = 3;
                }
                else
                {
                    chartHistogram.Series.Add("red");
                    chartHistogram.Series[0].Color = Color.Red;
                    chartHistogram.Series.Add("green");
                    chartHistogram.Series[1].Color = Color.Green;
                    chartHistogram.Series.Add("blue");
                    chartHistogram.Series[2].Color = Color.Blue;
                    for (int i = 0; i < 256; ++i)
                    {
                        chartHistogram.Series[0].Points.AddXY(i, red[i]);
                        chartHistogram.Series[1].Points.AddXY(i, green[i]);
                        chartHistogram.Series[2].Points.AddXY(i, blue[i]);
                    }

                    rgb = 0;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void chartHistogram_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            var results = chartHistogram.HitTest(pos.X, pos.Y, false,
            ChartElementType.PlottingArea);
            if(chartHistogram.Series.Count == 1)
                foreach (var result in results)
                {
                    if (result.ChartElementType == ChartElementType.PlottingArea)
                    {
                        var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X) - result.ChartArea.AxisX.PixelPositionToValue(pos.X)%1;
                        tBLevel.Text = chartHistogram.Series[0].Points[(int) xVal].YValues[0].ToString();
                        tBValue.Text = xVal.ToString();
                    }
                }
            else if (chartHistogram.Series.Count == 3)
            {
                foreach(var result in results)
                {
                    if (result.ChartElementType == ChartElementType.PlottingArea)
                    {
                        var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X) - result.ChartArea.AxisX.PixelPositionToValue(pos.X) % 1;
                        double valueR = chartHistogram.Series[0].Points[(int)xVal].YValues[0];
                        double valueG = chartHistogram.Series[1].Points[(int)xVal].YValues[0];
                        double valueB = chartHistogram.Series[2].Points[(int)xVal].YValues[0];
                        if (valueR > valueG && valueR > valueB)                       
                            tBLevel.Text = valueR.ToString();
                        else if (valueG > valueR && valueG > valueB)
                            tBLevel.Text = valueG.ToString();
                        else
                            tBLevel.Text = valueB.ToString();
                        tBValue.Text = xVal.ToString();
                    }
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace APO
{
    public partial class GaussianBlur : Form
    {
        private bool isSet = false;
        private int radius = 3;
        private double sigmaX = 0;
        private double sigmaY = 0;

        public GaussianBlur()
        {
            InitializeComponent();
        }

        private void tbRadius_Validated(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            int d;
            if (!int.TryParse(tBox.Text, out d))
                tBox.Text = "3";
            else if (d % 2 == 0)
            {
                tBox.Text = "3";
                MessageBox.Show("Only unpair values!");
            }
            else if (d < 3)
            {
                tBox.Text = "3";
            }
            else
                radius = d;
        }

        private void tbSigmaX_Validated(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double d;
            if (!double.TryParse(tBox.Text, out d))
                tBox.Text = "0.0";
            else
            {
                sigmaX = d;
            }           
        }

        private void tbSigmaY_Validated(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double d;
            if (!double.TryParse(tBox.Text, out d))
                tBox.Text = "0.0";
            else
            {
                sigmaY = d;
            }
        }

        public int getRadius { get { return radius; } }
        public double getSigmaX { get { return sigmaX; } }
        public double getSigmaY { get { return sigmaY; } }
        public bool IsSet { get { return isSet; } }
        public Emgu.CV.CvEnum.BorderType getBorderType()
        {
            switch (this.cBBorderType.SelectedIndex)
            {
                default:
                    return Emgu.CV.CvEnum.BorderType.Default;                
                case 0:
                    return Emgu.CV.CvEnum.BorderType.Replicate;
                case 1:
                    return Emgu.CV.CvEnum.BorderType.Reflect;
                case 2:
                    return Emgu.CV.CvEnum.BorderType.Isolated;               
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {           
            if(radius % 2 == 1 && radius > 2) {
                if (sigmaY == 0)
                    sigmaY = sigmaX;

                isSet = true;
                this.Close();
            }               
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

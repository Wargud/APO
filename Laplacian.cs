using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO
{
    public partial class Laplacian : Form
    {
        private int kernel = 1;
        private bool isSet = false;

        public Laplacian()
        {
            InitializeComponent();
        }

        private void tbKernel_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            int d;
            if (!int.TryParse(tBox.Text, out d))
                tBox.Text = "1";
            else if (d % 2 == 0)
            {
                tBox.Text = "1";
                MessageBox.Show("Only unpair values!");
            }
            else
                kernel = d;
        }

        public int getKernel { get { return kernel; }}
        public bool IsSet { get { return isSet; }}
        
        public Emgu.CV.CvEnum.DepthType getDepthType()
        {
            switch (this.cBDDepth.SelectedIndex)
            {
                default:
                    return Emgu.CV.CvEnum.DepthType.Default;
                case 0:                  
                    return Emgu.CV.CvEnum.DepthType.Cv16S;                   
                case 1:
                    return Emgu.CV.CvEnum.DepthType.Cv64F;
                case 2:
                    return Emgu.CV.CvEnum.DepthType.Cv32F;
                case 3:
                    return Emgu.CV.CvEnum.DepthType.Cv8U;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (kernel % 2 == 1)
            {             
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

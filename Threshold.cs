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
    public partial class Threshold : Form
    {
        private int lMin = 0;
        private int lMax = 0;
        private bool isSet = false;

        public Threshold()
        {
            InitializeComponent();
        }

        public int getLMin() { return lMin; }
        public int getLMax() { return lMax; }
        public bool IsSet() { return isSet; }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (lMin<lMax)
            {
                isSet = true;
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTrackBar_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = track1.Value.ToString();
            label2.Text = track2.Value.ToString();

            if (track1.Value > track2.Value)
            {
                this.lMax = track1.Value;
                this.lMin = track2.Value;
            }
            else
            {
                this.lMin = track1.Value;
                this.lMax = track2.Value;
            }
        }
    }
}

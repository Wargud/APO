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
    public partial class MedianBlur : Form
    {
        private int k = 0;

        public MedianBlur()
        {
            InitializeComponent();
        }

        private void bt3x3_Click(object sender, EventArgs e)
        {
            k = 3;
            this.Close();
        }

        private void bt5x5_Click(object sender, EventArgs e)
        {
            k = 5;
            this.Close();
        }

        private void bt7x7_Click(object sender, EventArgs e)
        {
            k = 7;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getK { get { return k; } }
    }
}

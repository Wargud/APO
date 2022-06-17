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
    public partial class Blur : Form
    {
        private bool isSet = false;
        private int widthX = 3;
        private int widthY = 3;

        public Blur()
        {
            InitializeComponent();
        }
        private void tbWidthX_Validated(object sender, EventArgs e)
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
            else if(d < 3)
            {
                tBox.Text = "3";
            }
            else
                widthX = d;
        }

        private void tbWidthY_TextChanged(object sender, EventArgs e)
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
                widthY = d;
        }

        public int getWidthX { get { return widthX; } }
        public int getWidthY { get { return widthY; } }
        public bool IsSet { get { return isSet; } }

        private void btOK_Click(object sender, EventArgs e)
        {           
            if(widthX % 2 == 1 && widthY % 2 == 1 && widthX > 2 && widthY > 2) {
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

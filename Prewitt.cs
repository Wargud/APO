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
    public partial class Prewitt : Form
    {
        private bool isSet = false;

        public Prewitt()
        {
            InitializeComponent();
        }

        public float[,] GetArray2d()
        {
            switch (this.cBDirection.SelectedIndex)
            {
                default:
                    //N
                    return new float[3, 3] { { 1, 1, 1 }, { 1, -2, 1 }, { -1, -1, -1 } };
                case 0:
                    //N
                    return new float[3, 3] { { 1, 1, 1 }, { 1, -2, 1 }, { -1, -1, -1 } };
                case 1:
                    //NE
                    return new float[3, 3] { { 1, 1, 1 }, { -1, -2, 1 }, { -1, -1, 1 } };
                case 2:
                    //E
                    return new float[3, 3] { { -1, 1, 1 }, { -1, -2, 1 }, { -1, 1, 1 } };
                case 3:
                    //SE
                    return new float[3, 3] { { -1, -1, 1 }, { -1, -2, 1 }, { 1, 1, 1 } };
                case 4:
                    //S
                    return new float[3, 3] { { -1, -1, -1 }, { 1, -2, 1 }, { 1, 1, 1 } };
                case 5:
                    //SW
                    return new float[3, 3] { { 1, -1, -1 }, { 1, -2, -1 }, { 1, 1, 1 } };
                case 6:
                    //W
                    return new float[3, 3] { { 1, 1, -1 }, { 1, -2, -1 }, { 1, 1, -1 } };
                case 7:
                    //NW
                    return new float[3, 3] { { 1, 1, 1 }, { 1, -2, -1 }, { 1, -1, -1 } };
            }
        }

        public bool IsSet { get { return isSet; } }

        private void btOK_Click(object sender, EventArgs e)
        {           
            isSet = true;
            this.Close();          
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

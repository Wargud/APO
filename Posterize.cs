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
    public partial class Posterize : Form
    {
        private int level = 0;

        public Posterize()
        {
            InitializeComponent();
        }

        private void bt2Levels_Click(object sender, EventArgs e)
        {
            level = 2;
            this.Close();
        }

        private void bt4Levels_Click(object sender, EventArgs e)
        {
            level = 4;
            this.Close();
        }

        private void bt8Levels_Click(object sender, EventArgs e)
        {
            level = 8;
            this.Close();
        }

        private void bt16Levels_Click(object sender, EventArgs e)
        {
            level = 16;
            this.Close();
        }

        private void bt32Levels_Click(object sender, EventArgs e)
        {
            level = 32;
            this.Close();
        }

        private void bt64Levels_Click(object sender, EventArgs e)
        {
            level = 64;
            this.Close();
        }

        private void bt128Levels_Click(object sender, EventArgs e)
        {
            level = 128;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int getLevel() { return level; }
    }
}

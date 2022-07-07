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

namespace APO
{
    public partial class Merge : Form
    {

        Dictionary<string, ImageUtility> images = new Dictionary<string, ImageUtility>();
        ImageUtility coverImage = null;
        ImageUtility mergeImage = null;
        bool isSet = false;

        public Merge(Dictionary<string, ImageUtility> images)
        {
            InitializeComponent();
            this.images = images;

            foreach (string image in images.Keys)
            {
                cbCover.Items.Add(image);
                cbMerge.Items.Add(image);
            }
        }

        private void cbCover_SelectedIndexChanged(object sender, EventArgs e)
        {
            coverImage = images[cbCover.SelectedItem.ToString()];
            if(mergeImage != null)
                btOK.Enabled = true;
        }

        private void cbMerge_SelectedIndexChanged(object sender, EventArgs e)
        {
            mergeImage = images[cbMerge.SelectedItem.ToString()];
            if(coverImage != null)
                btOK.Enabled = true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (cbCover.SelectedItem.ToString() != cbMerge.SelectedItem.ToString() &&
                coverImage.getName != null &&
                mergeImage.getName != null &&
                coverImage.getImage.Width >= mergeImage.getImage.Width * 2 &&
                coverImage.getImage.Height >= mergeImage.getImage.Height)
            {
                isSet = true;
                this.Close();
            }
            else
                MessageBox.Show("Cover Image must be heighter and widther(*2) than merge Image!");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ImageUtility CoverImage { get { return coverImage; } }
        public ImageUtility MergeImage { get { return mergeImage; } }
        public bool IsSet { get { return isSet; } }
    }
}

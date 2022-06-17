namespace APO
{
    partial class MedianBlur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.bt7x7 = new MetroFramework.Controls.MetroButton();
            this.bt5x5 = new MetroFramework.Controls.MetroButton();
            this.bt3x3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(14, 134);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(108, 23);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // bt7x7
            // 
            this.bt7x7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt7x7.Location = new System.Drawing.Point(14, 70);
            this.bt7x7.Name = "bt7x7";
            this.bt7x7.Size = new System.Drawing.Size(108, 23);
            this.bt7x7.TabIndex = 11;
            this.bt7x7.Text = "7 x 7";
            this.bt7x7.UseSelectable = true;
            this.bt7x7.Click += new System.EventHandler(this.bt7x7_Click);
            // 
            // bt5x5
            // 
            this.bt5x5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt5x5.Location = new System.Drawing.Point(14, 41);
            this.bt5x5.Name = "bt5x5";
            this.bt5x5.Size = new System.Drawing.Size(108, 23);
            this.bt5x5.TabIndex = 10;
            this.bt5x5.Text = "5 x 5";
            this.bt5x5.UseSelectable = true;
            this.bt5x5.Click += new System.EventHandler(this.bt5x5_Click);
            // 
            // bt3x3
            // 
            this.bt3x3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt3x3.Location = new System.Drawing.Point(14, 12);
            this.bt3x3.Name = "bt3x3";
            this.bt3x3.Size = new System.Drawing.Size(108, 23);
            this.bt3x3.TabIndex = 8;
            this.bt3x3.Text = "3 x 3";
            this.bt3x3.UseSelectable = true;
            this.bt3x3.Click += new System.EventHandler(this.bt3x3_Click);
            // 
            // MedianBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 184);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.bt7x7);
            this.Controls.Add(this.bt5x5);
            this.Controls.Add(this.bt3x3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedianBlur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MedianBlur";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btCancel;
        private MetroFramework.Controls.MetroButton bt7x7;
        private MetroFramework.Controls.MetroButton bt5x5;
        private MetroFramework.Controls.MetroButton bt3x3;
    }
}
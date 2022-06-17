namespace APO
{
    partial class Posterize
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
            this.bt2Levels = new MetroFramework.Controls.MetroButton();
            this.bt128Levels = new MetroFramework.Controls.MetroButton();
            this.bt4Levels = new MetroFramework.Controls.MetroButton();
            this.bt8Levels = new MetroFramework.Controls.MetroButton();
            this.bt16Levels = new MetroFramework.Controls.MetroButton();
            this.bt32Levels = new MetroFramework.Controls.MetroButton();
            this.bt64Levels = new MetroFramework.Controls.MetroButton();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // bt2Levels
            // 
            this.bt2Levels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt2Levels.Location = new System.Drawing.Point(45, 12);
            this.bt2Levels.Name = "bt2Levels";
            this.bt2Levels.Size = new System.Drawing.Size(108, 23);
            this.bt2Levels.TabIndex = 0;
            this.bt2Levels.Text = "2 levels (1bit)";
            this.bt2Levels.UseSelectable = true;
            this.bt2Levels.Click += new System.EventHandler(this.bt2Levels_Click);
            // 
            // bt128Levels
            // 
            this.bt128Levels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt128Levels.Location = new System.Drawing.Point(45, 186);
            this.bt128Levels.Name = "bt128Levels";
            this.bt128Levels.Size = new System.Drawing.Size(108, 23);
            this.bt128Levels.TabIndex = 1;
            this.bt128Levels.Text = "128 levels (7bit)";
            this.bt128Levels.UseSelectable = true;
            this.bt128Levels.Click += new System.EventHandler(this.bt128Levels_Click);
            // 
            // bt4Levels
            // 
            this.bt4Levels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt4Levels.Location = new System.Drawing.Point(45, 41);
            this.bt4Levels.Name = "bt4Levels";
            this.bt4Levels.Size = new System.Drawing.Size(108, 23);
            this.bt4Levels.TabIndex = 2;
            this.bt4Levels.Text = "4 levels (2bit)";
            this.bt4Levels.UseSelectable = true;
            this.bt4Levels.Click += new System.EventHandler(this.bt4Levels_Click);
            // 
            // bt8Levels
            // 
            this.bt8Levels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt8Levels.Location = new System.Drawing.Point(45, 70);
            this.bt8Levels.Name = "bt8Levels";
            this.bt8Levels.Size = new System.Drawing.Size(108, 23);
            this.bt8Levels.TabIndex = 3;
            this.bt8Levels.Text = "8 levels (3bit)";
            this.bt8Levels.UseSelectable = true;
            this.bt8Levels.Click += new System.EventHandler(this.bt8Levels_Click);
            // 
            // bt16Levels
            // 
            this.bt16Levels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt16Levels.Location = new System.Drawing.Point(45, 99);
            this.bt16Levels.Name = "bt16Levels";
            this.bt16Levels.Size = new System.Drawing.Size(108, 23);
            this.bt16Levels.TabIndex = 4;
            this.bt16Levels.Text = "16 levels (4bit)";
            this.bt16Levels.UseSelectable = true;
            this.bt16Levels.Click += new System.EventHandler(this.bt16Levels_Click);
            // 
            // bt32Levels
            // 
            this.bt32Levels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt32Levels.Location = new System.Drawing.Point(45, 128);
            this.bt32Levels.Name = "bt32Levels";
            this.bt32Levels.Size = new System.Drawing.Size(108, 23);
            this.bt32Levels.TabIndex = 5;
            this.bt32Levels.Text = "32 levels (5bit)";
            this.bt32Levels.UseSelectable = true;
            this.bt32Levels.Click += new System.EventHandler(this.bt32Levels_Click);
            // 
            // bt64Levels
            // 
            this.bt64Levels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt64Levels.Location = new System.Drawing.Point(45, 157);
            this.bt64Levels.Name = "bt64Levels";
            this.bt64Levels.Size = new System.Drawing.Size(108, 23);
            this.bt64Levels.TabIndex = 6;
            this.bt64Levels.Text = "64 levels (6bit)";
            this.bt64Levels.UseSelectable = true;
            this.bt64Levels.Click += new System.EventHandler(this.bt64Levels_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(45, 243);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(108, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Posterize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 289);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.bt64Levels);
            this.Controls.Add(this.bt32Levels);
            this.Controls.Add(this.bt16Levels);
            this.Controls.Add(this.bt8Levels);
            this.Controls.Add(this.bt4Levels);
            this.Controls.Add(this.bt128Levels);
            this.Controls.Add(this.bt2Levels);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Posterize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Posterize";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton bt2Levels;
        private MetroFramework.Controls.MetroButton bt128Levels;
        private MetroFramework.Controls.MetroButton bt4Levels;
        private MetroFramework.Controls.MetroButton bt8Levels;
        private MetroFramework.Controls.MetroButton bt16Levels;
        private MetroFramework.Controls.MetroButton bt32Levels;
        private MetroFramework.Controls.MetroButton bt64Levels;
        private MetroFramework.Controls.MetroButton btCancel;
    }
}
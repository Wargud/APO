namespace APO
{
    partial class Laplacian
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbKernel = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cBDDepth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kernel Size";
            // 
            // tbKernel
            // 
            this.tbKernel.Location = new System.Drawing.Point(78, 23);
            this.tbKernel.Name = "tbKernel";
            this.tbKernel.Size = new System.Drawing.Size(59, 20);
            this.tbKernel.TabIndex = 1;
            this.tbKernel.Text = "1";
            this.tbKernel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbKernel.TextChanged += new System.EventHandler(this.tbKernel_TextChanged);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(82, 130);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(51, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(32, 130);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(40, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Depth Type";
            // 
            // cBDDepth
            // 
            this.cBDDepth.FormattingEnabled = true;
            this.cBDDepth.Items.AddRange(new object[] {
            "Cv16S (int16)",
            "Cv64F (double)",
            "Cv32F (float)",
            "Cv8U (byte)"});
            this.cBDDepth.Location = new System.Drawing.Point(15, 64);
            this.cBDDepth.Name = "cBDDepth";
            this.cBDDepth.Size = new System.Drawing.Size(122, 21);
            this.cBDDepth.TabIndex = 7;
            // 
            // Laplacian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 166);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBDDepth);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbKernel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Laplacian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Laplacian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKernel;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBDDepth;
    }
}
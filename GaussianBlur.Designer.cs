﻿namespace APO
{
    partial class GaussianBlur
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
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cBBorderType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSigmaX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSigmaY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius";
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(59, 44);
            this.tbRadius.MaxLength = 3;
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(40, 20);
            this.tbRadius.TabIndex = 1;
            this.tbRadius.Text = "3";
            this.tbRadius.Validated += new System.EventHandler(this.tbRadius_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "pixels";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(38, 188);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(40, 23);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(88, 188);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(51, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // cBBorderType
            // 
            this.cBBorderType.FormattingEnabled = true;
            this.cBBorderType.Items.AddRange(new object[] {
            "Replicate",
            "Reflect",
            "Isolated"});
            this.cBBorderType.Location = new System.Drawing.Point(16, 140);
            this.cBBorderType.Name = "cBBorderType";
            this.cBBorderType.Size = new System.Drawing.Size(122, 21);
            this.cBBorderType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Border Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "pixels";
            // 
            // tbSigmaX
            // 
            this.tbSigmaX.Location = new System.Drawing.Point(59, 70);
            this.tbSigmaX.MaxLength = 3;
            this.tbSigmaX.Name = "tbSigmaX";
            this.tbSigmaX.Size = new System.Drawing.Size(40, 20);
            this.tbSigmaX.TabIndex = 8;
            this.tbSigmaX.Text = "0.0";
            this.tbSigmaX.TextChanged += new System.EventHandler(this.tbSigmaX_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "SigmaX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "pixels";
            // 
            // tbSigmaY
            // 
            this.tbSigmaY.Location = new System.Drawing.Point(59, 96);
            this.tbSigmaY.MaxLength = 3;
            this.tbSigmaY.Name = "tbSigmaY";
            this.tbSigmaY.Size = new System.Drawing.Size(40, 20);
            this.tbSigmaY.TabIndex = 11;
            this.tbSigmaY.Text = "0.0";
            this.tbSigmaY.TextChanged += new System.EventHandler(this.tbSigmaY_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "SigmaY";
            // 
            // GaussianBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 223);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSigmaY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSigmaX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBBorderType);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GaussianBlur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GaussianBlur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cBBorderType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSigmaX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSigmaY;
        private System.Windows.Forms.Label label7;
    }
}
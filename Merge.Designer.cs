namespace APO
{
    partial class Merge
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
            this.cbCover = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMerge = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cover Image";
            // 
            // cbCover
            // 
            this.cbCover.FormattingEnabled = true;
            this.cbCover.Location = new System.Drawing.Point(22, 33);
            this.cbCover.Name = "cbCover";
            this.cbCover.Size = new System.Drawing.Size(121, 21);
            this.cbCover.TabIndex = 1;
            this.cbCover.SelectedIndexChanged += new System.EventHandler(this.cbCover_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image to Merge";
            // 
            // cbMerge
            // 
            this.cbMerge.FormattingEnabled = true;
            this.cbMerge.Location = new System.Drawing.Point(22, 73);
            this.cbMerge.Name = "cbMerge";
            this.cbMerge.Size = new System.Drawing.Size(121, 21);
            this.cbMerge.TabIndex = 3;
            this.cbMerge.SelectedIndexChanged += new System.EventHandler(this.cbMerge_SelectedIndexChanged);
            // 
            // btOK
            // 
            this.btOK.Enabled = false;
            this.btOK.Location = new System.Drawing.Point(42, 146);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(52, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(100, 146);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 181);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbMerge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCover);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Merge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMerge;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}
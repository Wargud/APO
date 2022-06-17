namespace APO
{
    partial class Threshold
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
            this.track1 = new MetroFramework.Controls.MetroTrackBar();
            this.track2 = new MetroFramework.Controls.MetroTrackBar();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.btOK = new MetroFramework.Controls.MetroButton();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // track1
            // 
            this.track1.BackColor = System.Drawing.Color.Transparent;
            this.track1.Location = new System.Drawing.Point(12, 44);
            this.track1.Maximum = 255;
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(379, 23);
            this.track1.TabIndex = 1;
            this.track1.Text = "metroTrackBar1";
            this.track1.Value = 0;
            this.track1.ValueChanged += new System.EventHandler(this.metroTrackBar_ValueChanged);
            // 
            // track2
            // 
            this.track2.BackColor = System.Drawing.Color.Transparent;
            this.track2.Location = new System.Drawing.Point(12, 108);
            this.track2.Maximum = 255;
            this.track2.Name = "track2";
            this.track2.Size = new System.Drawing.Size(379, 23);
            this.track2.TabIndex = 2;
            this.track2.Text = "metroTrackBar2";
            this.track2.Value = 0;
            this.track2.ValueChanged += new System.EventHandler(this.metroTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(232, 165);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseSelectable = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(322, 165);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Threshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 200);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track2);
            this.Controls.Add(this.track1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Threshold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Threshold";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTrackBar track1;
        private MetroFramework.Controls.MetroTrackBar track2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroButton btOK;
        private MetroFramework.Controls.MetroButton btCancel;
    }
}
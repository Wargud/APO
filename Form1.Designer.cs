namespace APO
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btAbout = new System.Windows.Forms.Button();
            this.panelSteganography = new System.Windows.Forms.Panel();
            this.btUnmerge = new System.Windows.Forms.Button();
            this.btMerge = new System.Windows.Forms.Button();
            this.btSteganography = new System.Windows.Forms.Button();
            this.panelSegmentation = new System.Windows.Forms.Panel();
            this.btOtsu = new System.Windows.Forms.Button();
            this.btWatershed = new System.Windows.Forms.Button();
            this.btSegmentation = new System.Windows.Forms.Button();
            this.panelSharp = new System.Windows.Forms.Panel();
            this.btPrewitt = new System.Windows.Forms.Button();
            this.btCanny = new System.Windows.Forms.Button();
            this.btLaplacian = new System.Windows.Forms.Button();
            this.btSobel = new System.Windows.Forms.Button();
            this.btSharp = new System.Windows.Forms.Button();
            this.panelSmooth = new System.Windows.Forms.Panel();
            this.btMedian = new System.Windows.Forms.Button();
            this.btGaussianBlur = new System.Windows.Forms.Button();
            this.btBlur = new System.Windows.Forms.Button();
            this.btSmooth = new System.Windows.Forms.Button();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.btDilate = new System.Windows.Forms.Button();
            this.btSkeletonize = new System.Windows.Forms.Button();
            this.btPosterize = new System.Windows.Forms.Button();
            this.btThresholdingGray = new System.Windows.Forms.Button();
            this.btThresholding = new System.Windows.Forms.Button();
            this.btNegative = new System.Windows.Forms.Button();
            this.btToMono = new System.Windows.Forms.Button();
            this.btOperations = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.btEqualHistogram = new System.Windows.Forms.Button();
            this.btLnStrHistogram = new System.Windows.Forms.Button();
            this.btHistogram = new System.Windows.Forms.Button();
            this.btDuplicate = new System.Windows.Forms.Button();
            this.btImage = new System.Windows.Forms.Button();
            this.panelFile = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelWorkSpace = new System.Windows.Forms.Panel();
            this.tcWorkSpace = new MetroFramework.Controls.MetroTabControl();
            this.panelListWorkSpace = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btRestoreDown = new System.Windows.Forms.Button();
            this.btMaximize = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelSteganography.SuspendLayout();
            this.panelSegmentation.SuspendLayout();
            this.panelSharp.SuspendLayout();
            this.panelSmooth.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelWorkSpace.SuspendLayout();
            this.panelListWorkSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLeft.Controls.Add(this.btAbout);
            this.panelLeft.Controls.Add(this.panelSteganography);
            this.panelLeft.Controls.Add(this.btSteganography);
            this.panelLeft.Controls.Add(this.panelSegmentation);
            this.panelLeft.Controls.Add(this.btSegmentation);
            this.panelLeft.Controls.Add(this.panelSharp);
            this.panelLeft.Controls.Add(this.btSharp);
            this.panelLeft.Controls.Add(this.panelSmooth);
            this.panelLeft.Controls.Add(this.btSmooth);
            this.panelLeft.Controls.Add(this.panelOperations);
            this.panelLeft.Controls.Add(this.btOperations);
            this.panelLeft.Controls.Add(this.panelImage);
            this.panelLeft.Controls.Add(this.btImage);
            this.panelLeft.Controls.Add(this.panelFile);
            this.panelLeft.Controls.Add(this.btFile);
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(150, 577);
            this.panelLeft.TabIndex = 0;
            // 
            // btAbout
            // 
            this.btAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAbout.FlatAppearance.BorderSize = 0;
            this.btAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btAbout.Image = global::APO.Properties.Resources.infoImage;
            this.btAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAbout.Location = new System.Drawing.Point(0, 1181);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(150, 40);
            this.btAbout.TabIndex = 13;
            this.btAbout.Text = "About";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // panelSteganography
            // 
            this.panelSteganography.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panelSteganography.Controls.Add(this.btUnmerge);
            this.panelSteganography.Controls.Add(this.btMerge);
            this.panelSteganography.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSteganography.Location = new System.Drawing.Point(0, 1121);
            this.panelSteganography.Name = "panelSteganography";
            this.panelSteganography.Size = new System.Drawing.Size(150, 60);
            this.panelSteganography.TabIndex = 15;
            // 
            // btUnmerge
            // 
            this.btUnmerge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUnmerge.FlatAppearance.BorderSize = 0;
            this.btUnmerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUnmerge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btUnmerge.Location = new System.Drawing.Point(0, 30);
            this.btUnmerge.Name = "btUnmerge";
            this.btUnmerge.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btUnmerge.Size = new System.Drawing.Size(150, 30);
            this.btUnmerge.TabIndex = 2;
            this.btUnmerge.Text = "Unmerge";
            this.btUnmerge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUnmerge.UseVisualStyleBackColor = true;
            this.btUnmerge.Click += new System.EventHandler(this.btUnmerge_Click);
            // 
            // btMerge
            // 
            this.btMerge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMerge.FlatAppearance.BorderSize = 0;
            this.btMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMerge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btMerge.Location = new System.Drawing.Point(0, 0);
            this.btMerge.Name = "btMerge";
            this.btMerge.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btMerge.Size = new System.Drawing.Size(150, 30);
            this.btMerge.TabIndex = 0;
            this.btMerge.Text = "Merge";
            this.btMerge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMerge.UseVisualStyleBackColor = true;
            this.btMerge.Click += new System.EventHandler(this.btMerge_Click);
            // 
            // btSteganography
            // 
            this.btSteganography.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSteganography.FlatAppearance.BorderSize = 0;
            this.btSteganography.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSteganography.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSteganography.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btSteganography.Image = global::APO.Properties.Resources.steganographyImage;
            this.btSteganography.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSteganography.Location = new System.Drawing.Point(0, 1081);
            this.btSteganography.Name = "btSteganography";
            this.btSteganography.Size = new System.Drawing.Size(150, 40);
            this.btSteganography.TabIndex = 14;
            this.btSteganography.Text = "Steganography";
            this.btSteganography.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSteganography.UseVisualStyleBackColor = true;
            this.btSteganography.Click += new System.EventHandler(this.btSteganography_Click);
            // 
            // panelSegmentation
            // 
            this.panelSegmentation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panelSegmentation.Controls.Add(this.btOtsu);
            this.panelSegmentation.Controls.Add(this.btWatershed);
            this.panelSegmentation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSegmentation.Location = new System.Drawing.Point(0, 1021);
            this.panelSegmentation.Name = "panelSegmentation";
            this.panelSegmentation.Size = new System.Drawing.Size(150, 60);
            this.panelSegmentation.TabIndex = 11;
            // 
            // btOtsu
            // 
            this.btOtsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btOtsu.FlatAppearance.BorderSize = 0;
            this.btOtsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOtsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btOtsu.Location = new System.Drawing.Point(0, 30);
            this.btOtsu.Name = "btOtsu";
            this.btOtsu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btOtsu.Size = new System.Drawing.Size(150, 30);
            this.btOtsu.TabIndex = 2;
            this.btOtsu.Text = "Otsu";
            this.btOtsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOtsu.UseVisualStyleBackColor = true;
            this.btOtsu.Click += new System.EventHandler(this.btOtsu_Click);
            // 
            // btWatershed
            // 
            this.btWatershed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btWatershed.FlatAppearance.BorderSize = 0;
            this.btWatershed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWatershed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btWatershed.Location = new System.Drawing.Point(0, 0);
            this.btWatershed.Name = "btWatershed";
            this.btWatershed.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btWatershed.Size = new System.Drawing.Size(150, 30);
            this.btWatershed.TabIndex = 0;
            this.btWatershed.Text = "Watershed";
            this.btWatershed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btWatershed.UseVisualStyleBackColor = true;
            this.btWatershed.Click += new System.EventHandler(this.btWatershed_Click);
            // 
            // btSegmentation
            // 
            this.btSegmentation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSegmentation.FlatAppearance.BorderSize = 0;
            this.btSegmentation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSegmentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSegmentation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btSegmentation.Image = global::APO.Properties.Resources.segmentationImage;
            this.btSegmentation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSegmentation.Location = new System.Drawing.Point(0, 981);
            this.btSegmentation.Name = "btSegmentation";
            this.btSegmentation.Size = new System.Drawing.Size(150, 40);
            this.btSegmentation.TabIndex = 12;
            this.btSegmentation.Text = "Segmentation";
            this.btSegmentation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSegmentation.UseVisualStyleBackColor = true;
            this.btSegmentation.Click += new System.EventHandler(this.btSegmentation_Click);
            // 
            // panelSharp
            // 
            this.panelSharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panelSharp.Controls.Add(this.btPrewitt);
            this.panelSharp.Controls.Add(this.btCanny);
            this.panelSharp.Controls.Add(this.btLaplacian);
            this.panelSharp.Controls.Add(this.btSobel);
            this.panelSharp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSharp.Location = new System.Drawing.Point(0, 861);
            this.panelSharp.Name = "panelSharp";
            this.panelSharp.Size = new System.Drawing.Size(150, 120);
            this.panelSharp.TabIndex = 8;
            // 
            // btPrewitt
            // 
            this.btPrewitt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPrewitt.FlatAppearance.BorderSize = 0;
            this.btPrewitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrewitt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btPrewitt.Location = new System.Drawing.Point(0, 90);
            this.btPrewitt.Name = "btPrewitt";
            this.btPrewitt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btPrewitt.Size = new System.Drawing.Size(150, 30);
            this.btPrewitt.TabIndex = 3;
            this.btPrewitt.Text = "Prewitt";
            this.btPrewitt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPrewitt.UseVisualStyleBackColor = true;
            this.btPrewitt.Click += new System.EventHandler(this.btPrewitt_Click);
            // 
            // btCanny
            // 
            this.btCanny.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCanny.FlatAppearance.BorderSize = 0;
            this.btCanny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCanny.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btCanny.Location = new System.Drawing.Point(0, 60);
            this.btCanny.Name = "btCanny";
            this.btCanny.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btCanny.Size = new System.Drawing.Size(150, 30);
            this.btCanny.TabIndex = 2;
            this.btCanny.Text = "Canny";
            this.btCanny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCanny.UseVisualStyleBackColor = true;
            this.btCanny.Click += new System.EventHandler(this.btCanny_Click);
            // 
            // btLaplacian
            // 
            this.btLaplacian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLaplacian.FlatAppearance.BorderSize = 0;
            this.btLaplacian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLaplacian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btLaplacian.Location = new System.Drawing.Point(0, 30);
            this.btLaplacian.Name = "btLaplacian";
            this.btLaplacian.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btLaplacian.Size = new System.Drawing.Size(150, 30);
            this.btLaplacian.TabIndex = 1;
            this.btLaplacian.Text = "Laplacian";
            this.btLaplacian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLaplacian.UseVisualStyleBackColor = true;
            this.btLaplacian.Click += new System.EventHandler(this.btLaplacian_Click);
            // 
            // btSobel
            // 
            this.btSobel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSobel.FlatAppearance.BorderSize = 0;
            this.btSobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSobel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btSobel.Location = new System.Drawing.Point(0, 0);
            this.btSobel.Name = "btSobel";
            this.btSobel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btSobel.Size = new System.Drawing.Size(150, 30);
            this.btSobel.TabIndex = 0;
            this.btSobel.Text = "Sobel";
            this.btSobel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSobel.UseVisualStyleBackColor = true;
            this.btSobel.Click += new System.EventHandler(this.btSobel_Click);
            // 
            // btSharp
            // 
            this.btSharp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSharp.FlatAppearance.BorderSize = 0;
            this.btSharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSharp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btSharp.Image = global::APO.Properties.Resources.scharpImage;
            this.btSharp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSharp.Location = new System.Drawing.Point(0, 821);
            this.btSharp.Name = "btSharp";
            this.btSharp.Size = new System.Drawing.Size(150, 40);
            this.btSharp.TabIndex = 7;
            this.btSharp.Text = "Sharp";
            this.btSharp.UseVisualStyleBackColor = true;
            this.btSharp.Click += new System.EventHandler(this.btSharp_Click);
            // 
            // panelSmooth
            // 
            this.panelSmooth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panelSmooth.Controls.Add(this.btMedian);
            this.panelSmooth.Controls.Add(this.btGaussianBlur);
            this.panelSmooth.Controls.Add(this.btBlur);
            this.panelSmooth.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSmooth.Location = new System.Drawing.Point(0, 731);
            this.panelSmooth.Name = "panelSmooth";
            this.panelSmooth.Size = new System.Drawing.Size(150, 90);
            this.panelSmooth.TabIndex = 6;
            // 
            // btMedian
            // 
            this.btMedian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMedian.FlatAppearance.BorderSize = 0;
            this.btMedian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMedian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btMedian.Location = new System.Drawing.Point(0, 60);
            this.btMedian.Name = "btMedian";
            this.btMedian.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btMedian.Size = new System.Drawing.Size(150, 30);
            this.btMedian.TabIndex = 3;
            this.btMedian.Text = "MedianBlur";
            this.btMedian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMedian.UseVisualStyleBackColor = true;
            this.btMedian.Click += new System.EventHandler(this.btMedian_Click);
            // 
            // btGaussianBlur
            // 
            this.btGaussianBlur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGaussianBlur.FlatAppearance.BorderSize = 0;
            this.btGaussianBlur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGaussianBlur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btGaussianBlur.Location = new System.Drawing.Point(0, 30);
            this.btGaussianBlur.Name = "btGaussianBlur";
            this.btGaussianBlur.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btGaussianBlur.Size = new System.Drawing.Size(150, 30);
            this.btGaussianBlur.TabIndex = 2;
            this.btGaussianBlur.Text = "GaussianBlur";
            this.btGaussianBlur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGaussianBlur.UseVisualStyleBackColor = true;
            this.btGaussianBlur.Click += new System.EventHandler(this.btGaussianBlur_Click);
            // 
            // btBlur
            // 
            this.btBlur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBlur.FlatAppearance.BorderSize = 0;
            this.btBlur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBlur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btBlur.Location = new System.Drawing.Point(0, 0);
            this.btBlur.Name = "btBlur";
            this.btBlur.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btBlur.Size = new System.Drawing.Size(150, 30);
            this.btBlur.TabIndex = 0;
            this.btBlur.Text = "Blur";
            this.btBlur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBlur.UseVisualStyleBackColor = true;
            this.btBlur.Click += new System.EventHandler(this.btBlur_Click);
            // 
            // btSmooth
            // 
            this.btSmooth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSmooth.FlatAppearance.BorderSize = 0;
            this.btSmooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSmooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btSmooth.Image = global::APO.Properties.Resources.blurImage;
            this.btSmooth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSmooth.Location = new System.Drawing.Point(0, 691);
            this.btSmooth.Name = "btSmooth";
            this.btSmooth.Size = new System.Drawing.Size(150, 40);
            this.btSmooth.TabIndex = 5;
            this.btSmooth.Text = "Smooth";
            this.btSmooth.UseVisualStyleBackColor = true;
            this.btSmooth.Click += new System.EventHandler(this.btSmooth_Click);
            // 
            // panelOperations
            // 
            this.panelOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panelOperations.Controls.Add(this.btDilate);
            this.panelOperations.Controls.Add(this.btSkeletonize);
            this.panelOperations.Controls.Add(this.btPosterize);
            this.panelOperations.Controls.Add(this.btThresholdingGray);
            this.panelOperations.Controls.Add(this.btThresholding);
            this.panelOperations.Controls.Add(this.btNegative);
            this.panelOperations.Controls.Add(this.btToMono);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOperations.Location = new System.Drawing.Point(0, 481);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(150, 210);
            this.panelOperations.TabIndex = 10;
            // 
            // btDilate
            // 
            this.btDilate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDilate.FlatAppearance.BorderSize = 0;
            this.btDilate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDilate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btDilate.Location = new System.Drawing.Point(0, 180);
            this.btDilate.Name = "btDilate";
            this.btDilate.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btDilate.Size = new System.Drawing.Size(150, 30);
            this.btDilate.TabIndex = 7;
            this.btDilate.Text = "Dilate";
            this.btDilate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDilate.UseVisualStyleBackColor = true;
            this.btDilate.Click += new System.EventHandler(this.btDilate_Click);
            // 
            // btSkeletonize
            // 
            this.btSkeletonize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSkeletonize.FlatAppearance.BorderSize = 0;
            this.btSkeletonize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSkeletonize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btSkeletonize.Location = new System.Drawing.Point(0, 150);
            this.btSkeletonize.Name = "btSkeletonize";
            this.btSkeletonize.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btSkeletonize.Size = new System.Drawing.Size(150, 30);
            this.btSkeletonize.TabIndex = 6;
            this.btSkeletonize.Text = "Skeletonize";
            this.btSkeletonize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSkeletonize.UseVisualStyleBackColor = true;
            this.btSkeletonize.Click += new System.EventHandler(this.btSkeletonize_Click);
            // 
            // btPosterize
            // 
            this.btPosterize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPosterize.FlatAppearance.BorderSize = 0;
            this.btPosterize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPosterize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btPosterize.Location = new System.Drawing.Point(0, 120);
            this.btPosterize.Name = "btPosterize";
            this.btPosterize.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btPosterize.Size = new System.Drawing.Size(150, 30);
            this.btPosterize.TabIndex = 3;
            this.btPosterize.Text = "Posterize";
            this.btPosterize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPosterize.UseVisualStyleBackColor = true;
            this.btPosterize.Click += new System.EventHandler(this.btPosterize_Click);
            // 
            // btThresholdingGray
            // 
            this.btThresholdingGray.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThresholdingGray.FlatAppearance.BorderSize = 0;
            this.btThresholdingGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThresholdingGray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btThresholdingGray.Location = new System.Drawing.Point(0, 90);
            this.btThresholdingGray.Name = "btThresholdingGray";
            this.btThresholdingGray.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btThresholdingGray.Size = new System.Drawing.Size(150, 30);
            this.btThresholdingGray.TabIndex = 2;
            this.btThresholdingGray.Text = "Thresholding (Gray)";
            this.btThresholdingGray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThresholdingGray.UseVisualStyleBackColor = true;
            this.btThresholdingGray.Click += new System.EventHandler(this.btThresholdingGray_Click);
            // 
            // btThresholding
            // 
            this.btThresholding.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThresholding.FlatAppearance.BorderSize = 0;
            this.btThresholding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThresholding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btThresholding.Location = new System.Drawing.Point(0, 60);
            this.btThresholding.Name = "btThresholding";
            this.btThresholding.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btThresholding.Size = new System.Drawing.Size(150, 30);
            this.btThresholding.TabIndex = 5;
            this.btThresholding.Text = "Thresholding";
            this.btThresholding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThresholding.UseVisualStyleBackColor = true;
            this.btThresholding.Click += new System.EventHandler(this.btThresholding_Click);
            // 
            // btNegative
            // 
            this.btNegative.Dock = System.Windows.Forms.DockStyle.Top;
            this.btNegative.FlatAppearance.BorderSize = 0;
            this.btNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btNegative.Location = new System.Drawing.Point(0, 30);
            this.btNegative.Name = "btNegative";
            this.btNegative.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btNegative.Size = new System.Drawing.Size(150, 30);
            this.btNegative.TabIndex = 3;
            this.btNegative.Text = "Negative";
            this.btNegative.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNegative.UseVisualStyleBackColor = true;
            this.btNegative.Click += new System.EventHandler(this.btNegative_Click);
            // 
            // btToMono
            // 
            this.btToMono.Dock = System.Windows.Forms.DockStyle.Top;
            this.btToMono.FlatAppearance.BorderSize = 0;
            this.btToMono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btToMono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btToMono.Location = new System.Drawing.Point(0, 0);
            this.btToMono.Name = "btToMono";
            this.btToMono.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btToMono.Size = new System.Drawing.Size(150, 30);
            this.btToMono.TabIndex = 2;
            this.btToMono.Text = "Grayscale";
            this.btToMono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btToMono.UseVisualStyleBackColor = true;
            this.btToMono.Click += new System.EventHandler(this.btToMono_Click);
            // 
            // btOperations
            // 
            this.btOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btOperations.FlatAppearance.BorderSize = 0;
            this.btOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOperations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btOperations.Image = global::APO.Properties.Resources.operationsImage;
            this.btOperations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOperations.Location = new System.Drawing.Point(0, 441);
            this.btOperations.Name = "btOperations";
            this.btOperations.Size = new System.Drawing.Size(150, 40);
            this.btOperations.TabIndex = 9;
            this.btOperations.Text = "Operation    ";
            this.btOperations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOperations.UseVisualStyleBackColor = true;
            this.btOperations.Click += new System.EventHandler(this.btOperations_Click);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panelImage.Controls.Add(this.btEqualHistogram);
            this.panelImage.Controls.Add(this.btLnStrHistogram);
            this.panelImage.Controls.Add(this.btHistogram);
            this.panelImage.Controls.Add(this.btDuplicate);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.Location = new System.Drawing.Point(0, 321);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(150, 120);
            this.panelImage.TabIndex = 4;
            // 
            // btEqualHistogram
            // 
            this.btEqualHistogram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEqualHistogram.FlatAppearance.BorderSize = 0;
            this.btEqualHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEqualHistogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btEqualHistogram.Location = new System.Drawing.Point(0, 90);
            this.btEqualHistogram.Name = "btEqualHistogram";
            this.btEqualHistogram.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btEqualHistogram.Size = new System.Drawing.Size(150, 30);
            this.btEqualHistogram.TabIndex = 5;
            this.btEqualHistogram.Text = "Equal Histogram";
            this.btEqualHistogram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEqualHistogram.UseVisualStyleBackColor = true;
            this.btEqualHistogram.Click += new System.EventHandler(this.btEqualHistogram_Click);
            // 
            // btLnStrHistogram
            // 
            this.btLnStrHistogram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLnStrHistogram.FlatAppearance.BorderSize = 0;
            this.btLnStrHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLnStrHistogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btLnStrHistogram.Location = new System.Drawing.Point(0, 60);
            this.btLnStrHistogram.Name = "btLnStrHistogram";
            this.btLnStrHistogram.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btLnStrHistogram.Size = new System.Drawing.Size(150, 30);
            this.btLnStrHistogram.TabIndex = 4;
            this.btLnStrHistogram.Text = "Stretch Histogram";
            this.btLnStrHistogram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLnStrHistogram.UseVisualStyleBackColor = true;
            this.btLnStrHistogram.Click += new System.EventHandler(this.btLnStrHistogram_Click);
            // 
            // btHistogram
            // 
            this.btHistogram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHistogram.FlatAppearance.BorderSize = 0;
            this.btHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btHistogram.Location = new System.Drawing.Point(0, 30);
            this.btHistogram.Name = "btHistogram";
            this.btHistogram.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btHistogram.Size = new System.Drawing.Size(150, 30);
            this.btHistogram.TabIndex = 1;
            this.btHistogram.Text = "Histogram";
            this.btHistogram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHistogram.UseVisualStyleBackColor = true;
            this.btHistogram.Click += new System.EventHandler(this.btHistogram_Click);
            // 
            // btDuplicate
            // 
            this.btDuplicate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDuplicate.FlatAppearance.BorderSize = 0;
            this.btDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDuplicate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btDuplicate.Location = new System.Drawing.Point(0, 0);
            this.btDuplicate.Name = "btDuplicate";
            this.btDuplicate.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btDuplicate.Size = new System.Drawing.Size(150, 30);
            this.btDuplicate.TabIndex = 0;
            this.btDuplicate.Text = "Duplicate";
            this.btDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDuplicate.UseVisualStyleBackColor = true;
            this.btDuplicate.Click += new System.EventHandler(this.btDuplicate_Click);
            // 
            // btImage
            // 
            this.btImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btImage.FlatAppearance.BorderSize = 0;
            this.btImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btImage.Image = global::APO.Properties.Resources.openImage;
            this.btImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImage.Location = new System.Drawing.Point(0, 281);
            this.btImage.Name = "btImage";
            this.btImage.Size = new System.Drawing.Size(150, 40);
            this.btImage.TabIndex = 3;
            this.btImage.Text = "Image";
            this.btImage.UseVisualStyleBackColor = true;
            this.btImage.Click += new System.EventHandler(this.btImage_Click);
            // 
            // panelFile
            // 
            this.panelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panelFile.Controls.Add(this.btClose);
            this.panelFile.Controls.Add(this.btSave);
            this.panelFile.Controls.Add(this.btOpen);
            this.panelFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFile.Location = new System.Drawing.Point(0, 191);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(150, 90);
            this.panelFile.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btClose.Location = new System.Drawing.Point(0, 60);
            this.btClose.Name = "btClose";
            this.btClose.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btClose.Size = new System.Drawing.Size(150, 30);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btSave.Location = new System.Drawing.Point(0, 30);
            this.btSave.Name = "btSave";
            this.btSave.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btSave.Size = new System.Drawing.Size(150, 30);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save as...";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btOpen
            // 
            this.btOpen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btOpen.FlatAppearance.BorderSize = 0;
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btOpen.Location = new System.Drawing.Point(0, 0);
            this.btOpen.Name = "btOpen";
            this.btOpen.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btOpen.Size = new System.Drawing.Size(150, 30);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "Open...";
            this.btOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btFile
            // 
            this.btFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFile.FlatAppearance.BorderSize = 0;
            this.btFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btFile.Image = global::APO.Properties.Resources.openFile;
            this.btFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFile.Location = new System.Drawing.Point(0, 151);
            this.btFile.Name = "btFile";
            this.btFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btFile.Size = new System.Drawing.Size(150, 40);
            this.btFile.TabIndex = 1;
            this.btFile.Text = "File";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 151);
            this.panelLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelLogo.Location = new System.Drawing.Point(0, 120);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(150, 31);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "APO";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::APO.Properties.Resources.WIT_Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelWorkSpace
            // 
            this.panelWorkSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelWorkSpace.Controls.Add(this.tcWorkSpace);
            this.panelWorkSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkSpace.Location = new System.Drawing.Point(150, 40);
            this.panelWorkSpace.Name = "panelWorkSpace";
            this.panelWorkSpace.Size = new System.Drawing.Size(800, 537);
            this.panelWorkSpace.TabIndex = 2;
            // 
            // tcWorkSpace
            // 
            this.tcWorkSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcWorkSpace.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tcWorkSpace.Location = new System.Drawing.Point(0, 0);
            this.tcWorkSpace.Name = "tcWorkSpace";
            this.tcWorkSpace.Size = new System.Drawing.Size(800, 537);
            this.tcWorkSpace.Style = MetroFramework.MetroColorStyle.Purple;
            this.tcWorkSpace.TabIndex = 0;
            this.tcWorkSpace.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcWorkSpace.UseSelectable = true;
            this.tcWorkSpace.SelectedIndexChanged += new System.EventHandler(this.tcWorkSpace_SelectedIndexChanged);
            this.tcWorkSpace.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tcWorkSpace_ControlAdded);
            this.tcWorkSpace.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tcWorkSpace_ControlRemoved);
            // 
            // panelListWorkSpace
            // 
            this.panelListWorkSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panelListWorkSpace.Controls.Add(this.btMinimize);
            this.panelListWorkSpace.Controls.Add(this.btRestoreDown);
            this.panelListWorkSpace.Controls.Add(this.btMaximize);
            this.panelListWorkSpace.Controls.Add(this.btExit);
            this.panelListWorkSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListWorkSpace.Location = new System.Drawing.Point(150, 0);
            this.panelListWorkSpace.Name = "panelListWorkSpace";
            this.panelListWorkSpace.Size = new System.Drawing.Size(800, 40);
            this.panelListWorkSpace.TabIndex = 1;
            this.panelListWorkSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelListWorkSpace_MouseDown);
            this.panelListWorkSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelListWorkSpace_MouseMove);
            this.panelListWorkSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelListWorkSpace_MouseUp);
            // 
            // btMinimize
            // 
            this.btMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Image = global::APO.Properties.Resources.icons8_subtract_20;
            this.btMinimize.Location = new System.Drawing.Point(520, 0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(70, 40);
            this.btMinimize.TabIndex = 3;
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btRestoreDown
            // 
            this.btRestoreDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.btRestoreDown.FlatAppearance.BorderSize = 0;
            this.btRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestoreDown.Image = global::APO.Properties.Resources.icons8_restore_down_20;
            this.btRestoreDown.Location = new System.Drawing.Point(590, 0);
            this.btRestoreDown.Name = "btRestoreDown";
            this.btRestoreDown.Size = new System.Drawing.Size(70, 40);
            this.btRestoreDown.TabIndex = 2;
            this.btRestoreDown.UseVisualStyleBackColor = true;
            this.btRestoreDown.Visible = false;
            this.btRestoreDown.Click += new System.EventHandler(this.btRestoreDown_Click);
            // 
            // btMaximize
            // 
            this.btMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMaximize.FlatAppearance.BorderSize = 0;
            this.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximize.Image = global::APO.Properties.Resources.icons8_maximize_button_20;
            this.btMaximize.Location = new System.Drawing.Point(660, 0);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Size = new System.Drawing.Size(70, 40);
            this.btMaximize.TabIndex = 1;
            this.btMaximize.UseVisualStyleBackColor = true;
            this.btMaximize.Click += new System.EventHandler(this.btMaximize_Click);
            // 
            // btExit
            // 
            this.btExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Image = global::APO.Properties.Resources.icons8_close_20;
            this.btExit.Location = new System.Drawing.Point(730, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(70, 40);
            this.btExit.TabIndex = 0;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 577);
            this.Controls.Add(this.panelWorkSpace);
            this.Controls.Add(this.panelListWorkSpace);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APO";
            this.panelLeft.ResumeLayout(false);
            this.panelSteganography.ResumeLayout(false);
            this.panelSegmentation.ResumeLayout(false);
            this.panelSharp.ResumeLayout(false);
            this.panelSmooth.ResumeLayout(false);
            this.panelOperations.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            this.panelFile.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelWorkSpace.ResumeLayout(false);
            this.panelListWorkSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelFile;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panelWorkSpace;
        private System.Windows.Forms.Panel panelListWorkSpace;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRestoreDown;
        private System.Windows.Forms.Button btMaximize;
        private System.Windows.Forms.Button btMinimize;
        private MetroFramework.Controls.MetroTabControl tcWorkSpace;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Button btDuplicate;
        private System.Windows.Forms.Button btImage;
        private System.Windows.Forms.Button btHistogram;
        private System.Windows.Forms.Panel panelSmooth;
        private System.Windows.Forms.Button btGaussianBlur;
        private System.Windows.Forms.Button btBlur;
        private System.Windows.Forms.Button btSmooth;
        private System.Windows.Forms.Panel panelSharp;
        private System.Windows.Forms.Button btSobel;
        private System.Windows.Forms.Button btSharp;
        private System.Windows.Forms.Button btCanny;
        private System.Windows.Forms.Button btLaplacian;
        private System.Windows.Forms.Button btToMono;
        private System.Windows.Forms.Button btNegative;
        private System.Windows.Forms.Button btLnStrHistogram;
        private System.Windows.Forms.Button btEqualHistogram;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Button btPosterize;
        private System.Windows.Forms.Button btThresholdingGray;
        private System.Windows.Forms.Button btThresholding;
        private System.Windows.Forms.Button btOperations;
        private System.Windows.Forms.Button btPrewitt;
        private System.Windows.Forms.Panel panelSegmentation;
        private System.Windows.Forms.Button btOtsu;
        private System.Windows.Forms.Button btWatershed;
        private System.Windows.Forms.Button btSegmentation;
        private System.Windows.Forms.Button btSkeletonize;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btMedian;
        private System.Windows.Forms.Button btDilate;
        private System.Windows.Forms.Button btSteganography;
        private System.Windows.Forms.Panel panelSteganography;
        private System.Windows.Forms.Button btUnmerge;
        private System.Windows.Forms.Button btMerge;
    }
}


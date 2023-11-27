namespace ImageProcessingActivity
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forFirstImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forSecondImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBasicCopy = new System.Windows.Forms.Button();
            this.btnGreyscale = new System.Windows.Forms.Button();
            this.btnColorInversion = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.btnSepia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBoxWebcam = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1304, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 600);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1950, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forFirstImageToolStripMenuItem,
            this.forSecondImageToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // forFirstImageToolStripMenuItem
            // 
            this.forFirstImageToolStripMenuItem.Name = "forFirstImageToolStripMenuItem";
            this.forFirstImageToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.forFirstImageToolStripMenuItem.Text = "For First Image";
            this.forFirstImageToolStripMenuItem.Click += new System.EventHandler(this.forFirstImageToolStripMenuItem_Click);
            // 
            // forSecondImageToolStripMenuItem
            // 
            this.forSecondImageToolStripMenuItem.Name = "forSecondImageToolStripMenuItem";
            this.forSecondImageToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.forSecondImageToolStripMenuItem.Text = "For Second Image";
            this.forSecondImageToolStripMenuItem.Click += new System.EventHandler(this.forSecondImageToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // btnBasicCopy
            // 
            this.btnBasicCopy.Location = new System.Drawing.Point(6, 25);
            this.btnBasicCopy.Name = "btnBasicCopy";
            this.btnBasicCopy.Size = new System.Drawing.Size(142, 57);
            this.btnBasicCopy.TabIndex = 3;
            this.btnBasicCopy.Text = "Basic Copy";
            this.btnBasicCopy.UseVisualStyleBackColor = true;
            this.btnBasicCopy.Click += new System.EventHandler(this.btnBasicCopy_Click);
            // 
            // btnGreyscale
            // 
            this.btnGreyscale.Location = new System.Drawing.Point(154, 25);
            this.btnGreyscale.Name = "btnGreyscale";
            this.btnGreyscale.Size = new System.Drawing.Size(142, 57);
            this.btnGreyscale.TabIndex = 4;
            this.btnGreyscale.Text = " Greyscale";
            this.btnGreyscale.UseVisualStyleBackColor = true;
            this.btnGreyscale.Click += new System.EventHandler(this.btnGreyscale_Click);
            // 
            // btnColorInversion
            // 
            this.btnColorInversion.Location = new System.Drawing.Point(302, 25);
            this.btnColorInversion.Name = "btnColorInversion";
            this.btnColorInversion.Size = new System.Drawing.Size(142, 57);
            this.btnColorInversion.TabIndex = 5;
            this.btnColorInversion.Text = "Color Inversion";
            this.btnColorInversion.UseVisualStyleBackColor = true;
            this.btnColorInversion.Click += new System.EventHandler(this.btnColorInversion_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.Location = new System.Drawing.Point(450, 25);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(142, 57);
            this.btnHistogram.TabIndex = 6;
            this.btnHistogram.Text = "Histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // btnSepia
            // 
            this.btnSepia.Location = new System.Drawing.Point(6, 88);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(142, 57);
            this.btnSepia.TabIndex = 7;
            this.btnSepia.Text = "Sepia";
            this.btnSepia.UseVisualStyleBackColor = true;
            this.btnSepia.Click += new System.EventHandler(this.btnSepia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubtract);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.btnReplace);
            this.groupBox1.Controls.Add(this.btnBasicCopy);
            this.groupBox1.Controls.Add(this.btnSepia);
            this.groupBox1.Controls.Add(this.btnGreyscale);
            this.groupBox1.Controls.Add(this.btnHistogram);
            this.groupBox1.Controls.Add(this.btnColorInversion);
            this.groupBox1.Location = new System.Drawing.Point(37, 749);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 158);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Manipulation Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(450, 88);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(142, 57);
            this.btnSubtract.TabIndex = 10;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(302, 88);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(142, 57);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore Original Image";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(154, 88);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(142, 57);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "Replace Original Image";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loaded Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(886, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Second Loaded Image";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(670, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(600, 600);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1554, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Result Image";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1285, 1235);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 57);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBoxWebcam
            // 
            this.pictureBoxWebcam.Location = new System.Drawing.Point(670, 692);
            this.pictureBoxWebcam.Name = "pictureBoxWebcam";
            this.pictureBoxWebcam.Size = new System.Drawing.Size(600, 600);
            this.pictureBoxWebcam.TabIndex = 13;
            this.pictureBoxWebcam.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(933, 1295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Webcam";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(1433, 1235);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(142, 57);
            this.btnEnd.TabIndex = 15;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1950, 1349);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxWebcam);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Manipulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btnBasicCopy;
        private System.Windows.Forms.Button btnGreyscale;
        private System.Windows.Forms.Button btnColorInversion;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.Button btnSepia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem forFirstImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forSecondImageToolStripMenuItem;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBoxWebcam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnd;
    }
}


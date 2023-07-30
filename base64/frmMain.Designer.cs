namespace base64
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnChooseImg = new System.Windows.Forms.Button();
            this.picImage1 = new System.Windows.Forms.PictureBox();
            this.gpEncoder = new System.Windows.Forms.GroupBox();
            this.lblNbrChar1 = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.btnImgToBase64 = new System.Windows.Forms.Button();
            this.lblBase64 = new System.Windows.Forms.Label();
            this.txtImgToBase64 = new System.Windows.Forms.TextBox();
            this.gpDecoder = new System.Windows.Forms.GroupBox();
            this.lblNbrChar2 = new System.Windows.Forms.Label();
            this.btnBase64ToImg = new System.Windows.Forms.Button();
            this.picImage2 = new System.Windows.Forms.PictureBox();
            this.txtBase64ToImg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).BeginInit();
            this.gpEncoder.SuspendLayout();
            this.gpDecoder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseImg
            // 
            this.btnChooseImg.Location = new System.Drawing.Point(9, 169);
            this.btnChooseImg.Name = "btnChooseImg";
            this.btnChooseImg.Size = new System.Drawing.Size(88, 23);
            this.btnChooseImg.TabIndex = 0;
            this.btnChooseImg.Text = "...";
            this.btnChooseImg.UseVisualStyleBackColor = true;
            this.btnChooseImg.Click += new System.EventHandler(this.btnChooseImg_Click);
            // 
            // picImage1
            // 
            this.picImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage1.Location = new System.Drawing.Point(9, 39);
            this.picImage1.Name = "picImage1";
            this.picImage1.Size = new System.Drawing.Size(182, 124);
            this.picImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage1.TabIndex = 1;
            this.picImage1.TabStop = false;
            // 
            // gpEncoder
            // 
            this.gpEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpEncoder.Controls.Add(this.lblNbrChar1);
            this.gpEncoder.Controls.Add(this.lblImg);
            this.gpEncoder.Controls.Add(this.btnImgToBase64);
            this.gpEncoder.Controls.Add(this.lblBase64);
            this.gpEncoder.Controls.Add(this.txtImgToBase64);
            this.gpEncoder.Controls.Add(this.picImage1);
            this.gpEncoder.Controls.Add(this.btnChooseImg);
            this.gpEncoder.Location = new System.Drawing.Point(12, 19);
            this.gpEncoder.Name = "gpEncoder";
            this.gpEncoder.Size = new System.Drawing.Size(791, 199);
            this.gpEncoder.TabIndex = 2;
            this.gpEncoder.TabStop = false;
            this.gpEncoder.Text = "Encoder";
            // 
            // lblNbrChar1
            // 
            this.lblNbrChar1.AutoSize = true;
            this.lblNbrChar1.Location = new System.Drawing.Point(197, 174);
            this.lblNbrChar1.Name = "lblNbrChar1";
            this.lblNbrChar1.Size = new System.Drawing.Size(0, 13);
            this.lblNbrChar1.TabIndex = 6;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(6, 19);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(36, 13);
            this.lblImg.TabIndex = 4;
            this.lblImg.Text = "Image";
            // 
            // btnImgToBase64
            // 
            this.btnImgToBase64.Location = new System.Drawing.Point(103, 169);
            this.btnImgToBase64.Name = "btnImgToBase64";
            this.btnImgToBase64.Size = new System.Drawing.Size(88, 23);
            this.btnImgToBase64.TabIndex = 0;
            this.btnImgToBase64.Text = "Img To Base64";
            this.btnImgToBase64.UseVisualStyleBackColor = true;
            this.btnImgToBase64.Click += new System.EventHandler(this.btnImgToBase64_Click);
            // 
            // lblBase64
            // 
            this.lblBase64.AutoSize = true;
            this.lblBase64.Location = new System.Drawing.Point(197, 19);
            this.lblBase64.Name = "lblBase64";
            this.lblBase64.Size = new System.Drawing.Size(43, 13);
            this.lblBase64.TabIndex = 3;
            this.lblBase64.Text = "Base64";
            // 
            // txtImgToBase64
            // 
            this.txtImgToBase64.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImgToBase64.BackColor = System.Drawing.SystemColors.Control;
            this.txtImgToBase64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImgToBase64.Location = new System.Drawing.Point(197, 39);
            this.txtImgToBase64.Multiline = true;
            this.txtImgToBase64.Name = "txtImgToBase64";
            this.txtImgToBase64.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtImgToBase64.Size = new System.Drawing.Size(588, 124);
            this.txtImgToBase64.TabIndex = 2;
            this.txtImgToBase64.TextChanged += new System.EventHandler(this.txtImgToBase64_TextChanged);
            // 
            // gpDecoder
            // 
            this.gpDecoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpDecoder.Controls.Add(this.lblNbrChar2);
            this.gpDecoder.Controls.Add(this.btnBase64ToImg);
            this.gpDecoder.Controls.Add(this.picImage2);
            this.gpDecoder.Controls.Add(this.txtBase64ToImg);
            this.gpDecoder.Location = new System.Drawing.Point(12, 232);
            this.gpDecoder.Name = "gpDecoder";
            this.gpDecoder.Size = new System.Drawing.Size(791, 183);
            this.gpDecoder.TabIndex = 3;
            this.gpDecoder.TabStop = false;
            this.gpDecoder.Text = "Decoder";
            // 
            // lblNbrChar2
            // 
            this.lblNbrChar2.AutoSize = true;
            this.lblNbrChar2.Location = new System.Drawing.Point(104, 154);
            this.lblNbrChar2.Name = "lblNbrChar2";
            this.lblNbrChar2.Size = new System.Drawing.Size(0, 13);
            this.lblNbrChar2.TabIndex = 7;
            // 
            // btnBase64ToImg
            // 
            this.btnBase64ToImg.Location = new System.Drawing.Point(9, 149);
            this.btnBase64ToImg.Name = "btnBase64ToImg";
            this.btnBase64ToImg.Size = new System.Drawing.Size(88, 23);
            this.btnBase64ToImg.TabIndex = 4;
            this.btnBase64ToImg.Text = "Base64 To Img";
            this.btnBase64ToImg.UseVisualStyleBackColor = true;
            this.btnBase64ToImg.Click += new System.EventHandler(this.btnBase64ToImg_Click);
            // 
            // picImage2
            // 
            this.picImage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage2.Location = new System.Drawing.Point(603, 19);
            this.picImage2.Name = "picImage2";
            this.picImage2.Size = new System.Drawing.Size(182, 124);
            this.picImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage2.TabIndex = 4;
            this.picImage2.TabStop = false;
            // 
            // txtBase64ToImg
            // 
            this.txtBase64ToImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBase64ToImg.BackColor = System.Drawing.SystemColors.Control;
            this.txtBase64ToImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBase64ToImg.Location = new System.Drawing.Point(9, 19);
            this.txtBase64ToImg.Multiline = true;
            this.txtBase64ToImg.Name = "txtBase64ToImg";
            this.txtBase64ToImg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBase64ToImg.Size = new System.Drawing.Size(588, 124);
            this.txtBase64ToImg.TabIndex = 3;
            this.txtBase64ToImg.TextChanged += new System.EventHandler(this.txtBase64ToImg_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 425);
            this.Controls.Add(this.gpDecoder);
            this.Controls.Add(this.gpEncoder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Image operation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).EndInit();
            this.gpEncoder.ResumeLayout(false);
            this.gpEncoder.PerformLayout();
            this.gpDecoder.ResumeLayout(false);
            this.gpDecoder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseImg;
        private System.Windows.Forms.PictureBox picImage1;
        private System.Windows.Forms.GroupBox gpEncoder;
        private System.Windows.Forms.Label lblBase64;
        private System.Windows.Forms.TextBox txtImgToBase64;
        private System.Windows.Forms.GroupBox gpDecoder;
        private System.Windows.Forms.Button btnImgToBase64;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.TextBox txtBase64ToImg;
        private System.Windows.Forms.Button btnBase64ToImg;
        private System.Windows.Forms.PictureBox picImage2;
        private System.Windows.Forms.Label lblNbrChar1;
        private System.Windows.Forms.Label lblNbrChar2;
    }
}


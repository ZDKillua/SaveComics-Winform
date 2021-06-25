namespace SaveTheComic.GUI
{
    partial class ucComic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucComic));
            this.labName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.labChap = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labHot = new System.Windows.Forms.Label();
            this.elipseControl1 = new SaveTheComic.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.Color.White;
            this.labName.Location = new System.Drawing.Point(3, 154);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(226, 39);
            this.labName.TabIndex = 1;
            this.labName.Text = "Comic Name";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(8, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chap";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(8, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last read";
            // 
            // picAnh
            // 
            this.picAnh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAnh.Image = ((System.Drawing.Image)(resources.GetObject("picAnh.Image")));
            this.picAnh.Location = new System.Drawing.Point(0, 0);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(232, 151);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            // 
            // labChap
            // 
            this.labChap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labChap.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labChap.ForeColor = System.Drawing.Color.Yellow;
            this.labChap.Location = new System.Drawing.Point(132, 191);
            this.labChap.Name = "labChap";
            this.labChap.Size = new System.Drawing.Size(100, 23);
            this.labChap.TabIndex = 4;
            this.labChap.Text = "120";
            this.labChap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labDate
            // 
            this.labDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.ForeColor = System.Drawing.Color.Yellow;
            this.labDate.Location = new System.Drawing.Point(132, 212);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(100, 23);
            this.labDate.TabIndex = 5;
            this.labDate.Text = "17/01/2021";
            this.labDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labHot
            // 
            this.labHot.BackColor = System.Drawing.Color.Red;
            this.labHot.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHot.ForeColor = System.Drawing.Color.White;
            this.labHot.Location = new System.Drawing.Point(-3, 5);
            this.labHot.Name = "labHot";
            this.labHot.Size = new System.Drawing.Size(49, 18);
            this.labHot.TabIndex = 7;
            this.labHot.Text = "HOT";
            this.labHot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 0;
            this.elipseControl1.TargetControl = this;
            // 
            // ucComic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.labHot);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labChap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDate);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucComic";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(232, 246);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labChap;
        private System.Windows.Forms.Label labDate;
        public System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label labHot;
        private ElipseControl elipseControl1;
    }
}

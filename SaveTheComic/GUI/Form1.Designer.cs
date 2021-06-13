namespace SaveTheComic.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.sideBar = new System.Windows.Forms.Panel();
            this.btnOthers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManga = new System.Windows.Forms.Button();
            this.btnManhua = new System.Windows.Forms.Button();
            this.btnManhwa = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.elipseControl1 = new SaveTheComic.ElipseControl();
            this.panelLeft.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLeft.Controls.Add(this.panelMenu);
            this.panelLeft.Controls.Add(this.panelUser);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(185, 649);
            this.panelLeft.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.Controls.Add(this.sideBar);
            this.panelMenu.Controls.Add(this.btnOthers);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnManga);
            this.panelMenu.Controls.Add(this.btnManhua);
            this.panelMenu.Controls.Add(this.btnManhwa);
            this.panelMenu.Controls.Add(this.btnAll);
            this.panelMenu.Location = new System.Drawing.Point(0, 135);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(185, 514);
            this.panelMenu.TabIndex = 2;
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Yellow;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(12, 58);
            this.sideBar.TabIndex = 4;
            // 
            // btnOthers
            // 
            this.btnOthers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOthers.FlatAppearance.BorderSize = 0;
            this.btnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.ForeColor = System.Drawing.Color.White;
            this.btnOthers.Image = global::SaveTheComic.Properties.Resources.Others32;
            this.btnOthers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOthers.Location = new System.Drawing.Point(0, 232);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnOthers.Size = new System.Drawing.Size(185, 58);
            this.btnOthers.TabIndex = 5;
            this.btnOthers.Tag = "4";
            this.btnOthers.Text = "Others";
            this.btnOthers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOthers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOthers.UseVisualStyleBackColor = true;
            this.btnOthers.Click += new System.EventHandler(this.btnManhwa_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copyright by Killua";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManga
            // 
            this.btnManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManga.FlatAppearance.BorderSize = 0;
            this.btnManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManga.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManga.ForeColor = System.Drawing.Color.White;
            this.btnManga.Image = global::SaveTheComic.Properties.Resources.japan32;
            this.btnManga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManga.Location = new System.Drawing.Point(0, 174);
            this.btnManga.Name = "btnManga";
            this.btnManga.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManga.Size = new System.Drawing.Size(185, 58);
            this.btnManga.TabIndex = 3;
            this.btnManga.Tag = "3";
            this.btnManga.Text = "Manga";
            this.btnManga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManga.UseVisualStyleBackColor = true;
            this.btnManga.Click += new System.EventHandler(this.btnManhwa_Click);
            // 
            // btnManhua
            // 
            this.btnManhua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManhua.FlatAppearance.BorderSize = 0;
            this.btnManhua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManhua.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManhua.ForeColor = System.Drawing.Color.White;
            this.btnManhua.Image = global::SaveTheComic.Properties.Resources.china32;
            this.btnManhua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManhua.Location = new System.Drawing.Point(0, 116);
            this.btnManhua.Name = "btnManhua";
            this.btnManhua.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManhua.Size = new System.Drawing.Size(185, 58);
            this.btnManhua.TabIndex = 2;
            this.btnManhua.Tag = "2";
            this.btnManhua.Text = "Manhua";
            this.btnManhua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManhua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManhua.UseVisualStyleBackColor = true;
            this.btnManhua.Click += new System.EventHandler(this.btnManhwa_Click);
            // 
            // btnManhwa
            // 
            this.btnManhwa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManhwa.FlatAppearance.BorderSize = 0;
            this.btnManhwa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManhwa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManhwa.ForeColor = System.Drawing.Color.White;
            this.btnManhwa.Image = global::SaveTheComic.Properties.Resources.korea32;
            this.btnManhwa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManhwa.Location = new System.Drawing.Point(0, 58);
            this.btnManhwa.Name = "btnManhwa";
            this.btnManhwa.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManhwa.Size = new System.Drawing.Size(185, 58);
            this.btnManhwa.TabIndex = 1;
            this.btnManhwa.Tag = "1";
            this.btnManhwa.Text = "Manhwa";
            this.btnManhwa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManhwa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManhwa.UseVisualStyleBackColor = true;
            this.btnManhwa.Click += new System.EventHandler(this.btnManhwa_Click);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Image = global::SaveTheComic.Properties.Resources.TheEarth32;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(0, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAll.Size = new System.Drawing.Size(185, 58);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.labUser);
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(185, 130);
            this.panelUser.TabIndex = 2;
            // 
            // labUser
            // 
            this.labUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUser.ForeColor = System.Drawing.Color.White;
            this.labUser.Location = new System.Drawing.Point(3, 76);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(179, 36);
            this.labUser.TabIndex = 2;
            this.labUser.Text = "Save Comics";
            this.labUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::SaveTheComic.Properties.Resources.KilluaChibi;
            this.pictureBox1.Location = new System.Drawing.Point(56, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(191, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(955, 507);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(954, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lọc";
            // 
            // cboLoc
            // 
            this.cboLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(991, 101);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(155, 24);
            this.cboLoc.TabIndex = 5;
            this.cboLoc.SelectedIndexChanged += new System.EventHandler(this.cboLoc_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnDelete.Image = global::SaveTheComic.Properties.Resources.delete24;
            this.btnDelete.Location = new System.Drawing.Point(279, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnEdit.Image = global::SaveTheComic.Properties.Resources.edit24;
            this.btnEdit.Location = new System.Drawing.Point(235, 88);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(38, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAdd.Image = global::SaveTheComic.Properties.Resources.add24;
            this.btnAdd.Location = new System.Drawing.Point(191, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSize = true;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnExit.Image = global::SaveTheComic.Properties.Resources.ExitIcon24;
            this.btnExit.Location = new System.Drawing.Point(1120, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnMinimize.Image = global::SaveTheComic.Properties.Resources.MinimizeIcon24;
            this.btnMinimize.Location = new System.Drawing.Point(1032, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 36);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.AutoSize = true;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnMaximize.Image = global::SaveTheComic.Properties.Resources.MaximizeIcon24;
            this.btnMaximize.Location = new System.Drawing.Point(1076, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(38, 36);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 15;
            this.elipseControl1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1158, 649);
            this.Controls.Add(this.cboLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save The Comic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnManhua;
        private System.Windows.Forms.Button btnManhwa;
        private System.Windows.Forms.Button btnManga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOthers;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoc;
    }
}


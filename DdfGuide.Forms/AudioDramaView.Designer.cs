namespace DdfGuide.Forms
{
    partial class AudioDramaView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxIsFavorite = new System.Windows.Forms.CheckBox();
            this.checkBoxHeard = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.pictureBoxCover);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.checkBoxIsFavorite);
            this.panel1.Controls.Add(this.checkBoxHeard);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 471);
            this.panel1.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.Location = new System.Drawing.Point(209, 112);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(440, 244);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "description";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 10;
            this.pictureBoxCover.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(208, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(140, 29);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "labelName";
            // 
            // checkBoxIsFavorite
            // 
            this.checkBoxIsFavorite.AutoSize = true;
            this.checkBoxIsFavorite.Location = new System.Drawing.Point(213, 85);
            this.checkBoxIsFavorite.Name = "checkBoxIsFavorite";
            this.checkBoxIsFavorite.Size = new System.Drawing.Size(105, 24);
            this.checkBoxIsFavorite.TabIndex = 8;
            this.checkBoxIsFavorite.Text = "IsFavorite";
            this.checkBoxIsFavorite.UseVisualStyleBackColor = true;
            this.checkBoxIsFavorite.Click += new System.EventHandler(this.checkBoxIsFavorite_Click);
            // 
            // checkBoxHeard
            // 
            this.checkBoxHeard.AutoSize = true;
            this.checkBoxHeard.Location = new System.Drawing.Point(213, 55);
            this.checkBoxHeard.Name = "checkBoxHeard";
            this.checkBoxHeard.Size = new System.Drawing.Size(79, 24);
            this.checkBoxHeard.TabIndex = 7;
            this.checkBoxHeard.Text = "Heard";
            this.checkBoxHeard.UseVisualStyleBackColor = true;
            this.checkBoxHeard.Click += new System.EventHandler(this.checkBoxHeard_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(209, 3);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(56, 20);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "labelId";
            // 
            // AudioDramaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AudioDramaView";
            this.Size = new System.Drawing.Size(670, 504);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxIsFavorite;
        private System.Windows.Forms.CheckBox checkBoxHeard;
        private System.Windows.Forms.Label labelId;
    }
}
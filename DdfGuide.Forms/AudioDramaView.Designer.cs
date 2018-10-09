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
            this.labelId = new System.Windows.Forms.Label();
            this.checkBoxHeard = new System.Windows.Forms.CheckBox();
            this.checkBoxIsFavorite = new System.Windows.Forms.CheckBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(218, 12);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(56, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "labelId";
            // 
            // checkBoxHeard
            // 
            this.checkBoxHeard.AutoSize = true;
            this.checkBoxHeard.Location = new System.Drawing.Point(222, 64);
            this.checkBoxHeard.Name = "checkBoxHeard";
            this.checkBoxHeard.Size = new System.Drawing.Size(79, 24);
            this.checkBoxHeard.TabIndex = 1;
            this.checkBoxHeard.Text = "Heard";
            this.checkBoxHeard.UseVisualStyleBackColor = true;
            this.checkBoxHeard.Click += new System.EventHandler(this.checkBoxHeard_Click);
            // 
            // checkBoxIsFavorite
            // 
            this.checkBoxIsFavorite.AutoSize = true;
            this.checkBoxIsFavorite.Location = new System.Drawing.Point(222, 94);
            this.checkBoxIsFavorite.Name = "checkBoxIsFavorite";
            this.checkBoxIsFavorite.Size = new System.Drawing.Size(105, 24);
            this.checkBoxIsFavorite.TabIndex = 2;
            this.checkBoxIsFavorite.Text = "IsFavorite";
            this.checkBoxIsFavorite.UseVisualStyleBackColor = true;
            this.checkBoxIsFavorite.Click += new System.EventHandler(this.checkBoxIsFavorite_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(217, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(140, 29);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "labelName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AudioDramaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.checkBoxIsFavorite);
            this.Controls.Add(this.checkBoxHeard);
            this.Controls.Add(this.labelId);
            this.Name = "AudioDramaView";
            this.Text = "AudioDramaView";
            this.DoubleClick += new System.EventHandler(this.AudioDramaView_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.CheckBox checkBoxHeard;
        private System.Windows.Forms.CheckBox checkBoxIsFavorite;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
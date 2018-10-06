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
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(56, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "labelId";
            // 
            // checkBoxHeard
            // 
            this.checkBoxHeard.AutoSize = true;
            this.checkBoxHeard.Location = new System.Drawing.Point(12, 52);
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
            this.checkBoxIsFavorite.Location = new System.Drawing.Point(12, 82);
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
            this.labelName.Location = new System.Drawing.Point(12, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "labelName";
            // 
            // AudioDramaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 213);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.checkBoxIsFavorite);
            this.Controls.Add(this.checkBoxHeard);
            this.Controls.Add(this.labelId);
            this.Name = "AudioDramaView";
            this.Text = "AudioDramaView";
            this.DoubleClick += new System.EventHandler(this.AudioDramaView_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.CheckBox checkBoxHeard;
        private System.Windows.Forms.CheckBox checkBoxIsFavorite;
        private System.Windows.Forms.Label labelName;
    }
}
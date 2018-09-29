namespace DdfGuide.Forms
{
    partial class AudioDramaListView
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewAudioDramas = new System.Windows.Forms.DataGridView();
            this.audioDramaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.audioDramaUserDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudioDramas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioDramaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioDramaUserDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAudioDramas
            // 
            this.dataGridViewAudioDramas.AllowUserToAddRows = false;
            this.dataGridViewAudioDramas.AllowUserToDeleteRows = false;
            this.dataGridViewAudioDramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAudioDramas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAudioDramas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAudioDramas.MultiSelect = false;
            this.dataGridViewAudioDramas.Name = "dataGridViewAudioDramas";
            this.dataGridViewAudioDramas.ReadOnly = true;
            this.dataGridViewAudioDramas.RowTemplate.Height = 28;
            this.dataGridViewAudioDramas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAudioDramas.Size = new System.Drawing.Size(990, 560);
            this.dataGridViewAudioDramas.TabIndex = 0;
            this.dataGridViewAudioDramas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAudioDramas_CellContentClick);
            this.dataGridViewAudioDramas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAudioDramas_CellDoubleClick);
            this.dataGridViewAudioDramas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAudioDramas_CellValueChanged);
            // 
            // audioDramaBindingSource
            // 
            this.audioDramaBindingSource.DataSource = typeof(DdfGuide.Core.Models.AudioDrama);
            // 
            // audioDramaUserDataBindingSource
            // 
            this.audioDramaUserDataBindingSource.DataSource = typeof(DdfGuide.Core.Models.AudioDramaUserData);
            // 
            // AudioDramaListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 560);
            this.Controls.Add(this.dataGridViewAudioDramas);
            this.Name = "AudioDramaListView";
            this.Text = "AudioDramaListView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudioDramas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioDramaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioDramaUserDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAudioDramas;
        private System.Windows.Forms.BindingSource audioDramaBindingSource;
        private System.Windows.Forms.BindingSource audioDramaUserDataBindingSource;
    }
}


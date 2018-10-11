﻿using DdfGuide.Core;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heardFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heardLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberAscendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberDescendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseAscendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDescendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameAscendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameDescendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAudioDramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeMainAudioDramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialAudioDramasOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unheardOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridViewAudioDramas = new System.Windows.Forms.DataGridView();
            this.audioDramaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.audioDramaUserDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudioDramas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioDramaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioDramaUserDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderingToolStripMenuItem,
            this.filteringToolStripMenuItem,
            this.toolStripSearchBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderingToolStripMenuItem
            // 
            this.orderingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heardFirstToolStripMenuItem,
            this.heardLastToolStripMenuItem,
            this.favoritesFirstToolStripMenuItem,
            this.favoritesLastToolStripMenuItem,
            this.numberAscendingToolStripMenuItem,
            this.numberDescendingToolStripMenuItem,
            this.releaseAscendingToolStripMenuItem,
            this.releaseDescendingToolStripMenuItem,
            this.nameAscendingToolStripMenuItem,
            this.nameDescendingToolStripMenuItem});
            this.orderingToolStripMenuItem.Name = "orderingToolStripMenuItem";
            this.orderingToolStripMenuItem.Size = new System.Drawing.Size(95, 31);
            this.orderingToolStripMenuItem.Text = "Ordering";
            // 
            // heardFirstToolStripMenuItem
            // 
            this.heardFirstToolStripMenuItem.Name = "heardFirstToolStripMenuItem";
            this.heardFirstToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.heardFirstToolStripMenuItem.Text = "Heard first";
            this.heardFirstToolStripMenuItem.Click += new System.EventHandler(this.heardFirstToolStripMenuItem_Click);
            // 
            // heardLastToolStripMenuItem
            // 
            this.heardLastToolStripMenuItem.Name = "heardLastToolStripMenuItem";
            this.heardLastToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.heardLastToolStripMenuItem.Text = "Heard last";
            this.heardLastToolStripMenuItem.Click += new System.EventHandler(this.heardLastToolStripMenuItem_Click);
            // 
            // favoritesFirstToolStripMenuItem
            // 
            this.favoritesFirstToolStripMenuItem.Name = "favoritesFirstToolStripMenuItem";
            this.favoritesFirstToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.favoritesFirstToolStripMenuItem.Text = "Favorites first";
            this.favoritesFirstToolStripMenuItem.Click += new System.EventHandler(this.favoritesFirstToolStripMenuItem_Click);
            // 
            // favoritesLastToolStripMenuItem
            // 
            this.favoritesLastToolStripMenuItem.Name = "favoritesLastToolStripMenuItem";
            this.favoritesLastToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.favoritesLastToolStripMenuItem.Text = "Favorites last";
            this.favoritesLastToolStripMenuItem.Click += new System.EventHandler(this.favoritesLastToolStripMenuItem_Click);
            // 
            // numberAscendingToolStripMenuItem
            // 
            this.numberAscendingToolStripMenuItem.Name = "numberAscendingToolStripMenuItem";
            this.numberAscendingToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.numberAscendingToolStripMenuItem.Text = "Number ascending";
            this.numberAscendingToolStripMenuItem.Click += new System.EventHandler(this.numberAscendingToolStripMenuItem_Click);
            // 
            // numberDescendingToolStripMenuItem
            // 
            this.numberDescendingToolStripMenuItem.Name = "numberDescendingToolStripMenuItem";
            this.numberDescendingToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.numberDescendingToolStripMenuItem.Text = "Number descending";
            this.numberDescendingToolStripMenuItem.Click += new System.EventHandler(this.numberDescendingToolStripMenuItem_Click);
            // 
            // releaseAscendingToolStripMenuItem
            // 
            this.releaseAscendingToolStripMenuItem.Name = "releaseAscendingToolStripMenuItem";
            this.releaseAscendingToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.releaseAscendingToolStripMenuItem.Text = "Release ascending";
            this.releaseAscendingToolStripMenuItem.Click += new System.EventHandler(this.releaseAscendingToolStripMenuItem_Click);
            // 
            // releaseDescendingToolStripMenuItem
            // 
            this.releaseDescendingToolStripMenuItem.Name = "releaseDescendingToolStripMenuItem";
            this.releaseDescendingToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.releaseDescendingToolStripMenuItem.Text = "Release descending";
            this.releaseDescendingToolStripMenuItem.Click += new System.EventHandler(this.releaseDescendingToolStripMenuItem_Click);
            // 
            // nameAscendingToolStripMenuItem
            // 
            this.nameAscendingToolStripMenuItem.Name = "nameAscendingToolStripMenuItem";
            this.nameAscendingToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.nameAscendingToolStripMenuItem.Text = "Name ascending";
            this.nameAscendingToolStripMenuItem.Click += new System.EventHandler(this.nameAscendingToolStripMenuItem_Click);
            // 
            // nameDescendingToolStripMenuItem
            // 
            this.nameDescendingToolStripMenuItem.Name = "nameDescendingToolStripMenuItem";
            this.nameDescendingToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.nameDescendingToolStripMenuItem.Text = "Name descending";
            this.nameDescendingToolStripMenuItem.Click += new System.EventHandler(this.nameDescendingToolStripMenuItem_Click);
            // 
            // filteringToolStripMenuItem
            // 
            this.filteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allAudioDramasToolStripMenuItem,
            this.includeMainAudioDramasToolStripMenuItem,
            this.specialAudioDramasOnlyToolStripMenuItem,
            this.favoritesOnlyToolStripMenuItem,
            this.unheardOnlyToolStripMenuItem});
            this.filteringToolStripMenuItem.Name = "filteringToolStripMenuItem";
            this.filteringToolStripMenuItem.Size = new System.Drawing.Size(87, 31);
            this.filteringToolStripMenuItem.Text = "Filtering";
            // 
            // allAudioDramasToolStripMenuItem
            // 
            this.allAudioDramasToolStripMenuItem.Name = "allAudioDramasToolStripMenuItem";
            this.allAudioDramasToolStripMenuItem.Size = new System.Drawing.Size(304, 30);
            this.allAudioDramasToolStripMenuItem.Text = "All audio dramas";
            this.allAudioDramasToolStripMenuItem.Click += new System.EventHandler(this.allAudioDramasToolStripMenuItem_Click);
            // 
            // includeMainAudioDramasToolStripMenuItem
            // 
            this.includeMainAudioDramasToolStripMenuItem.Name = "includeMainAudioDramasToolStripMenuItem";
            this.includeMainAudioDramasToolStripMenuItem.Size = new System.Drawing.Size(304, 30);
            this.includeMainAudioDramasToolStripMenuItem.Text = "Main audio dramas only";
            this.includeMainAudioDramasToolStripMenuItem.Click += new System.EventHandler(this.mainAudioDramasToolStripMenuItem_Click);
            // 
            // specialAudioDramasOnlyToolStripMenuItem
            // 
            this.specialAudioDramasOnlyToolStripMenuItem.Name = "specialAudioDramasOnlyToolStripMenuItem";
            this.specialAudioDramasOnlyToolStripMenuItem.Size = new System.Drawing.Size(304, 30);
            this.specialAudioDramasOnlyToolStripMenuItem.Text = "Special audio dramas only";
            this.specialAudioDramasOnlyToolStripMenuItem.Click += new System.EventHandler(this.specialAudioDramasOnlyToolStripMenuItem_Click);
            // 
            // favoritesOnlyToolStripMenuItem
            // 
            this.favoritesOnlyToolStripMenuItem.Name = "favoritesOnlyToolStripMenuItem";
            this.favoritesOnlyToolStripMenuItem.Size = new System.Drawing.Size(304, 30);
            this.favoritesOnlyToolStripMenuItem.Text = "Favorites only";
            this.favoritesOnlyToolStripMenuItem.Click += new System.EventHandler(this.favoritesOnlyToolStripMenuItem_Click);
            // 
            // unheardOnlyToolStripMenuItem
            // 
            this.unheardOnlyToolStripMenuItem.Name = "unheardOnlyToolStripMenuItem";
            this.unheardOnlyToolStripMenuItem.Size = new System.Drawing.Size(304, 30);
            this.unheardOnlyToolStripMenuItem.Text = "Unheard only";
            this.unheardOnlyToolStripMenuItem.Click += new System.EventHandler(this.unheardOnlyToolStripMenuItem_Click);
            // 
            // toolStripSearchBox
            // 
            this.toolStripSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripSearchBox.Name = "toolStripSearchBox";
            this.toolStripSearchBox.Size = new System.Drawing.Size(100, 31);
            this.toolStripSearchBox.TextChanged += new System.EventHandler(this.toolStripSearchBox_TextChanged);
            // 
            // dataGridViewAudioDramas
            // 
            this.dataGridViewAudioDramas.AllowUserToAddRows = false;
            this.dataGridViewAudioDramas.AllowUserToDeleteRows = false;
            this.dataGridViewAudioDramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAudioDramas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAudioDramas.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewAudioDramas.MultiSelect = false;
            this.dataGridViewAudioDramas.Name = "dataGridViewAudioDramas";
            this.dataGridViewAudioDramas.ReadOnly = true;
            this.dataGridViewAudioDramas.RowTemplate.Height = 28;
            this.dataGridViewAudioDramas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAudioDramas.Size = new System.Drawing.Size(990, 525);
            this.dataGridViewAudioDramas.TabIndex = 2;
            this.dataGridViewAudioDramas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAudioDramas_CellContentClick);
            this.dataGridViewAudioDramas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAudioDramas_CellDoubleClick);
            this.dataGridViewAudioDramas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAudioDramas_CellValueChanged);
            // 
            // audioDramaUserDataBindingSource
            // 
            this.audioDramaUserDataBindingSource.DataSource = typeof(DdfGuide.Core.AudioDramaUserData);
            // 
            // AudioDramaListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAudioDramas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AudioDramaListView";
            this.Size = new System.Drawing.Size(990, 560);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudioDramas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioDramaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioDramaUserDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource audioDramaBindingSource;
        private System.Windows.Forms.BindingSource audioDramaUserDataBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heardFirstToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewAudioDramas;
        private System.Windows.Forms.ToolStripMenuItem heardLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberAscendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberDescendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseAscendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDescendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameAscendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameDescendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem includeMainAudioDramasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAudioDramasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unheardOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialAudioDramasOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripSearchBox;
    }
}


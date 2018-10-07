using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DdfGuide.Core;
using EventArgs = System.EventArgs;

namespace DdfGuide.Forms
{
    public partial class AudioDramaListView : Form, IAudioDramaListView
    {
        public AudioDramaListView()
        {
            InitializeComponent();
        }

        public event EventHandler BackClicked;
        public event EventHandler<Guid> HeardChanged;
        public event EventHandler<Guid> IsFavoriteChanged;
        public event EventHandler<Guid> AudioDramaClicked;
        public event EventHandler OrderByHeardFirstClicked;
        public event EventHandler OrderByHeardLastClicked;
        public event EventHandler OrderByIsFavoriteFirstClicked;
        public event EventHandler OrderByIsFavoriteLastClicked;
        public event EventHandler OrderByNumberAscendingClicked;
        public event EventHandler OrderByNumberDescendingClicked;
        public event EventHandler OrderByReleaseDateAscendingClicked;
        public event EventHandler OrderByReleaseDateDescendingClicked;
        public event EventHandler OrderByNameAscendingClicked;
        public event EventHandler OrderByNameDescendingClicked;

        public void SetAudioDramas(IEnumerable<AudioDrama> audioDramas)
        {
            var rows = audioDramas.Select(audioDrama => new AudioDramaRow(audioDrama)).ToList();
            
            dataGridViewAudioDramas.DataSource = rows;

            dataGridViewAudioDramas.ReadOnly = false;
            foreach (DataGridViewColumn column in dataGridViewAudioDramas.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                column.ReadOnly = !(column is DataGridViewCheckBoxColumn);
            }
        }

        private void dataGridViewAudioDramas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAudioDramas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewAudioDramas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            var heardColumn = dataGridViewAudioDramas.Columns["Heard"];
            var isFavoriteColumn = dataGridViewAudioDramas.Columns["IsFavorite"];
            var id = (Guid) dataGridViewAudioDramas.Rows[e.RowIndex].Cells[0].Value;

            if (e.ColumnIndex == heardColumn?.Index)
            {
                HeardChanged?.Invoke(this, id);
            }

            if (e.ColumnIndex == isFavoriteColumn?.Index)
            {
                IsFavoriteChanged?.Invoke(this, id);
            }
        }

        private void dataGridViewAudioDramas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            var id = (Guid)dataGridViewAudioDramas.Rows[e.RowIndex].Cells[0].Value;
            AudioDramaClicked?.Invoke(this, id);
        }

        private void heardFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByHeardFirstClicked?.Invoke(this, EventArgs.Empty);
        }

        private void heardLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByHeardLastClicked?.Invoke(this, EventArgs.Empty);
        }

        private void favoritesFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByIsFavoriteFirstClicked?.Invoke(this, EventArgs.Empty);
        }

        private void favoritesLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByIsFavoriteLastClicked?.Invoke(this, EventArgs.Empty);
        }

        private void numberAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByNumberAscendingClicked?.Invoke(this, EventArgs.Empty);
        }

        private void numberDescendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByNumberDescendingClicked?.Invoke(this, EventArgs.Empty);
        }

        private void releaseAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByReleaseDateAscendingClicked?.Invoke(this, EventArgs.Empty);
        }

        private void releaseDescendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByReleaseDateDescendingClicked?.Invoke(this, EventArgs.Empty);
        }

        private void nameAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByNameAscendingClicked?.Invoke(this, EventArgs.Empty);
        }

        private void nameDescendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByNameDescendingClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

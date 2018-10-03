using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DdfGuide.Core;

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
            var heardColumn = dataGridViewAudioDramas.Columns["Heard"];
            var isFavoriteColumn = dataGridViewAudioDramas.Columns["IsFavorite"];
            var id = (Guid) dataGridViewAudioDramas.Rows[e.RowIndex].Cells[0].Value;

            if (e.ColumnIndex == heardColumn?.Index && e.RowIndex != -1)
            {
                HeardChanged?.Invoke(this, id);
            }

            if (e.ColumnIndex == isFavoriteColumn?.Index && e.RowIndex != -1)
            {
                IsFavoriteChanged?.Invoke(this, id);
            }
        }

        private void dataGridViewAudioDramas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = (Guid)dataGridViewAudioDramas.Rows[e.RowIndex].Cells[0].Value;
            AudioDramaClicked?.Invoke(this, id);
        }
    }
}

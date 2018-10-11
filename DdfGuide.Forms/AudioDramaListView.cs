using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;
using EventArgs = System.EventArgs;

namespace DdfGuide.Forms
{
    public partial class AudioDramaListView : UserControl, IAudioDramaListView
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
        public event EventHandler AllClicked;
        public event EventHandler MainsOnlyClicked;
        public event EventHandler SpecialsOnlyClicked;
        public event EventHandler FavoritesOnlyClicked;
        public event EventHandler UnheardOnlyClicked;
        public event EventHandler SearchTextChanged;
        public event EventHandler RandomClicked;

        public string GetCurrentSearchText()
        {
            return toolStripSearchBox.Text;
        }
        

        public void SetAudioDramaInfos(IEnumerable<AudioDrama> audioDramas)
        {
            var rows = audioDramas.Select(audioDrama => new AudioDramaRowAdapter(audioDrama)).ToList();
            
            dataGridViewAudioDramas.DataSource = rows;

            dataGridViewAudioDramas.ReadOnly = false;
            foreach (DataGridViewColumn column in dataGridViewAudioDramas.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                column.ReadOnly = !(column is DataGridViewCheckBoxColumn);
            }
        }

        public void SetFilterInfos(EAudioDramaFilterMode selectedFilterMode)
        {
            foreach (var dropDownItem in filteringToolStripMenuItem.DropDownItems)
            {
                var menuItem = dropDownItem as ToolStripMenuItem;

                if (menuItem == null)
                {
                    throw new Exception("Error casting to ToolStripMenuItem while setting the sort mode.");
                }

                menuItem.Checked = false;
            }

            switch (selectedFilterMode)
            {
                case EAudioDramaFilterMode.MainsOnly:
                    includeMainAudioDramasToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaFilterMode.All:
                    allAudioDramasToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaFilterMode.FavoritesOnly:
                    favoritesOnlyToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaFilterMode.UnheardOnly:
                    unheardOnlyToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaFilterMode.SpecialsOnly:
                    specialAudioDramasOnlyToolStripMenuItem.Checked = true;
                    break;
                default:

                    throw new ArgumentOutOfRangeException(nameof(selectedFilterMode), selectedFilterMode, null);
            }
        }

        public void SetSelectedSortMode(EAudioDramaSortMode selectedSortMode)
        {
            foreach (var dropDownItem in orderingToolStripMenuItem.DropDownItems)
            {
                var menuItem = dropDownItem as ToolStripMenuItem;

                if (menuItem == null)
                {
                    throw new Exception("Error casting to ToolStripMenuItem while setting the sort mode.");
                }

                menuItem.Checked = false;
            }

            switch (selectedSortMode)
            {
                case EAudioDramaSortMode.ReleaseDateDescending:
                    releaseDescendingToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaSortMode.ReleaseDateAscending:
                    releaseAscendingToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaSortMode.NumberDescending:
                    numberDescendingToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaSortMode.NumberAscending:
                    numberAscendingToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaSortMode.NameDescending:
                    nameDescendingToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaSortMode.NameAscending:
                    nameAscendingToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaSortMode.HeardFirst:
                    heardFirstToolStripMenuItem.Checked = true;
                    break;
                
                case EAudioDramaSortMode.HeardLast:
                    heardLastToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaSortMode.IsFavoriteFirst:
                    favoritesFirstToolStripMenuItem.Checked = true;
                    break;

                case EAudioDramaSortMode.IsFavoriteLast:
                    favoritesLastToolStripMenuItem.Checked = true;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(selectedSortMode), selectedSortMode, null);
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

        private void mainAudioDramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainsOnlyClicked?.Invoke(this, EventArgs.Empty);
        }

        private void allAudioDramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllClicked?.Invoke(this, EventArgs.Empty);
        }

        private void favoritesOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FavoritesOnlyClicked?.Invoke(this, EventArgs.Empty);
        }

        private void unheardOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnheardOnlyClicked?.Invoke(this, EventArgs.Empty);
        }

        private void specialAudioDramasOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialsOnlyClicked?.Invoke(this, EventArgs.Empty);
        }

        private void toolStripSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, EventArgs.Empty);
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

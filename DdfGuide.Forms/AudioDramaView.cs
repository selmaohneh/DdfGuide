using System;
using System.Windows.Forms;
using DdfGuide.Core;

namespace DdfGuide.Forms
{
    public partial class AudioDramaView : Form, IAudioDramaView
    {
        public AudioDramaView()
        {
            InitializeComponent();
        }

        public event EventHandler BackClicked;
        public event EventHandler HeardChanged;
        public event EventHandler IsFavoriteChanged;

        public void SetAudioDrama(AudioDrama audioDrama)
        {
            labelId.Text = audioDrama.AudioDramaDto.Id.ToString();
            labelName.Text = audioDrama.AudioDramaDto.Name;

            if (checkBoxHeard.Checked != audioDrama.AudioDramaUserData.Heard)
            {
                checkBoxHeard.Checked = audioDrama.AudioDramaUserData.Heard;
            }

            if (checkBoxIsFavorite.Checked != audioDrama.AudioDramaUserData.IsFavorite)
            {
                checkBoxIsFavorite.Checked = audioDrama.AudioDramaUserData.IsFavorite;
            }
        }

        private void AudioDramaView_DoubleClick(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

        private void checkBoxHeard_Click(object sender, EventArgs e)
        {
            HeardChanged?.Invoke(this, EventArgs.Empty);
        }

        private void checkBoxIsFavorite_Click(object sender, EventArgs e)
        {
            IsFavoriteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

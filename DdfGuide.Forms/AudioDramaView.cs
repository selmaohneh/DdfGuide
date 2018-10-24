using System;
using System.Windows.Forms;
using DdfGuide.Core;
using static System.String;

namespace DdfGuide.Forms
{
    public partial class AudioDramaView : UserControl, IAudioDramaView
    {
        public AudioDramaView()
        {
            InitializeComponent();
        }

        public event EventHandler BackClicked;
        public event EventHandler HeardClicked;
        public event EventHandler IsFavoriteClicked;

        public void SetAudioDrama(AudioDrama audioDrama)
        {
            labelId.Text = audioDrama.AudioDramaDto.Id.ToString();
            labelName.Text = audioDrama.AudioDramaDto.Title;
            richTextBoxDescription.Text = audioDrama.AudioDramaDto.Description;
            pictureBoxCover.Load(audioDrama.AudioDramaDto.CoverUrl);

            if (checkBoxHeard.Checked != audioDrama.AudioDramaUserData.Heard)
            {
                checkBoxHeard.Checked = audioDrama.AudioDramaUserData.Heard;
            }

            if (checkBoxIsFavorite.Checked != audioDrama.AudioDramaUserData.IsFavorite)
            {
                checkBoxIsFavorite.Checked = audioDrama.AudioDramaUserData.IsFavorite;
            }

            richTextBoxDescription.Text = audioDrama.AudioDramaDto.Description;

            richTextBoxRoles.Text = Empty;
            foreach (var role in audioDrama.AudioDramaDto.Roles)
            {
                richTextBoxRoles.Text += $"{role.Character}: {role.Speaker}\n";
            }
        }

        private void checkBoxHeard_Click(object sender, EventArgs e)
        {
            HeardClicked?.Invoke(this, EventArgs.Empty);
        }

        private void checkBoxIsFavorite_Click(object sender, EventArgs e)
        {
            IsFavoriteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

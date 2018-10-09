using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
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

            var image = Task.Run(() =>
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(
                        "https://www.rocky-beach.com/hoerspiel/cover/159.jpg",
                        $"{audioDrama.AudioDramaDto.Name}.png");
                }

                pictureBox1.Image = Image.FromFile($"{audioDrama.AudioDramaDto.Name}.png");
            });
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

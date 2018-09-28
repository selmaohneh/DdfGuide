using System;
using System.Windows.Forms;
using DdfGuide.Core.Models;
using DdfGuide.Core.Views;

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
            
        }

    }
}

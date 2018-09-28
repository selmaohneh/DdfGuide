using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DdfGuide.Core.Models;
using DdfGuide.Core.Views;

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
            
        }
    }
}

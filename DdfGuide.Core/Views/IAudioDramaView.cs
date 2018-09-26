using System;
using DdfGuide.Core.Models;

namespace DdfGuide.Core.Views
{
    public interface IAudioDramaView : IView
    {
        void SetAudioDrama(AudioDrama audioDrama);
        event EventHandler HeardChanged;
        event EventHandler IsFavoriteChanged;
    }
}

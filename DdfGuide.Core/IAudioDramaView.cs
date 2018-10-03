using System;

namespace DdfGuide.Core
{
    public interface IAudioDramaView : IView
    {
        void SetAudioDrama(AudioDrama audioDrama);
        event EventHandler HeardChanged;
        event EventHandler IsFavoriteChanged;
    }
}

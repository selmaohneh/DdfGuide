using System;

namespace DdfGuide.Core
{
    public interface IAudioDramaView : IView
    {
        void SetAudioDrama(AudioDrama audioDrama);

        event EventHandler HeardClicked;
        event EventHandler IsFavoriteClicked;
        event EventHandler BackClicked;
    }
}

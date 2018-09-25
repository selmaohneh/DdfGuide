using System;
using System.Collections.Generic;

namespace DdfGuide.Core
{
    public interface IAudioDramaListView
    {
        void Show();
        void SetAudioDramas(IEnumerable<AudioDrama> audioDramas);
        event EventHandler<Guid> HeardChanged;
        event EventHandler<Guid> IsFavoriteChanged;
    }
}

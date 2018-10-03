using System;
using System.Collections.Generic;

namespace DdfGuide.Core
{
    public interface IAudioDramaListView : IView
    {
        void SetAudioDramas(IEnumerable<AudioDrama> audioDramas);
        event EventHandler<Guid> HeardChanged;
        event EventHandler<Guid> IsFavoriteChanged;
        event EventHandler<Guid> AudioDramaClicked;
    }
}

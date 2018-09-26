using System;
using System.Collections.Generic;
using DdfGuide.Core.Models;

namespace DdfGuide.Core.Views
{
    public interface IAudioDramaListView : IView
    {
        void SetAudioDramas(IEnumerable<AudioDrama> audioDramas);
        event EventHandler<Guid> HeardChanged;
        event EventHandler<Guid> IsFavoriteChanged;
        event EventHandler<Guid> AudioDramaClicked;
    }
}

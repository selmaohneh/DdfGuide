using System.Collections.Generic;

namespace DdfGuide.Core
{
    public interface IAudioDramaListPresenter
    {
        void SetAudioDramas(IEnumerable<AudioDrama> audioDramas);
    }
}
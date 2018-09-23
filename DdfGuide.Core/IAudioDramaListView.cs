using System.Collections.Generic;

namespace DdfGuide.Core
{
    public interface IAudioDramaListView
    {
        void Show();
        void SetAudioDramas(IEnumerable<AudioDrama> audioDramas);
        void SetAudioDramaUserData(IEnumerable<AudioDramaUserData> audioDramaUserData);
    }
}

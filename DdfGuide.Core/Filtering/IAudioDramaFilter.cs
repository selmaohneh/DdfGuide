using System.Collections.Generic;

namespace DdfGuide.Core.Filtering
{
    public interface IAudioDramaFilter
    {
        EAudioDramaFilterMode FilterMode { get; }
        IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas);
    }
}
using System.Collections.Generic;

namespace DdfGuide.Core
{
    public interface IAudioDramaFilter
    {
        bool IncludeMainAudioDramas { get; set; }
        IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas);
    }
}
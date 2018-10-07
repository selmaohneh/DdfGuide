using System.Collections.Generic;

namespace DdfGuide.Core
{
    public interface IAudioDramaSorter
    {
        EAudioDramaSortMode SortMode { get; set; }
        IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas);
    }
}
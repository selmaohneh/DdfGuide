using System.Collections.Generic;

namespace DdfGuide.Core.Sorting
{
    public interface IAudioDramaSorter
    {
        EAudioDramaSortMode SortMode { get; }
        IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas);
    }
}
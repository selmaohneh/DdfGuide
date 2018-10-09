using System.Collections.Generic;

namespace DdfGuide.Core.Searching
{
    public interface IAudioDramaSearcher
    {
        IEnumerable<AudioDrama> Search(IEnumerable<AudioDrama> audioDramas, string searchText);
    }
}
using System.Collections.Generic;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public interface IAudioDramaExplorer
    {
        void SetSortMode(EAudioDramaSortMode sortMode);
        void SetFilterMode(EAudioDramaFilterMode filterMode);
        void SetSearchText(string searchText);
        IEnumerable<AudioDrama> GetMatchingAudioDramas(IEnumerable<AudioDrama> audioDramas);
    }
}
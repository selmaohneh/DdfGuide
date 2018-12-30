using System.Collections.Generic;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public interface IAudioDramaExplorer
    {
        void SetSortMode(EAudioDramaSortMode sortMode);
        EAudioDramaSortMode GetCurrentSortMode();
        void SetFilterMode(EAudioDramaFilterMode filterMode);
        EAudioDramaFilterMode GetCurrentFilterMode();
        void SetSearchText(string searchText);
        IEnumerable<AudioDrama> GetMatchingAudioDramas();
        void SetInterpreterFilter(EAudioDramaFilterMode filterMode);
        EAudioDramaFilterMode GetCurrentInterpreterFilter();
    }
}
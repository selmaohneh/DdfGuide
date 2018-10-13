using System.Collections.Generic;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Searching;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public class AudioDramaExplorer : IAudioDramaExplorer
    {
        private readonly IAudioDramaSearcher _searcher;
        private readonly IAudioDramaFilterFactory _filterFactory;
        private readonly IAudioDramaSorterFactory _sorterFactory;

        private IAudioDramaFilter _filter;
        private IAudioDramaSorter _sorter;
        private string _searchText;

        public AudioDramaExplorer(
            IAudioDramaSearcher searcher,
            IAudioDramaFilterFactory filterFactory,
            IAudioDramaSorterFactory sorterFactory)
        {
            _filterFactory = filterFactory;
            _sorterFactory = sorterFactory;
            
            _searcher = searcher;
            _filter = _filterFactory.Create(EAudioDramaFilterMode.All);
            _sorter = _sorterFactory.Create(EAudioDramaSortMode.ReleaseDateDescending);
        }

        public void SetSortMode(EAudioDramaSortMode sortMode)
        {
            _sorter = _sorterFactory.Create(sortMode);
        }

        public EAudioDramaSortMode GetCurrentSortMode()
        {
            return _sorter.SortMode;
        }

        public void SetFilterMode(EAudioDramaFilterMode filterMode)
        {
            _filter = _filterFactory.Create(filterMode);
        }

        public EAudioDramaFilterMode GetCurrentFilterMode()
        {
            return _filter.FilterMode;
        }

        public void SetSearchText(string searchText)
        {
            _searchText = searchText;
        }

        public IEnumerable<AudioDrama> GetMatchingAudioDramas(IEnumerable<AudioDrama> audioDramas)
        {
            var filtered = _filter.Filter(audioDramas);
            var filteredAndSearched = _searcher.Search(filtered, _searchText);
            var filteredAndSearchedAndSorted = _sorter.Sort(filteredAndSearched);

            return filteredAndSearchedAndSorted;
        }
    }
}

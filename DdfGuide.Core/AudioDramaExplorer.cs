using System.Collections.Generic;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Searching;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public class AudioDramaExplorer : IAudioDramaExplorer
    {
        private readonly IAudioDramaSearcher _searcher;
        private readonly ISource<IEnumerable<AudioDrama>> _source;
        private readonly IAudioDramaFilterFactory _filterFactory;
        private readonly IAudioDramaSorterFactory _sorterFactory;

        private IAudioDramaFilter _interpreterFilter;
        private IAudioDramaFilter _filter;
        private IAudioDramaSorter _sorter;
        private string _searchText;

        public AudioDramaExplorer(
            ISource<IEnumerable<AudioDrama>> source,
            IAudioDramaSearcher searcher,
            IAudioDramaFilterFactory filterFactory,
            IAudioDramaSorterFactory sorterFactory)
        {
            _source = source;

            _filterFactory = filterFactory;
            _sorterFactory = sorterFactory;
            
            _searcher = searcher;
            _interpreterFilter = _filterFactory.Create(EAudioDramaFilterMode.DieDreiFragezeichen);
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

        public IEnumerable<AudioDrama> GetMatchingAudioDramas()
        {
            var audioDramas = _source.Get();
            var interpreterSelected = _interpreterFilter.Filter(audioDramas);
            var filtered = _filter.Filter(interpreterSelected);
            var filteredAndSearched = _searcher.Search(filtered, _searchText);
            var filteredAndSearchedAndSorted = _sorter.Sort(filteredAndSearched);

            return filteredAndSearchedAndSorted;
        }

        public void SetInterpreterFilter(EAudioDramaFilterMode filterMode)
        {
            _interpreterFilter = _filterFactory.Create(filterMode);
        }

        public EAudioDramaFilterMode GetCurrentInterpreterFilter()
        {
            return _interpreterFilter.FilterMode;
        }
    }
}

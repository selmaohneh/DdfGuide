using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Searching;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public class DdfGuide
    {
        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;
        private readonly IRootView _rootView;
        private readonly ICache<IEnumerable<AudioDramaDto>> _dtoCache;
        private readonly ICache<IEnumerable<AudioDramaUserData>> _userDataCache;

        public DdfGuide(
            IAudioDramaListView audioDramaListView,
            IAudioDramaView audioDramaView,
            IRootView rootView,
            ICache<IEnumerable<AudioDramaDto>> dtoCache,
            ICache<IEnumerable<AudioDramaUserData>> userDataCache)
        {
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _rootView = rootView;
            _dtoCache = dtoCache;
            _userDataCache = userDataCache;
        }

        public async Task Start()
        {
            var builder = new AudioDramaBuilder();

            var source = new AudioDramaSource(
                _dtoCache,
                _userDataCache,
                builder);

            var saver = new OnUserDataChangedInCacheSaver(_userDataCache, source);
            

            var audioDramaPresenter = new AudioDramaPresenter(_audioDramaView);

            var filterFactory = new AudioDramaFilterFactory();
            var sorterFactory = new AudioDramaSorterFactory();
            var searcher = new AudioDramaSearcher();

            var explorer = new AudioDramaExplorer(searcher, filterFactory, sorterFactory);
            var picker = new RandomAudioDramaPicker();

            var audioDramaListPresenter = new AudioDramaListPresenter(
                _audioDramaListView,
                explorer
                );

            var navigator = new Navigator(
                _rootView,
                audioDramaPresenter,
                audioDramaListPresenter,
                explorer,
                picker,
                source);

            await source.Update();

            navigator.ShowStartView();
        }
    }
}

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Searching;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public class DdfGuide
    {
        private readonly IProvider<IEnumerable<AudioDramaDto>> _dtoProvider;

        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;
        private readonly IRootView _rootView;
        private readonly ICache<IEnumerable<AudioDramaDto>> _dtoCache;
        private readonly ICache<IEnumerable<AudioDramaUserData>> _userDataCache;

        public DdfGuide(
            IProvider<IEnumerable<AudioDramaDto>> dtoProvider,
            IAudioDramaListView audioDramaListView,
            IAudioDramaView audioDramaView,
            IRootView rootView,
            ICache<IEnumerable<AudioDramaDto>> dtoCache,
            ICache<IEnumerable<AudioDramaUserData>> userDataCache)
        {
            _dtoProvider = dtoProvider;
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _rootView = rootView;
            _dtoCache = dtoCache;
            _userDataCache = userDataCache;
        }

        public void Start()
        {
            CultureInfo.CurrentCulture = new CultureInfo("de-DE");

            var cachedProvider = new CachedDtoProvider(
                _dtoCache,
                _dtoProvider);

            var dtos = cachedProvider.Get();
            var userData = _userDataCache.Load();

            var audioDramaBuilder = new AudioDramaBuilder();

            var audioDramas = audioDramaBuilder.Build(
                dtos,
                userData).ToList();

            var saver = new OnUserDataChangedInCacheSaver(_userDataCache);
            saver.SetObservedUserDatas(audioDramas.Select(x => x.AudioDramaUserData));

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
                picker);

            navigator.SetAudioDramas(audioDramas);

            navigator.ShowStartView();
        }
    }
}

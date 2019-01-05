using System;
using System.Collections.Generic;
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
        private readonly IShutdown _shutdown;
        private readonly IUserNotifier _userNotifier;

        public DdfGuide(
            IAudioDramaListView audioDramaListView,
            IAudioDramaView audioDramaView,
            IRootView rootView,
            ICache<IEnumerable<AudioDramaDto>> dtoCache,
            ICache<IEnumerable<AudioDramaUserData>> userDataCache,
            IShutdown shutdown,
            IUserNotifier userNotifier)
        {
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _rootView = rootView;
            _dtoCache = dtoCache;
            _userDataCache = userDataCache;
            _shutdown = shutdown;
            _userNotifier = userNotifier;
        }

        public async Task Start()
        {
            var builder = new AudioDramaBuilder();

            var saver = new OnUserDataChangedInCacheSaver(_userDataCache);

            var source = new AudioDramaSource(
                _dtoCache,
                _userDataCache,
                builder,
                saver,
                _userNotifier);

            var audioDramaPresenter = new AudioDramaPresenter(_audioDramaView);

            var filterFactory = new AudioDramaFilterFactory();
            var sorterFactory = new AudioDramaSorterFactory();
            var searcher = new AudioDramaSearcher();

            var explorer = new AudioDramaExplorer(source, searcher, filterFactory, sorterFactory);
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
                source,
                _shutdown);


            try
            {
                await source.Update();
            }
            catch (Exception)
            {
                // needed due to using async void. Otherwise
                // all exception will bubble up until here and crash the app.
                _userNotifier.Notify("Aktualisierung fehlgeschlagen. Keine Intertverbindung.");
            }

            navigator.ShowStartView();
        }
    }
}

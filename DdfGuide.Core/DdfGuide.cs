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
        private readonly IProvider<IEnumerable<AudioDramaUserData>> _userDataProvider;

        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;
        private readonly IRootView _rootView;

        public DdfGuide(
            IProvider<IEnumerable<AudioDramaDto>> dtoProvider,
            IProvider<IEnumerable<AudioDramaUserData>> userDataProvider,
            IAudioDramaListView audioDramaListView,
            IAudioDramaView audioDramaView,
            IRootView rootView)
        {
            _dtoProvider = dtoProvider;
            _userDataProvider = userDataProvider;
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _rootView = rootView;
        }

        public void Start()
        {
            CultureInfo.CurrentCulture = new CultureInfo("de-DE");

            var dtos = _dtoProvider.Get();
            var userData = _userDataProvider.Get();

            var audioDramaBuilder = new AudioDramaBuilder(
                dtos,
                userData);

            var audioDramas = audioDramaBuilder.Build().ToList();
            
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
                audioDramas,
                explorer,
                picker);
            
            navigator.ShowStartView();
        }
    }
}

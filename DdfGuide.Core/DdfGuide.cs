using System.Collections.Generic;
using System.Globalization;
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
        private readonly IInterpreterSelectionView _interpreterSelectionView;

        public DdfGuide(
            IProvider<IEnumerable<AudioDramaDto>> dtoProvider,
            IProvider<IEnumerable<AudioDramaUserData>> userDataProvider,
            IAudioDramaListView audioDramaListView,
            IAudioDramaView audioDramaView,
            IRootView rootView,
            IInterpreterSelectionView interpreterSelectionView)
        {
            _dtoProvider = dtoProvider;
            _userDataProvider = userDataProvider;
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _rootView = rootView;
            _interpreterSelectionView = interpreterSelectionView;
        }

        public void Start()
        {
            CultureInfo.CurrentCulture = new CultureInfo("de-DE");

            var dtos = _dtoProvider.Get();
            var userData = _userDataProvider.Get();

            var audioDramaBuilder = new AudioDramaBuilder(
                dtos,
                userData);

            var audioDramas = audioDramaBuilder.Build();

            var viewStack = new Stack<IView>();
            var viewer = new Viewer(_rootView, viewStack);
            var rootPresenter = new RootPresenter(_rootView, viewer);


            var audioDramaPresenter = new AudioDramaPresenter(_audioDramaView, viewer);

            var filterFactory = new AudioDramaFilterFactory();
            var sorterFactory = new AudioDramaSorterFactory();
            var searcher = new AudioDramaSearcher();

            var explorer = new AudioDramaExplorer(searcher, filterFactory, sorterFactory);
            var picker = new RandomAudioDramaPicker();

            var audioDramaListPresenter = new AudioDramaListPresenter(
                _audioDramaListView,
                _audioDramaView,
                viewer,
                audioDramaPresenter,
                explorer,
                picker
                );

            var interpreterSelectionPresenter = new InterpreterSelectionPresenter(
                _interpreterSelectionView,
                viewer,
                _audioDramaListView,
                audioDramaListPresenter,
                audioDramas,
                filterFactory);

            viewer.Show(_interpreterSelectionView);
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class Navigator
    {
        private IView _currentView;
        private readonly IRootView _rootView;
        private readonly IPresenter<IAudioDramaView, AudioDrama> _audioDramaPresenter;
        private readonly IPresenter<IAudioDramaListView, IEnumerable<AudioDrama>> _audioDramaListPresenter;
        private readonly IAudioDramaExplorer _explorer;
        private readonly IRandomAudioDramaPicker _picker;
        private readonly ISource<IEnumerable<AudioDrama>> _source;
        private readonly IShutdown _shutdown;
        private readonly IUpdatingView _updatingView;

        public Navigator(
            IRootView rootView,
            IPresenter<IAudioDramaView, AudioDrama> audioDramaPresenter, 
            IPresenter<IAudioDramaListView, IEnumerable<AudioDrama>> audioDramaListPresenter,
            IAudioDramaExplorer explorer,
            IRandomAudioDramaPicker picker,
            ISource<IEnumerable<AudioDrama>> source,
            IShutdown shutdown,
            IUpdatingView updatingView)
        {
            _rootView = rootView;
            _audioDramaPresenter = audioDramaPresenter;
            _audioDramaListPresenter = audioDramaListPresenter;
            _explorer = explorer;
            _picker = picker;
            _source = source;
            _shutdown = shutdown;
            _updatingView = updatingView;

            InitNavigationEvents();
        }

        public void ShowStartView()
        {
            Show(_audioDramaListPresenter.GetView());
            _audioDramaListPresenter.SetModel(_source.Get());
        }

        public void ShowUpdateView()
        {
            Show(_updatingView);
        }

        private void InitNavigationEvents()
        {
            InitRootViewNavigationEvents();
            InitAudioDramaListViewNavigationEvents();
            InitAudioDramaViewNavigationEvents();
        }

        private void InitRootViewNavigationEvents()
        {
            _rootView.ViewDestroyed += (sender, args) => ShowCurrent();
            _rootView.BackClicked += (sender, args) =>
            {
                if (_currentView is IAudioDramaView)
                {
                    GoToListView();
                }
                else
                {
                    _shutdown.Shutdown();
                }
            };
        }

        private void GoToListView()
        {
            Show(_audioDramaListPresenter.GetView());
            (_audioDramaListPresenter as AudioDramaListPresenter)?.UpdateView();
        }

        private void InitAudioDramaViewNavigationEvents()
        {
            _audioDramaPresenter.GetView().BackClicked += (sender, args) =>
            {
                GoToListView();
            };
        }

        private void InitAudioDramaListViewNavigationEvents()
        {
            _audioDramaListPresenter.GetView().AudioDramaClicked += (sender, guid) =>
            {
                var audioDrama = _source.Get().GetById(guid);
                Show(_audioDramaPresenter.GetView());
                _audioDramaPresenter.SetModel(audioDrama);
            };

            _audioDramaListPresenter.GetView().RandomClicked += (sender, args) =>
            {
                var matchingAudioDramas = _explorer.GetMatchingAudioDramas().ToList();

                if (!matchingAudioDramas.Any()) return;

                var randomAudioDrama = _picker.Pick(matchingAudioDramas);

                Show(_audioDramaPresenter.GetView());
                _audioDramaPresenter.SetModel(randomAudioDrama);
            };
        }

        private void Show(IView view)
        {
            _currentView = view;
            _rootView.Show(_currentView);
        }

        private void ShowCurrent()
        {
            _rootView.Show(_currentView);
        }
    }
}

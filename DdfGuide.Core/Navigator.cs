using System.Collections.Generic;

namespace DdfGuide.Core
{
    public class Navigator
    {
        private IView _currentView;
        private readonly IRootView _rootView;
        private readonly IPresenter<IAudioDramaView, AudioDrama> _audioDramaPresenter;
        private readonly IPresenter<IAudioDramaListView, IEnumerable<AudioDrama>> _audioDramaListPresenter;
        private readonly IEnumerable<AudioDrama> _audioDramas;
        private readonly IAudioDramaExplorer _explorer;
        private readonly IRandomAudioDramaPicker _picker;

        public Navigator(
            IRootView rootView,
            IPresenter<IAudioDramaView, AudioDrama> audioDramaPresenter, 
            IPresenter<IAudioDramaListView, IEnumerable<AudioDrama>> audioDramaListPresenter,
            IEnumerable<AudioDrama> audioDramas,
            IAudioDramaExplorer explorer,
            IRandomAudioDramaPicker picker)
        {
            _rootView = rootView;
            _audioDramaPresenter = audioDramaPresenter;
            _audioDramaListPresenter = audioDramaListPresenter;
            _audioDramas = audioDramas;
            _explorer = explorer;
            _picker = picker;

            InitNavigationEvents();
        }

        public void ShowStartView()
        {
            Show(_audioDramaListPresenter.GetView());
            _audioDramaListPresenter.SetModel(_audioDramas);
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
        }

        private void InitAudioDramaViewNavigationEvents()
        {
            _audioDramaPresenter.GetView().BackClicked += (sender, args) =>
            {
                Show(_audioDramaListPresenter.GetView());
                ((AudioDramaListPresenter)_audioDramaListPresenter).UpdateView();
            };
        }

        private void InitAudioDramaListViewNavigationEvents()
        {
            _audioDramaListPresenter.GetView().AudioDramaClicked += (sender, guid) =>
            {
                var audioDrama = _audioDramas.GetById(guid);
                Show(_audioDramaPresenter.GetView());
                _audioDramaPresenter.SetModel(audioDrama);
            };

            _audioDramaListPresenter.GetView().RandomClicked += (sender, args) =>
            {
                var matchingAudioDramas = _explorer.GetMatchingAudioDramas(_audioDramas);
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

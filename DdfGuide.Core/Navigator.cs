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

        public Navigator(
            IRootView rootView,
            IPresenter<IAudioDramaView, AudioDrama> audioDramaPresenter, 
            IPresenter<IAudioDramaListView, IEnumerable<AudioDrama>> audioDramaListPresenter,
            IAudioDramaExplorer explorer,
            IRandomAudioDramaPicker picker,
            ISource<IEnumerable<AudioDrama>> source)
        {
            _rootView = rootView;
            _audioDramaPresenter = audioDramaPresenter;
            _audioDramaListPresenter = audioDramaListPresenter;
            _explorer = explorer;
            _picker = picker;
            _source = source;

            _source.Updated += (sender, dramas) => InitNavigationEvents();
            InitNavigationEvents();
        }

        public void ShowStartView()
        {
            Show(_audioDramaListPresenter.GetView());
            _audioDramaListPresenter.SetModel(_source.Get());
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
                var matchingAudioDramas = _explorer.GetMatchingAudioDramas(_source.Get()).ToList();

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

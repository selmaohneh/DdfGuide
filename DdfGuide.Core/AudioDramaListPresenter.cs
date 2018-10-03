using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class AudioDramaListPresenter
    {
        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;
        private readonly IEnumerable<AudioDrama> _audioDramas;
        private readonly IViewer _viewer;
        private readonly IAudioDramaPresenter _audioDramaPresenter;

        public AudioDramaListPresenter(
            IAudioDramaListView audioDramaListView, 
            IAudioDramaView audioDramaView,
            IEnumerable<AudioDrama> audioDramas,
            IViewer viewer, 
            IAudioDramaPresenter audioDramaPresenter)
        {
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _audioDramas = audioDramas;
            _viewer = viewer;
            _audioDramaPresenter = audioDramaPresenter;

            SubscribeToViewEvents();
            SubscribetToModelEvents();
            UpdateViewWithCurrentAudioDramas();
        }

        private void SubscribetToModelEvents()
        {
            OnUserDataChangedUpdateView();
        }

        private void SubscribeToViewEvents()
        {
            OnHeardChangedUpdateModel();
            OnIsFavoriteChangedUpdateModel();
            OnAudioDramaClickedOpenAudioDramaView();
        }

        private void OnAudioDramaClickedOpenAudioDramaView()
        {
            _audioDramaListView.AudioDramaClicked += (sender, id) =>
            {
                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                _audioDramaPresenter.SetAudioDrama(audioDrama);

                _viewer.Show(_audioDramaView);
            };
        }

        private void OnIsFavoriteChangedUpdateModel()
        {
            _audioDramaListView.IsFavoriteChanged += (sender, id) =>
            {
                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                audioDrama.AudioDramaUserData.IsFavorite = !audioDrama.AudioDramaUserData.IsFavorite;
            };
        }

        private void OnHeardChangedUpdateModel()
        {
            _audioDramaListView.HeardChanged += (sender, id) =>
            {
                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                audioDrama.AudioDramaUserData.Heard = !audioDrama.AudioDramaUserData.Heard;
            };
        }

        private void OnUserDataChangedUpdateView()
        {
            foreach (var audioDrama in _audioDramas)
            {
                audioDrama.AudioDramaUserData.Changed += (sender, args) => { UpdateViewWithCurrentAudioDramas(); };
            }
        }

        private void UpdateViewWithCurrentAudioDramas()
        {
            _audioDramaListView.SetAudioDramas(_audioDramas);
        }
    }
}

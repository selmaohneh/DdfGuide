using System;

namespace DdfGuide.Core
{
    public class AudioDramaPresenter : IAudioDramaPresenter
    {
        private readonly IAudioDramaView _audioDramaView;
        private AudioDrama _audioDrama;
        private readonly IViewer _viewer;

        private readonly EventHandler _onUserDataChanged;

        public AudioDramaPresenter(
            IAudioDramaView audioDramaView,
            IViewer viewer)
        {
            _audioDramaView = audioDramaView;
            _viewer = viewer;

            _onUserDataChanged = (sender, args) => { UpdateViewWithCurrentAudioDrama(); };

            SubscribeToViewEvents();
        }

        public void SetAudioDrama(AudioDrama audioDrama)
        {
            _audioDrama = audioDrama;

            _audioDrama.AudioDramaUserData.Changed -= _onUserDataChanged;
            _audioDrama.AudioDramaUserData.Changed += _onUserDataChanged;

            UpdateViewWithCurrentAudioDrama();
        }

        private void SubscribeToViewEvents()
        {
            OnHeardChangedUpdateModel();
            OnIsFavoriteChangedUpdateModel();
            OnBackClickedShowLastView();
        }

        private void OnBackClickedShowLastView()
        {
            _audioDramaView.BackClicked += (sender, _) => { _viewer.ShowLast(); };
        }

        private void OnIsFavoriteChangedUpdateModel()
        {
            _audioDramaView.IsFavoriteChanged += (sender, _) =>
            {
                _audioDrama.AudioDramaUserData.IsFavorite = !_audioDrama.AudioDramaUserData.IsFavorite;
            };
        }

        private void OnHeardChangedUpdateModel()
        {
            _audioDramaView.HeardChanged += (sender, _) =>
            {
                _audioDrama.AudioDramaUserData.Heard = !_audioDrama.AudioDramaUserData.Heard;
            };
        }

        private void UpdateViewWithCurrentAudioDrama()
        {
            _audioDramaView.SetAudioDrama(_audioDrama);
        }
    }
}

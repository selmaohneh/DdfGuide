namespace DdfGuide.Core
{
    public class AudioDramaPresenter
    {
        private readonly IAudioDramaView _audioDramaView;
        private readonly AudioDrama _audioDrama;
        private readonly IViewer _viewer;

        public AudioDramaPresenter(
            IAudioDramaView audioDramaView,
            AudioDrama audioDrama,
            IViewer viewer)
        {
            _audioDramaView = audioDramaView;
            _audioDrama = audioDrama;
            _viewer = viewer;

            SubscribeToViewEvents();
            SubscribeToModelEvents();
            UpdateViewWithCurrentAudioDrama();
        }

        private void SubscribeToModelEvents()
        {
            OnUserDataChangedUpdateView();
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

        private void OnUserDataChangedUpdateView()
        {
            _audioDrama.AudioDramaUserData.Changed += (sender, args) =>
            {
                UpdateViewWithCurrentAudioDrama();
            };
        }

        private void UpdateViewWithCurrentAudioDrama()
        {
            _audioDramaView.SetAudioDrama(_audioDrama);
        }
    }
}

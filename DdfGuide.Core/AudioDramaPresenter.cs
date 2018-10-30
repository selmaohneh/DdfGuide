using System;

namespace DdfGuide.Core
{
    public class AudioDramaPresenter : IPresenter<IAudioDramaView,AudioDrama>
    {
        private readonly IAudioDramaView _audioDramaView;
        private AudioDrama _audioDrama;

        public AudioDramaPresenter(
            IAudioDramaView audioDramaView,
            IViewer viewer)
        {
            _audioDramaView = audioDramaView;
            
            _audioDramaView.BackClicked += OnBackClicked(viewer);
            _audioDramaView.IsFavoriteClicked += OnIsFavoriteChanged();
            _audioDramaView.HeardClicked += OnHeardChanged();
        }

        public IAudioDramaView GetView()
        {
            return _audioDramaView;
        }

        public void SetModel(AudioDrama model)
        {
            _audioDrama = model;

            _audioDrama.AudioDramaUserData.Changed -= OnUserDataChanged();
            _audioDrama.AudioDramaUserData.Changed += OnUserDataChanged();

            UpdateViewWithCurrentAudioDrama();
        }

        private EventHandler OnHeardChanged()
        {
            return (sender, _) =>
            {
                _audioDrama.AudioDramaUserData.Heard = !_audioDrama.AudioDramaUserData.Heard;
            };
        }

        private EventHandler OnIsFavoriteChanged()
        {
            return (sender, _) =>
            {
                _audioDrama.AudioDramaUserData.IsFavorite = !_audioDrama.AudioDramaUserData.IsFavorite;
            };
        }

        private EventHandler OnBackClicked(IViewer viewer)
        {
            return (sender, _) => { viewer.ShowLast(); };
        }

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { UpdateViewWithCurrentAudioDrama(); };
        }

        private void UpdateViewWithCurrentAudioDrama()
        {
            _audioDramaView.SetAudioDrama(_audioDrama);
        }
    }
}

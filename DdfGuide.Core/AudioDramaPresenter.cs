using System;

namespace DdfGuide.Core
{
    public class AudioDramaPresenter : IPresenter<IAudioDramaView, AudioDrama>
    {
        private readonly IAudioDramaView _audioDramaView;
        private readonly IUriInvoker _uriInvoker;
        private AudioDrama _audioDrama;

        public AudioDramaPresenter(
            IAudioDramaView audioDramaView, IUriInvoker uriInvoker)
        {
            _audioDramaView = audioDramaView;
            _uriInvoker = uriInvoker;

            _audioDramaView.IsFavoriteClicked += OnIsFavoriteChanged();
            _audioDramaView.HeardClicked += OnHeardChanged();
            _audioDramaView.PlayClicked += AudioDramaViewOnPlayClicked;
            _audioDramaView.BuyClicked += AudioDramaViewOnBuyClicked;
        }

        private void AudioDramaViewOnBuyClicked(object sender, EventArgs e)
        {
            _uriInvoker.Invoke(_audioDrama.AudioDramaDto.AmazonBuyUri);
        }

        private void AudioDramaViewOnPlayClicked(object sender, EventArgs e)
        {
            _uriInvoker.Invoke(_audioDrama.AudioDramaDto.SpotifyUri);
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
            return (sender, _) => { _audioDrama.AudioDramaUserData.Heard = !_audioDrama.AudioDramaUserData.Heard; };
        }

        private EventHandler OnIsFavoriteChanged()
        {
            return (sender, _) =>
            {
                _audioDrama.AudioDramaUserData.IsFavorite = !_audioDrama.AudioDramaUserData.IsFavorite;
            };
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
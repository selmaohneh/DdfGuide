using DdfGuide.Core.Models;
using DdfGuide.Core.Views;

namespace DdfGuide.Core.Presenters
{
    public class AudioDramaViewPresenter
    {
        private readonly IAudioDramaView _audioDramaView;
        private readonly AudioDrama _audioDrama;
        private readonly IViewer _viewer;

        public AudioDramaViewPresenter(
            IAudioDramaView audioDramaView,
            AudioDrama audioDrama,
            IViewer viewer)
        {
            _audioDramaView = audioDramaView;
            _audioDrama = audioDrama;
            _viewer = viewer;

            InitSubscriptions();
            UpdateViewWithCurrentAudioDrama();
        }

        private void InitSubscriptions()
        {
            OnHeardChangedUpdateModelAndView();
            OnIsFavoriteChangedUpdateModelAndView();
            OnBackClickedShowLastView();
        }

        private void OnBackClickedShowLastView()
        {
            _audioDramaView.BackClicked += (sender, _) => { _viewer.ShowLast(); };
        }

        private void OnIsFavoriteChangedUpdateModelAndView()
        {
            _audioDramaView.IsFavoriteChanged += (sender, _) =>
            {
                _audioDrama.AudioDramaUserData.IsFavorite = !_audioDrama.AudioDramaUserData.IsFavorite;

                UpdateViewWithCurrentAudioDrama();
            };
        }

        private void OnHeardChangedUpdateModelAndView()
        {
            _audioDramaView.HeardChanged += (sender, _) =>
            {
                _audioDrama.AudioDramaUserData.Heard = !_audioDrama.AudioDramaUserData.Heard;

                UpdateViewWithCurrentAudioDrama();
            };
        }

        private void UpdateViewWithCurrentAudioDrama()
        {
            _audioDramaView.SetAudioDrama(_audioDrama);
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class AudioDramaListViewPresenter
    {
        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;
        private readonly IEnumerable<AudioDrama> _audioDramas;
        private readonly IViewer _viewer;

        public AudioDramaListViewPresenter(
            IAudioDramaListView audioDramaListView, 
            IAudioDramaView audioDramaView,
            IEnumerable<AudioDrama> audioDramas,
            IViewer viewer)
        {
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _audioDramas = audioDramas;
            _viewer = viewer;

            InitSubscriptions();
            UpdateViewWithCurrentAudioDramas();
        }

        private void InitSubscriptions()
        {
            OnHeardChangedUpdateModelAndView();
            OnIsFavoriteChangedUpdateModelAndView();
            OnAudioDramaClickedOpenAudioDramaView();
        }

        private void OnAudioDramaClickedOpenAudioDramaView()
        {
            _audioDramaListView.AudioDramaClicked += (sender, id) =>
            {
                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);

                // Todo: Is there a way to bring this to the app root?
                var _ = new AudioDramaViewPresenter(
                    _audioDramaView,
                    audioDrama,
                    _viewer);

                _viewer.Show(_audioDramaView);
            };
        }

        private void OnIsFavoriteChangedUpdateModelAndView()
        {
            _audioDramaListView.IsFavoriteChanged += (sender, id) =>
            {
                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                audioDrama.AudioDramaUserData.IsFavorite = !audioDrama.AudioDramaUserData.IsFavorite;
                
               UpdateViewWithCurrentAudioDramas();
            };
        }

        private void OnHeardChangedUpdateModelAndView()
        {
            _audioDramaListView.HeardChanged += (sender, id) =>
            {
                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                audioDrama.AudioDramaUserData.Heard = !audioDrama.AudioDramaUserData.Heard;

               UpdateViewWithCurrentAudioDramas();
            };
        }

        private void UpdateViewWithCurrentAudioDramas()
        {
            _audioDramaListView.SetAudioDramas(_audioDramas);
        }
    }
}

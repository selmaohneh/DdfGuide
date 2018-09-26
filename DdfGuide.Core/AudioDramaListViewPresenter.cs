using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class AudioDramaListViewPresenter
    {
        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IEnumerable<AudioDrama> _audioDramas;

        public AudioDramaListViewPresenter(
            IAudioDramaListView audioDramaListView, 
            IEnumerable<AudioDrama> audioDramas)
        {
            _audioDramaListView = audioDramaListView;
            _audioDramas = audioDramas;

            InitSubscriptions();
            UpdateViewWithCurrentAudioDramas();
        }

        private void InitSubscriptions()
        {
            OnHeardChangedUpdateModelAndView();
            OnIsFavoriteChangedUpdateModelAndView();
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

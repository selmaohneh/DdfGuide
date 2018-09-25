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
            InitViewWithAudioDramas();
        }

        private void InitSubscriptions()
        {
            OnHeardChangedUpdateModel();
            OnIsFavoriteChangedUpdateModel();
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

        private void InitViewWithAudioDramas()
        {
            _audioDramaListView.SetAudioDramas(_audioDramas);
        }
    }
}

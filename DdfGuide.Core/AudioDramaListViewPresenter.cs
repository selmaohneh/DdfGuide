using System.Collections.Generic;

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

            InitViewWithAudioDramas();
        }

        private void InitViewWithAudioDramas()
        {
            _audioDramaListView.SetAudioDramas(_audioDramas);
        }
    }
}

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
            _audioDramaListView.HeardChanged += (sender, guid) => { };
        }

        private void InitViewWithAudioDramas()
        {
            _audioDramaListView.SetAudioDramas(_audioDramas);
        }
    }
}

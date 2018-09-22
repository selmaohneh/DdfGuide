using System.Threading.Tasks;
using Repository.Interfaces;

namespace DdfGuide.Core
{
    public class DdfGuide
    {
        private readonly IRepository<AudioDrama> _localRepository;
        private readonly IAudioDramaListView _audioDramaListView;

        public DdfGuide(
            IRepository<AudioDrama> localRepository, 
            IAudioDramaListView audioDramaListView)
        {
            _localRepository = localRepository;
            _audioDramaListView = audioDramaListView;
        }

        public async Task Start()
        {
            var audioDramas = await _localRepository.GetAll();
            _audioDramaListView.SetAudioDramas(audioDramas);
            _audioDramaListView.Show();
        }
    }
}

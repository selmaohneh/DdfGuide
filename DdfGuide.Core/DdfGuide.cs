using System.Threading.Tasks;
using Repository.Interfaces;

namespace DdfGuide.Core
{
    public class DdfGuide
    {
        private readonly IRepository<AudioDrama> _audioDramaRepository;
        private readonly IRepository<AudioDramaUserData> _audioDramaUserDataRepository;

        private readonly IAudioDramaListView _audioDramaListView;

        public DdfGuide(
            IRepository<AudioDrama> audioDramaRepository, 
            IRepository<AudioDramaUserData> audioDramaUserDataRepository,
            IAudioDramaListView audioDramaListView)
        {
            _audioDramaRepository = audioDramaRepository;
            _audioDramaUserDataRepository = audioDramaUserDataRepository;
            _audioDramaListView = audioDramaListView;
        }

        public async Task Start()
        {
            var audioDramas = await _audioDramaRepository.GetAll();
            _audioDramaListView.SetAudioDramas(audioDramas);

            var audioDramaUserData = await _audioDramaUserDataRepository.GetAll();
            _audioDramaListView.SetAudioDramaUserData(audioDramaUserData);

            _audioDramaListView.Show();
        }
    }
}

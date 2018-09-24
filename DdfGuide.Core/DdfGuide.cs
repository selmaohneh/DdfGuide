using System.Linq;
using System.Threading.Tasks;
using Repository.Interfaces;

namespace DdfGuide.Core
{
    public class DdfGuide
    {
        private readonly IRepository<AudioDramaDto> _dtoRepository;
        private readonly IRepository<AudioDramaUserData> _userDataRepository;
        private readonly IAudioDramaListView _audioDramaListView;

        public DdfGuide(
            IRepository<AudioDramaDto> dtoRepository, 
            IRepository<AudioDramaUserData> userDataRepository,
            IAudioDramaListView audioDramaListView)
        {
            _dtoRepository = dtoRepository;
            _userDataRepository = userDataRepository;
            _audioDramaListView = audioDramaListView;
        }

        public async Task Start()
        {
            var dtos = (await _dtoRepository.GetAll()).ToList();
            var userData = (await _userDataRepository.GetAll()).ToList();
            
            var audioDramaBuilder = new AudioDramaBuilder(
                dtos,
                userData);

            var audioDramas = audioDramaBuilder.Build();

            var _ = new AudioDramaListViewPresenter(
                _audioDramaListView,
                audioDramas);

            _audioDramaListView.Show();
        }   
    }
}

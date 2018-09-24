using System.Collections.Generic;
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
            var dtos = await _dtoRepository.GetAll();
            var userData = await _userDataRepository.GetAll();
            var audioDramas = BuildAudioDramas(dtos, userData);

            _audioDramaListView.SetAudioDramas(audioDramas);

            _audioDramaListView.Show();
        }

        private IEnumerable<AudioDrama> BuildAudioDramas(
            IEnumerable<AudioDramaDto> dtos, 
            IEnumerable<AudioDramaUserData> userData)
        {
            var userDataList = userData.ToList();

            var audioDramas = new List<AudioDrama>();
            foreach (var dto in dtos)
            {
                var userDataForId = userDataList.SingleOrDefault(x => x.Id == dto.Id);
                if (userDataForId == null)
                {
                    userDataForId = new AudioDramaUserData(dto.Id, false, false);
                }

                var audioDrama = new AudioDrama(dto, userDataForId);
                audioDramas.Add(audioDrama);
            }

            return audioDramas;
        }
    }
}

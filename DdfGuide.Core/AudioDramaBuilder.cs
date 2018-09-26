using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core.Models;

namespace DdfGuide.Core
{
    public class AudioDramaBuilder
    {
        private readonly IEnumerable<AudioDramaDto> _dtos;
        private readonly IEnumerable<AudioDramaUserData> _userDatas;

        public AudioDramaBuilder(IEnumerable<AudioDramaDto> dtos, IEnumerable<AudioDramaUserData> userDatas)
        {
            _dtos = dtos;
            _userDatas = userDatas;
        }

        public IEnumerable<AudioDrama> Build()
        {
            var userDataList = _userDatas.ToList();

            var audioDramas = new List<AudioDrama>();
            foreach (var dto in _dtos)
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

using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class AudioDramaBuilder : IAudioDramaBuilder
    {
        public IEnumerable<AudioDrama> Build(IEnumerable<AudioDramaDto> dtos, IEnumerable<AudioDramaUserData> userDatas)
        {
            var userDataList = userDatas.ToList();

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

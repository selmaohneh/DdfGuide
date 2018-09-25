using System;
using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class DtoProvider : IProvider<IEnumerable<AudioDramaDto>>
    {
        public static IEnumerable<Guid> SampleIds = new List<Guid>
        {
            Guid.NewGuid(),
            Guid.NewGuid(),
            Guid.NewGuid(),
            Guid.NewGuid()
        };

        public IEnumerable<AudioDramaDto> Get()
        {
            var dtos = new List<AudioDramaDto>();

            foreach (var sampleId in SampleIds)
            {
                var dto = new AudioDramaDto(sampleId);
                dtos.Add(dto);
            }

            return dtos;
        }
    }

    public class UserDataProvider : IProvider<IEnumerable<AudioDramaUserData>>
    {
        public IEnumerable<AudioDramaUserData> Get()
        {
            var userDatas = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(DtoProvider.SampleIds.ElementAt(0), true, true),
                new AudioDramaUserData(DtoProvider.SampleIds.ElementAt(1), true, false),
                new AudioDramaUserData(DtoProvider.SampleIds.ElementAt(2), false, true),
                new AudioDramaUserData(DtoProvider.SampleIds.ElementAt(3), false, false)
            };

            return userDatas;
        }
    }

    public class AudioDramaProvider : IProvider<IEnumerable<AudioDrama>>
    {
        public IEnumerable<AudioDrama> Get()
        {
            var dtoProvider = new DtoProvider();
            var userDataProvider = new UserDataProvider();

            var dtos = dtoProvider.Get();
            var userDatas = userDataProvider.Get();

            var audioDramaBuilder = new AudioDramaBuilder(dtos, userDatas);

            var audioDramas = audioDramaBuilder.Build();

            return audioDramas;
        }
    }
}

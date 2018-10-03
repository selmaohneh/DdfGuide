using System;
using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class SingleDtoProvider : IProvider<IEnumerable<AudioDramaDto>>
    {
        public IEnumerable<AudioDramaDto> Get()
        {
            var dto = new AudioDramaDto(MultipleDtoProvider.SampleIds.First(), "Sample name");
            var list = new List<AudioDramaDto> {dto};
            return list;
        }
    }

    public class MultipleDtoProvider : IProvider<IEnumerable<AudioDramaDto>>
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

            var i = 1;
            foreach (var sampleId in SampleIds)
            {
                var dto = new AudioDramaDto(sampleId, $"Sample name {i++}");
                dtos.Add(dto);
            }

            return dtos;
        }
    }

    public class MultipleUserDataProvider : IProvider<IEnumerable<AudioDramaUserData>>
    {
        public IEnumerable<AudioDramaUserData> Get()
        {
            var userDatas = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(MultipleDtoProvider.SampleIds.ElementAt(0), true, true),
                new AudioDramaUserData(MultipleDtoProvider.SampleIds.ElementAt(1), true, false),
                new AudioDramaUserData(MultipleDtoProvider.SampleIds.ElementAt(2), false, true),
                new AudioDramaUserData(MultipleDtoProvider.SampleIds.ElementAt(3), false, false)
            };

            return userDatas;
        }
    }

    public class SingleUserDataProvider : IProvider<IEnumerable<AudioDramaUserData>>
    {
        public IEnumerable<AudioDramaUserData> Get()
        {
            var userData = new AudioDramaUserData(MultipleDtoProvider.SampleIds.First(), false, false);
            var list = new List<AudioDramaUserData> {userData};
            return list;
        }
    }

    public class MultipleAudioDramaProvider : IProvider<IEnumerable<AudioDrama>>
    {
        public IEnumerable<AudioDrama> Get()
        {
            var dtoProvider = new MultipleDtoProvider();
            var userDataProvider = new MultipleUserDataProvider();

            var dtos = dtoProvider.Get();
            var userDatas = userDataProvider.Get();

            var audioDramaBuilder = new AudioDramaBuilder(dtos, userDatas);

            var audioDramas = audioDramaBuilder.Build();

            return audioDramas;
        }
    }

    public class SingleAudioDramaProvider : IProvider<IEnumerable<AudioDrama>>
    {
        public IEnumerable<AudioDrama> Get()
        {
            var dtoProvider = new SingleDtoProvider();
            var userDataProvider = new SingleUserDataProvider();

            var dto = dtoProvider.Get();
            var userData = userDataProvider.Get();

            var audioDrama = new AudioDrama(dto.First(), userData.First());

            var list = new List<AudioDrama> {audioDrama};

            return list;
        }
    }
}
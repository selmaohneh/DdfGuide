using DdfGuide.Core;
using Newtonsoft.Json;

namespace DdfGuide.Tests
{
    public class SampleDtoProvider : IProvider<IEnumerable<AudioDramaDto>>
    {
        public IEnumerable<AudioDramaDto> Get()
        {
            var json = File.ReadAllText("sampleDtos.json");
            var dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaDto>>(json);

            return dtos.Take(4);
        }
    }

    public class SampleUserDataProvider : IProvider<IEnumerable<AudioDramaUserData>>
    {
        public IEnumerable<AudioDramaUserData> Get()
        {
            var dtos = new SampleDtoProvider().Get().ToList();

            var userDatas = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(dtos.ElementAt(0).Id, false, false),
                new AudioDramaUserData(dtos.ElementAt(1).Id, false, true),
                new AudioDramaUserData(dtos.ElementAt(2).Id, true, false),
                new AudioDramaUserData(dtos.ElementAt(3).Id, true, true)
            };

            return userDatas;
        }
    }

    public class SampleAudioDramaProvider : IProvider<IEnumerable<AudioDrama>>
    {
        public IEnumerable<AudioDrama> Get()
        {
            var dtoProvider = new SampleDtoProvider();
            var userDataProvider = new SampleUserDataProvider();

            var dtos = dtoProvider.Get().ToList();
            var userDatas = userDataProvider.Get().ToList();

            var audioDramas = new List<AudioDrama>();

            for (var i = 0; i < dtos.Count; i++)
            {
                var audioDrama = new AudioDrama(
                    dtos.ElementAt(i),
                    userDatas.ElementAt(i));

                audioDramas.Add(audioDrama);
            }

            return audioDramas;
        }
    }
}
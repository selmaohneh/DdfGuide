using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DdfGuide.Core
{
    public class AudioDramaSource : ISource<IEnumerable<AudioDrama>>
    {
        private readonly ICache<IEnumerable<AudioDramaDto>> _dtoCache;
        private readonly ICache<IEnumerable<AudioDramaUserData>> _userDataCache;
        private readonly IAudioDramaBuilder _audioDramaBuilder;
        private readonly IOnUserDataChangedInCacheSaver _saver;

        public AudioDramaSource(
            ICache<IEnumerable<AudioDramaDto>> dtoCache,
            ICache<IEnumerable<AudioDramaUserData>> userDataCache,
            IAudioDramaBuilder audioDramaBuilder,
            IOnUserDataChangedInCacheSaver saver)
        {
            _dtoCache = dtoCache;
            _userDataCache = userDataCache;
            _audioDramaBuilder = audioDramaBuilder;
            _saver = saver;
        }

        public IEnumerable<AudioDrama> Get()
        {
            var dtos = _dtoCache.Load();
            var userData = _userDataCache.Load();
            
            var audioDramas = _audioDramaBuilder.Build(
                dtos,
                userData).ToList();
            
            _saver.SetObservedUserDatas(audioDramas.Select(x=>x.AudioDramaUserData));

            return audioDramas;
        }

        public async Task Update()
        {
            var wc = new WebClient();

            string json;
            try
            {
                json = await wc.DownloadStringTaskAsync("https://raw.githubusercontent.com/selmaohneh/DdfGuide/master/dtos.json");
            }
            catch (WebException)
            {
                return;
            }

            var dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaDto>>(json);
            _dtoCache.Save(dtos);
        }
    }
}

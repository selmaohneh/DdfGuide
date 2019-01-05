using System;
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
        private readonly IUserNotifier _notifier;

        public AudioDramaSource(
            ICache<IEnumerable<AudioDramaDto>> dtoCache,
            ICache<IEnumerable<AudioDramaUserData>> userDataCache,
            IAudioDramaBuilder audioDramaBuilder,
            IOnUserDataChangedInCacheSaver saver,
            IUserNotifier notifier)
        {
            _dtoCache = dtoCache;
            _userDataCache = userDataCache;
            _audioDramaBuilder = audioDramaBuilder;
            _saver = saver;
            _notifier = notifier;
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
                var downloadTask = wc.DownloadStringTaskAsync("https://raw.githubusercontent.com/selmaohneh/DdfGuide/master/dtos.json");
                var timeoutTask = Task.Delay(TimeSpan.FromSeconds(7));

                var completedTask = await Task.WhenAny(downloadTask, timeoutTask);

                if (completedTask == timeoutTask)
                {
                    _notifier.Notify("Aktualisierung abgebrochen. Schlechte Internetverbindung");
                    return;
                }

                json = downloadTask.Result;
            }
            catch (WebException)
            {
                _notifier.Notify("Aktualisierung fehlgeschlagen. Keine Intertverbindung.");
                return;
            }

            var dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaDto>>(json);
            _dtoCache.Save(dtos);

            _notifier.Notify("Aktualisierung erfolgreich.");
        }
    }
}

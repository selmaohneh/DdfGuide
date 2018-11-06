using System.Collections.Generic;
using System.Net;
using DdfGuide.Core;
using Newtonsoft.Json;

namespace DdfGuide.Android
{
    public class AndroidDtoProvider : IProvider<IEnumerable<AudioDramaDto>>
    {
        public IEnumerable<AudioDramaDto> Get()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(
                "https://raw.githubusercontent.com/selmaohneh/DdfGuide/master/dtos.json");

            var dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaDto>>(json);

            return dtos;
        }
    }
}
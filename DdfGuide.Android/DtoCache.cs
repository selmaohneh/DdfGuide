using System.Collections.Generic;
using DdfGuide.Core;
using Newtonsoft.Json;
using Plugin.Settings;

namespace DdfGuide.Android
{
    public class DtoCache : ICache<IEnumerable<AudioDramaDto>>
    {
        private const string Key = "dtos";

        public IEnumerable<AudioDramaDto> Load()
        {
            var json = CrossSettings.Current.GetValueOrDefault(Key, "[]");
            var dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaDto>>(json);

            return dtos;
        }

        public void Save(IEnumerable<AudioDramaDto> items)
        {
            var json = JsonConvert.SerializeObject(items);
            CrossSettings.Current.AddOrUpdateValue(Key, json);
        }
    }
}
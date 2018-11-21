using System.Collections.Generic;
using DdfGuide.Core;
using Newtonsoft.Json;
using Plugin.Settings;

namespace DdfGuide.Android
{
    public class UserDataCache :ICache<IEnumerable<AudioDramaUserData>>
    {
        private const string Key = "userdata";

        public IEnumerable<AudioDramaUserData> Load()
        {
            var json = CrossSettings.Current.GetValueOrDefault(Key, "[]");
            var dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaUserData>>(json);

            return dtos;
        }

        public void Save(IEnumerable<AudioDramaUserData> items)
        {
            var json = JsonConvert.SerializeObject(items);
            CrossSettings.Current.AddOrUpdateValue(Key, json);
        }
    }
}
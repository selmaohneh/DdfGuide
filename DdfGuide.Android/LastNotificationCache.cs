using System;
using DdfGuide.Core;
using Plugin.Settings;

namespace DdfGuide.Android
{
    public class LastNotificationCache : ICache<DateTime>
    {
        private const string Key = "lastnotification";

        public DateTime Load()
        {
            var lastNotification = CrossSettings.Current.GetValueOrDefault(Key, DateTime.MinValue);

            return lastNotification;
        }

        public void Save(DateTime lastNotification)
        {
            CrossSettings.Current.AddOrUpdateValue(Key, lastNotification);
        }
    }
}
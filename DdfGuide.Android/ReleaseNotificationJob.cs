using System;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.App.Job;
using Android.Graphics;
using Android.OS;
using Android.Support.V4.App;
using DdfGuide.Core;
using FFImageLoading;
using Nito.AsyncEx;

namespace DdfGuide.Android
{
    [Service(Name = "celloapps.ddfguide.ReleaseNotificationJob",
        Permission = "android.permission.BIND_JOB_SERVICE")]
    public class ReleaseNotificationJob : JobService
    {
        public override bool OnStartJob(JobParameters @params)
        {
            Task.Run(() => ShowNotificationsIfApplicable(@params));

            return true;
        }

        private void ShowNotificationsIfApplicable(JobParameters @params)
        {
            var source = new DtoCache();
            var dtos = source.Load()?.ToList();

            if (dtos == null)
            {
                JobFinished(@params, false);
                return;
            }

            var lastNotificationCache = new LastNotificationCache();
            var lastNotification = lastNotificationCache.Load();

            if (lastNotification.Date == DateTime.Today)
            {
                JobFinished(@params, false);
                return;
            }

            var releaseDateService = new ReleaseDateService();
            var releases = releaseDateService.GetTodaysReleasesFrom(dtos).ToList();

            if (!releases.Any())
            {
                JobFinished(@params, false);
                return;
            }

            CreateNotificationChannel();
            var notificationManager = NotificationManagerCompat.From(this);

            for (var i = 0; i < releases.Count; i++)
            {
                var dto = releases[i];

                var cover = AsyncContext.Run(() => DownloadCover(dto));

                var builder = new NotificationCompat.Builder(this, "channelid")
                    .SetAutoCancel(true)
                    .SetContentTitle($"Neue {dto.Interpreter}-Folge!")
                    .SetSmallIcon(Resource.Mipmap.ic_stat_notification)
                    .SetLargeIcon(cover)
                    .SetContentText(dto.Title);

                notificationManager.Notify(i, builder.Build());

                lastNotificationCache.Save(DateTime.Now);
            }

            JobFinished(@params, false);
        }

        private async Task<Bitmap> DownloadCover(AudioDramaDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.CoverUrl))
            {
                return BitmapFactory.DecodeResource(Resources, Resource.Drawable.ic_launcher);
            }

            try
            {
                return (await ImageService.Instance.LoadUrl(dto.CoverUrl).AsBitmapDrawableAsync()).Bitmap;
            }
            catch (Exception)
            {
                return BitmapFactory.DecodeResource(Resources, Resource.Drawable.ic_launcher);
            }
        }

        public override bool OnStopJob(JobParameters @params)
        {
            return false;
        }

        private void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                // Notification channels are new in API 26 (and not a part of the
                // support library). There is no need to create a notification
                // channel on older versions of Android.
                return;
            }

            var channel = new NotificationChannel("channelid", "channelname", NotificationImportance.Default)
            {
                Description = "channeldescription"
            };

            var notificationManager = (NotificationManager) GetSystemService(NotificationService);

            notificationManager.CreateNotificationChannel(channel);
        }
    }
}
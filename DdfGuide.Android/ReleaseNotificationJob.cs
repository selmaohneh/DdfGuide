using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.App.Job;
using Android.Graphics;
using Android.OS;
using Android.Support.V4.App;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    [Service(Name = "celloapps.ddfguide.ReleaseNotificationJob",
        Permission = "android.permission.BIND_JOB_SERVICE")]
    public class ReleaseNotificationJob : JobService
    {
        public override bool OnStartJob(JobParameters @params)
        {
            Task.Run(() =>
            {
                var source = new DtoCache();
                var dtos = source.Load();

                if (dtos == null)
                {
                    JobFinished(@params, false);
                    return;
                }

                var releaseDateService = new ReleaseDateService();
                var releases = releaseDateService.GetTodaysReleasesFrom(dtos).ToList();

                releases.Add(dtos.First());
                releases.Add(dtos.Last());

                CreateNotificationChannel();
                var notificationManager = NotificationManagerCompat.From(this);
                
                for (var i = 0; i < releases.Count; i++)
                {
                    var dto = releases[i];

                    var builder = new NotificationCompat.Builder(this, "channelid")
                        .SetOnlyAlertOnce(true)
                        .SetAutoCancel(true)
                        .SetContentTitle($"Neue {dto.Interpreter}-Folge!")
                        .SetSmallIcon(Resource.Mipmap.ic_stat_notification)
                        .SetLargeIcon(BitmapFactory.DecodeResource(Resources, Resource.Drawable.ic_launcher))
                        .SetContentText(dto.Title);
                    
                    notificationManager.Notify(i, builder.Build());
                }

                JobFinished(@params, false);
            });

            return true;
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
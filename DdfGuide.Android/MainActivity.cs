﻿using System;
using Android.App;
using Android.App.Job;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,
        ScreenOrientation = ScreenOrientation.Portrait, ConfigurationChanges = ConfigChanges.Orientation)]
    public class MainActivity : Activity, IRootView
    {
        private Core.DdfGuide _ddfGuide;

        [Obsolete]
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var releaseDateService = new ReleaseDateService();
            var filler = new ImageViewFiller();
            var userNotifier = new ToastNotifier(this);
            var audioDramaListView = new AudioDramaListView(filler, releaseDateService,userNotifier);
            var audioDramaView = new AudioDramaView(filler);
            var rootView = this;
            var dtoCache = new DtoCache();
            var userDataCache = new UserDataCache();
            var shutdown = new AndroidShutdown(this);
            var uriInvoker = new UriInvoker(this);
            var clipboardService = new ClipboardService(this);
            var yesNoDialog = new YesNoDialog(this);
            var okDialog = new OkDialog(this);
            var updatingView = new UpdatingView();

            _ddfGuide = new Core.DdfGuide(
                audioDramaListView,
                audioDramaView,
                rootView,
                dtoCache,
                userDataCache,
                shutdown,
                userNotifier,
                uriInvoker,
                clipboardService,
                yesNoDialog,
                okDialog,
                updatingView
            );

            await _ddfGuide.Start();

            ScheduleReleaseNotificationJob();
        }

        private void ScheduleReleaseNotificationJob()
        {
            var jobBuilder = this.CreateJobBuilderUsingJobId<ReleaseNotificationJob>(1);
            var jobInfo = jobBuilder
                .SetPeriodic(TimeSpan.FromHours(6).Milliseconds)
                .SetPersisted(true)
                .Build();

            var jobScheduler = (JobScheduler) GetSystemService(JobSchedulerService);
            jobScheduler.Schedule(jobInfo);
        }

        [Obsolete]
        public void Show(IView view)
        {
            if (!(view is Fragment fragment))
            {
                throw new Exception("View needs to be of type Android.App.Fragment");
            }

            var transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.rootLayout, fragment);
            transaction.CommitAllowingStateLoss();
            FragmentManager.ExecutePendingTransactions();
        }

        [Obsolete]
        public override void OnBackPressed()
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            //ViewDestroyed?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            // To prevent IllegalStateException. See ticket #18.
        }

        public override void OnSaveInstanceState(Bundle outState, PersistableBundle outPersistentState)
        {
            // To prevent IllegalStateException. See ticket #18.
        }

        public event EventHandler BackClicked;
        public event EventHandler ViewDestroyed;
    }
}
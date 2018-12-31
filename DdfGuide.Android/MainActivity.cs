using System;
using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.Orientation)]
    public class MainActivity : Activity, IRootView
    {
        private Core.DdfGuide _ddfGuide;

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var filler = new ImageViewFiller();
            var audioDramaListView = new AudioDramaListView(filler);
            var audioDramaView = new AudioDramaView(filler);
            var rootView = this;
            var dtoCache = new DtoCache();
            var userDataCache = new UserDataCache();
            var shutdown = new AndroidShutdown(this);

            _ddfGuide = new Core.DdfGuide(
                audioDramaListView,
                audioDramaView,
                rootView,
                dtoCache,
                userDataCache,
                shutdown
            );

            await _ddfGuide.Start();
        }

        public void Show(IView view)
        {
            if (!(view is Fragment fragment))
            {
               throw new Exception("View needs to be of type Android.App.Fragment");
            }

            var transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.rootLayout, fragment);
            transaction.Commit();
            FragmentManager.ExecutePendingTransactions();
        }

        public override void OnBackPressed()
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            ViewDestroyed?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler BackClicked;
        public event EventHandler ViewDestroyed;
    }
}
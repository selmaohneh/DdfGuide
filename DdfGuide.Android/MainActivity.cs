using System;
using Android.App;
using Android.OS;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity, IRootView
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var dtoProvider = new AndroidDtoProvider();
            var userDataProvider = new AndroidUserDataProvider();

            var audioDramaListView = new AudioDramaListView();
            var audioDramaView = new AudioDramaView();
            var rootView = this;
            var interpreterSelectionView = new InterpreterSelectionView();

            var ddfGuide = new Core.DdfGuide(
                dtoProvider,
                userDataProvider,
                audioDramaListView,
                audioDramaView,
                rootView,
                interpreterSelectionView);
            
            ddfGuide.Start();
        }

        public void Show(IView view)
        {
            if (!(view is Fragment fragment))
            {
               throw new Exception("View needs to be of type Android.Views.View");
            }

            var transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.rootLayout, fragment);
            transaction.Commit();
        }
    }
}
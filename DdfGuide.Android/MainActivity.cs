using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IRootView
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }

        public void Show(IView view)
        {
            var rootLayout = FindViewById<RelativeLayout>(Resource.Id.rootLayout);

            if (!(view is View androidView))
            {
                throw new Exception("View needs to be of type Android.Views.View");
            }

            rootLayout.RemoveAllViews();
            rootLayout.AddView(androidView);
        }
    }
}
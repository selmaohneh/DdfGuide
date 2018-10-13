using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class InterpreterSelectionView : Fragment, IInterpreterSelectionView
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.interpreterselectionlayout, container, false);;

            var dieDreiFragezeichenButton = view.FindViewById<Button>(Resource.Id.buttondiedreifragezeichen);
            dieDreiFragezeichenButton.Click += (sender, args) =>
            {
                DieDreiFragezeichenClicked?.Invoke(this, EventArgs.Empty);
            };

            return view;
        }

        public event EventHandler BackClicked;
        public event EventHandler DieDreiFragezeichenClicked;
        public event EventHandler DieDreiClicked;
        public event EventHandler DieDreiFragezeichenKidsClicked;
    }
}
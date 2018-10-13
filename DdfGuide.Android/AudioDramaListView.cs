using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Android
{
    public class AudioDramaListView : Fragment, IAudioDramaListView
    {
        private View _view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _view = inflater.Inflate(Resource.Layout.audiodramalistlayout, container, false);

            var toolbar = _view.FindViewById<Toolbar>(Resource.Id.toolbar);

            toolbar.SetNavigationIcon(Resource.Mipmap.arrow_back);
            toolbar.NavigationOnClick += (sender, args) => BackClicked?.Invoke(this, EventArgs.Empty);

            return _view;
        }

        public void SetAudioDramaInfos(IEnumerable<AudioDrama> audioDramas)
        {
            var listView = _view.FindViewById<ListView>(Resource.Id.listViewAudioDramas);

            var adapter = new ArrayAdapter<string>(
                Context,
                Resource.Layout.audiodramalistitem,
                audioDramas.Select(x=>x.AudioDramaDto.Title).ToArray());

            listView.Adapter = adapter;
        }

        public void SetFilterInfos(EAudioDramaFilterMode selectedFilterMode)
        {
            // todo
        }

        public void SetSelectedSortMode(EAudioDramaSortMode selectedSortMode)
        {
            // todo
        }

        public string GetCurrentSearchText()
        {
            // todo
            return string.Empty;
        }


        public event EventHandler BackClicked;
        public event EventHandler<Guid> HeardChanged;
        public event EventHandler<Guid> IsFavoriteChanged;
        public event EventHandler<Guid> AudioDramaClicked;
        public event EventHandler OrderByHeardFirstClicked;
        public event EventHandler OrderByHeardLastClicked;
        public event EventHandler OrderByIsFavoriteFirstClicked;
        public event EventHandler OrderByIsFavoriteLastClicked;
        public event EventHandler OrderByNumberAscendingClicked;
        public event EventHandler OrderByNumberDescendingClicked;
        public event EventHandler OrderByReleaseDateAscendingClicked;
        public event EventHandler OrderByReleaseDateDescendingClicked;
        public event EventHandler OrderByNameAscendingClicked;
        public event EventHandler OrderByNameDescendingClicked;
        public event EventHandler AllClicked;
        public event EventHandler MainsOnlyClicked;
        public event EventHandler SpecialsOnlyClicked;
        public event EventHandler FavoritesOnlyClicked;
        public event EventHandler UnheardOnlyClicked;
        public event EventHandler SearchTextChanged;
        public event EventHandler RandomClicked;
    }
}
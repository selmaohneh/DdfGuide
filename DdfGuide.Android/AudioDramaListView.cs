using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Views;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Android
{
    public class AudioDramaListView : Fragment, IAudioDramaListView
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.audiodramalistlayout, container, false);
        }

        public event EventHandler BackClicked;
        public void SetAudioDramaInfos(IEnumerable<AudioDrama> audioDramas)
        {
            // todo
        }

        public void SetFilterInfos(EAudioDramaFilterMode selectedFilterMode)
        {
            // todo
        }

        public void SetSelectedSortMode(EAudioDramaSortMode selectedSortMode)
        {
            // todo
        }

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
        public string GetCurrentSearchText()
        {
            // todo
            return string.Empty;
        }

        public event EventHandler SearchTextChanged;
        public event EventHandler RandomClicked;
    }
}
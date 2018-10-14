using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;
using SearchView = Android.Support.V7.Widget.SearchView;

namespace DdfGuide.Android
{
    public class AudioDramaListView : Fragment, IAudioDramaListView
    {
        private View _view;
        private Toolbar _toolbar;
        private SearchView _searchView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _view = inflater.Inflate(Resource.Layout.audiodramalistlayout, container, false);

            var fab = _view.FindViewById<FloatingActionButton>(Resource.Id.floatingActionButtonRandom);
            fab.Click += (sender, args) => { RandomClicked?.Invoke(this, EventArgs.Empty); };
            SetupToolbar();

            return _view;
        }

        private void SetupToolbar()
        {
            _toolbar = _view.FindViewById<Toolbar>(Resource.Id.toolbar);
            _toolbar.SetNavigationIcon(Resource.Mipmap.arrow_back);
            _toolbar.NavigationOnClick += (sender, args) => BackClicked?.Invoke(this, EventArgs.Empty);
            _toolbar.InflateMenu(Resource.Menu.listviewmenu);
            _toolbar.MenuItemClick += (sender, args) =>
            {
                switch (args.Item.ItemId)
                {
                    case Resource.Id.ordernumberascending:
                        OrderByNumberAscendingClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.ordernumberdescending:
                        OrderByNumberDescendingClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.orderreleasedateascending:
                        OrderByReleaseDateAscendingClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.orderreleasedatedescending:
                        OrderByReleaseDateDescendingClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.ordernameascending:
                        OrderByNameAscendingClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.ordernamedescending:
                        OrderByNameDescendingClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.heardfirst:
                        OrderByHeardFirstClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.heardlast:
                        OrderByHeardLastClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.favoritesfirst:
                        OrderByIsFavoriteFirstClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.favoriteslast:
                        OrderByIsFavoriteLastClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.showall:
                        AllClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.mainsonly:
                        MainsOnlyClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.specialsonly:
                        SpecialsOnlyClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.favoritesonly:
                        FavoritesOnlyClicked?.Invoke(this, EventArgs.Empty);
                        return;

                    case Resource.Id.unheardsonly:
                        UnheardOnlyClicked?.Invoke(this, EventArgs.Empty);
                        return;
                }
            };

            _searchView = _toolbar.FindViewById<SearchView>(Resource.Id.action_search);
            _searchView.QueryTextChange += (sender, args) => { SearchTextChanged?.Invoke(this, EventArgs.Empty); };
        }

        public void SetAudioDramaInfos(IEnumerable<AudioDrama> audioDramas)
        {
            var listView = _view.FindViewById<ListView>(Resource.Id.listViewAudioDramas);

            var adapter = new AudioDramaListAdapter(Activity, audioDramas);

            listView.ItemClick += (sender, args) =>
            {
                var audioDrama = adapter[args.Position];
                AudioDramaClicked?.Invoke(this, audioDrama.AudioDramaDto.Id);
            };

            listView.Adapter = adapter;
        }

        public void SetFilterInfos(EAudioDramaFilterMode selectedFilterMode)
        {
            var filterItem = _toolbar.Menu.FindItem(Resource.Id.filteritem);
            var filterMenu = filterItem.SubMenu;

            var showAllItem = filterMenu.FindItem(Resource.Id.showall);
            showAllItem.SetChecked(false);

            var mainsOnlyItem = filterMenu.FindItem(Resource.Id.mainsonly);
            mainsOnlyItem.SetChecked(false);

           var favoritesOnlyItem = filterMenu.FindItem(Resource.Id.favoritesonly);
            favoritesOnlyItem.SetChecked(false);

            var unheardsOnlyItem = filterMenu.FindItem(Resource.Id.unheardsonly);
            unheardsOnlyItem.SetChecked(false);

            var specialsOnlyItem = filterMenu.FindItem(Resource.Id.specialsonly);
            specialsOnlyItem.SetChecked(false);

            switch (selectedFilterMode)
            {
                case EAudioDramaFilterMode.All:
                    showAllItem.SetChecked(true);
                    break;
                case EAudioDramaFilterMode.MainsOnly:
                    mainsOnlyItem.SetChecked(true);
                    break;
                case EAudioDramaFilterMode.FavoritesOnly:
                    favoritesOnlyItem.SetChecked(true);
                    break;
                case EAudioDramaFilterMode.UnheardOnly:
                    unheardsOnlyItem.SetChecked(true);
                    break;
                case EAudioDramaFilterMode.SpecialsOnly:
                    specialsOnlyItem.SetChecked(true);
                    break;}
        }

        public void SetSelectedSortMode(EAudioDramaSortMode selectedSortMode)
        {
            var sortItem = _toolbar.Menu.FindItem(Resource.Id.orderitem);
            var sortMenu = sortItem.SubMenu;

            var dateDescending = sortMenu.FindItem(Resource.Id.orderreleasedatedescending);
            dateDescending.SetChecked(false);

            var dateAscending = sortMenu.FindItem(Resource.Id.orderreleasedateascending);
            dateAscending.SetChecked(false);

            var numberDescending = sortMenu.FindItem(Resource.Id.ordernumberdescending);
            numberDescending.SetChecked(false);

            var numberAscending = sortMenu.FindItem(Resource.Id.ordernumberascending);
            numberAscending.SetChecked(false);

            var nameDescending = sortMenu.FindItem(Resource.Id.ordernamedescending);
            nameDescending.SetChecked(false);

            var nameAscending = sortMenu.FindItem(Resource.Id.ordernameascending);
            nameAscending.SetChecked(false);

            var heardFirst = sortMenu.FindItem(Resource.Id.heardfirst);
            heardFirst.SetChecked(false);

            var heardLast = sortMenu.FindItem(Resource.Id.heardlast);
            heardLast.SetChecked(false);

            var isFavoriteFirst = sortMenu.FindItem(Resource.Id.favoritesfirst);
            isFavoriteFirst.SetChecked(false);

            var isFavoriteLast = sortMenu.FindItem(Resource.Id.favoriteslast);
            isFavoriteLast.SetChecked(false);

            switch (selectedSortMode)
            {
                case EAudioDramaSortMode.ReleaseDateDescending:
                    dateDescending.SetChecked(true);
                    break;
                case EAudioDramaSortMode.ReleaseDateAscending:
                    dateAscending.SetChecked(true);
                    break;
                case EAudioDramaSortMode.NumberDescending:
                    numberDescending.SetChecked(true);
                    break;
                case EAudioDramaSortMode.NumberAscending:
                    numberAscending.SetChecked(true);
                    break;
                case EAudioDramaSortMode.NameDescending:
                    nameDescending.SetChecked(true);
                    break;
                case EAudioDramaSortMode.NameAscending:
                    nameAscending.SetChecked(true);
                    break;
                case EAudioDramaSortMode.HeardFirst:
                    heardFirst.SetChecked(true);
                    break;
                case EAudioDramaSortMode.HeardLast:
                    heardLast.SetChecked(true);
                    break;
                case EAudioDramaSortMode.IsFavoriteFirst:
                    isFavoriteFirst.SetChecked(true);
                    break;
                case EAudioDramaSortMode.IsFavoriteLast:
                    isFavoriteLast.SetChecked(true);
                    break;    }
        }

        public string GetCurrentSearchText()
        {
            return _searchView.Query;
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
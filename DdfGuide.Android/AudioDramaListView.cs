using System;
using System.Collections.Generic;
using Android.App;
using Android.Content.Res;
using Android.Graphics;
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
        private AudioDramaListAdapter _listViewAdapter;
        private ListView _listView;
        private TabLayout _tabLayout;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _view = inflater.Inflate(Resource.Layout.audiodramalistlayout, container, false);

            SetupFloatingRandomButton();
            SetupListView();
            SetupToolbar();

            return _view;
        }

        private void SetupFloatingRandomButton()
        {
            var fab = _view.FindViewById<FloatingActionButton>(Resource.Id.floatingActionButtonRandom);
            fab.Click += (sender, args) => { RandomClicked?.Invoke(this, EventArgs.Empty); };
        }

        private void SetupListView()
        {
            _listView = _view.FindViewById<ListView>(Resource.Id.listViewAudioDramas);

            _listViewAdapter = new AudioDramaListAdapter(Activity);

            _listView.ItemClick += (sender, args) =>
            {
                var audioDrama = _listViewAdapter[args.Position];
                AudioDramaClicked?.Invoke(this, audioDrama.AudioDramaDto.Id);
            };

            _listView.Adapter = _listViewAdapter;
        }

        private void SetupToolbar()
        {
            _toolbar = _view.FindViewById<Toolbar>(Resource.Id.toolbar);
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

            _tabLayout = _view.FindViewById<TabLayout>(Resource.Id.tabLayout);
            SetChildTextViewsColor(_tabLayout, ColorStateList.ValueOf(Color.White));
            _tabLayout.TabSelected += (sender, args) =>
            {
                if (args.Tab.Text == "Die drei ???")
                {
                    DieDreiFragezeichenClicked?.Invoke(this, EventArgs.Empty);
                }
                else if (args.Tab.Text == "Die drei ??? Kids")
                {
                    DieDreiFragezeichenKidsClicked?.Invoke(this, EventArgs.Empty);
                }
                else if (args.Tab.Text == "DiE DR3i")
                {
                    DieDreiClicked?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new Exception($"Tab with text '{args.Tab.Text}' does not exist.");
                }
            };

            _searchView = _toolbar.FindViewById<SearchView>(Resource.Id.action_search);
            _searchView.QueryTextChange += (sender, args) => { SearchTextChanged?.Invoke(this, EventArgs.Empty); };
        }

        public void SetAudioDramaInfos(IEnumerable<AudioDrama> audioDramas)
        {
          _listViewAdapter.SetAudioDramas(audioDramas);
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

        public event EventHandler DieDreiClicked;

        public void SetSelectedInterpreter(EAudioDramaFilterMode selectedInterpreter)
        {
            switch (selectedInterpreter)
            {
                case EAudioDramaFilterMode.DieDreiFragezeichen:
                    _tabLayout.GetTabAt(0).Select();
                    break;

                case EAudioDramaFilterMode.DieDreiFragezeichenKids:
                    _tabLayout.GetTabAt(1).Select();
                    break;

                case EAudioDramaFilterMode.DieDrei:
                    _tabLayout.GetTabAt(2).Select();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(selectedInterpreter), selectedInterpreter, null);
            }
        }

        public string GetCurrentSearchText()
        {
            return _searchView.Query;
        }

        private void SetChildTextViewsColor(ViewGroup viewGroup, ColorStateList colorStateList)
        {
            for (var i = 0; i < viewGroup.ChildCount; i++)
            {
                var child = viewGroup.GetChildAt(i);

                if (child is ViewGroup childViewGroup)
                {
                    SetChildTextViewsColor(childViewGroup, colorStateList);
                }
                else if (child is TextView childTextView) {
                    childTextView.SetTextColor(colorStateList);
                }
            }
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
        public event EventHandler DieDreiFragezeichenClicked;
        public event EventHandler DieDreiFragezeichenKidsClicked;
        public event EventHandler SearchTextChanged;
        public event EventHandler RandomClicked;
    }
}
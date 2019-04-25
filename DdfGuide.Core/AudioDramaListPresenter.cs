using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public class AudioDramaListPresenter : IPresenter<IAudioDramaListView,IEnumerable<AudioDrama>>
    {
        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaExplorer _explorer;
        private readonly IUriInvoker _uriInvoker;
        private readonly IUserDataImportExport _importExport;

        public AudioDramaListPresenter(
            IAudioDramaListView audioDramaListView,
            IAudioDramaExplorer explorer,
            IUriInvoker uriInvoker,
            IUserDataImportExport importExport)
        {
            _audioDramaListView = audioDramaListView;
            _explorer = explorer;
            _uriInvoker = uriInvoker;
            _importExport = importExport;

            _audioDramaListView.OrderByHeardFirstClicked += OnSorterChanged(EAudioDramaSortMode.HeardFirst);
            _audioDramaListView.OrderByHeardLastClicked += OnSorterChanged(EAudioDramaSortMode.HeardLast);
            _audioDramaListView.OrderByIsFavoriteFirstClicked += OnSorterChanged(EAudioDramaSortMode.IsFavoriteFirst);
            _audioDramaListView.OrderByIsFavoriteLastClicked += OnSorterChanged(EAudioDramaSortMode.IsFavoriteLast);
            _audioDramaListView.OrderByNumberAscendingClicked += OnSorterChanged(EAudioDramaSortMode.NumberAscending);
            _audioDramaListView.OrderByNumberDescendingClicked += OnSorterChanged(EAudioDramaSortMode.NumberDescending);
            _audioDramaListView.OrderByReleaseDateAscendingClicked += OnSorterChanged(EAudioDramaSortMode.ReleaseDateAscending);
            _audioDramaListView.OrderByReleaseDateDescendingClicked += OnSorterChanged(EAudioDramaSortMode.ReleaseDateDescending);
            _audioDramaListView.OrderByNameAscendingClicked += OnSorterChanged(EAudioDramaSortMode.NameAscending);
            _audioDramaListView.OrderByNameDescendingClicked += OnSorterChanged(EAudioDramaSortMode.NameDescending);

            _audioDramaListView.AllClicked += OnFilterChanged(EAudioDramaFilterMode.All);
            _audioDramaListView.MainsOnlyClicked += OnFilterChanged(EAudioDramaFilterMode.MainsOnly);
            _audioDramaListView.FavoritesOnlyClicked += OnFilterChanged(EAudioDramaFilterMode.FavoritesOnly);
            _audioDramaListView.UnheardOnlyClicked += OnFilterChanged(EAudioDramaFilterMode.UnheardOnly);
            _audioDramaListView.SpecialsOnlyClicked += OnFilterChanged(EAudioDramaFilterMode.SpecialsOnly);

            _audioDramaListView.DieDreiFragezeichenClicked += OnInterpreterChanged(EAudioDramaFilterMode.DieDreiFragezeichen);
            _audioDramaListView.DieDreiFragezeichenKidsClicked += OnInterpreterChanged(EAudioDramaFilterMode.DieDreiFragezeichenKids);
            _audioDramaListView.DieDreiClicked += OnInterpreterChanged(EAudioDramaFilterMode.DieDrei);

            _audioDramaListView.DonateClicked += (sender, args) => OnDonateClicked();
            _audioDramaListView.ExportClicked += (sender, args) => OnExportClicked();
            _audioDramaListView.ImportClicked += (sender, args) => OnImportClicked();

            _importExport.UserDataImported += (sender, args) => UpdateViewWithMatchingAudioDramas();

            _audioDramaListView.SearchTextChanged += OnSearchTextChanged();
        }

        private void OnImportClicked()
        {
            _importExport.ImportUserData();
        }

        private void OnExportClicked()
        {
            _importExport.ExportUserData();
        }

        private void OnDonateClicked()
        {
            const string paypalMeUrl = @"https://www.paypal.me/selmaohneh";
            var paypalMeUri = new Uri(paypalMeUrl);

            _uriInvoker.Invoke(paypalMeUri);
        }

        private EventHandler OnInterpreterChanged(EAudioDramaFilterMode interpreterFilter)
        {
            return (sender, args) =>
            {
                _explorer.SetInterpreterFilter(interpreterFilter);
                _audioDramaListView.SetSelectedInterpreter(interpreterFilter);
                UpdateViewWithMatchingAudioDramas();
            };
        }

        private EventHandler OnSearchTextChanged()
        {
            return (sender, args) =>
            {
                var searchText = _audioDramaListView.GetCurrentSearchText();
                _explorer.SetSearchText(searchText);
                UpdateViewWithMatchingAudioDramas();
            };
        }

        private EventHandler OnFilterChanged(EAudioDramaFilterMode filterMode)
        {
            return (sender, args) =>
            {
                _explorer.SetFilterMode(filterMode);
                _audioDramaListView.SetFilterInfos(filterMode);
                UpdateViewWithMatchingAudioDramas();
            };
        }

        private EventHandler OnSorterChanged(EAudioDramaSortMode sortMode)
        {
            return (sender, args) =>
            {
               _explorer.SetSortMode(sortMode);
               _audioDramaListView.SetSelectedSortMode(sortMode);
                UpdateViewWithMatchingAudioDramas();
            };
        }

        private void UpdateViewWithMatchingAudioDramas()
        {
            var matchingAudioDramas = _explorer.GetMatchingAudioDramas().ToList();
            _audioDramaListView.SetAudioDramaInfos(matchingAudioDramas);
        }

        public IAudioDramaListView GetView()
        {
            return _audioDramaListView;
        }

        public void UpdateView()
        {
            _audioDramaListView.SetSelectedInterpreter(_explorer.GetCurrentInterpreterFilter());
            _audioDramaListView.SetFilterInfos(_explorer.GetCurrentFilterMode());
            _audioDramaListView.SetSelectedSortMode(_explorer.GetCurrentSortMode());
            UpdateViewWithMatchingAudioDramas();
        }

        public void SetModel(IEnumerable<AudioDrama> model)
        {
            // Todo, move to ctor
            UpdateView();
        }
    }
}

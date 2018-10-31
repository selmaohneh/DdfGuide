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
        
        private IEnumerable<AudioDrama> _audioDramas;

        public AudioDramaListPresenter(
            IAudioDramaListView audioDramaListView,
            IAudioDramaExplorer explorer)
        {
            _audioDramaListView = audioDramaListView;
            _explorer = explorer;

            _audioDramaListView.HeardChanged += OnHeardChanged();
            _audioDramaListView.IsFavoriteChanged += OnIsFavoriteChanged();

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

            _audioDramaListView.SearchTextChanged += OnSearchTextChanged();
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

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { UpdateViewWithMatchingAudioDramas(); };
        }

        private EventHandler<Guid> OnIsFavoriteChanged()
        {
            return (sender, id) =>
            {
                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                audioDrama.AudioDramaUserData.IsFavorite = !audioDrama.AudioDramaUserData.IsFavorite;
            };
        }

        private EventHandler<Guid> OnHeardChanged()
        {
            return (sender, id) =>
            {
                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                audioDrama.AudioDramaUserData.Heard = !audioDrama.AudioDramaUserData.Heard;
            };
        }

        private void UpdateViewWithMatchingAudioDramas()
        {
            var matchingAudioDramas = _explorer.GetMatchingAudioDramas(_audioDramas).ToList();
            _audioDramaListView.SetAudioDramaInfos(matchingAudioDramas);
        }

        public IAudioDramaListView GetView()
        {
            return _audioDramaListView;
        }

        public void SetModel(IEnumerable<AudioDrama> model)
        {
            _audioDramas = model;

            foreach (var audioDrama in _audioDramas)
            {
                audioDrama.AudioDramaUserData.Changed -= OnUserDataChanged();
                audioDrama.AudioDramaUserData.Changed += OnUserDataChanged();
            }

            UpdateViewWithMatchingAudioDramas();

            _audioDramaListView.SetFilterInfos(_explorer.GetCurrentFilterMode());
            _audioDramaListView.SetSelectedSortMode(_explorer.GetCurrentSortMode());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public class AudioDramaListPresenter : IAudioDramaListPresenter
    {
        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;
        private readonly IViewer _viewer;
        private readonly IAudioDramaPresenter _audioDramaPresenter;
        private readonly IAudioDramaExplorer _explorer;
        private readonly IRandomAudioDramaPicker _picker;
        
        private IEnumerable<AudioDrama> _audioDramas;

        public AudioDramaListPresenter(
            IAudioDramaListView audioDramaListView, 
            IAudioDramaView audioDramaView,
            IViewer viewer, 
            IAudioDramaPresenter audioDramaPresenter,
            IAudioDramaExplorer explorer,
            IRandomAudioDramaPicker picker)
        {
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _viewer = viewer;
            _audioDramaPresenter = audioDramaPresenter;
            _explorer = explorer;
            _picker = picker;

            _audioDramaListView.BackClicked += OnBackClicked();

            _audioDramaListView.HeardChanged += OnHeardChanged();
            _audioDramaListView.IsFavoriteChanged += OnIsFavoriteChanged();
            _audioDramaListView.AudioDramaClicked += OnAudioDramaClicked();

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

            _audioDramaListView.RandomClicked += OnRandomClicked();
        }

        private EventHandler OnBackClicked()
        {
            return (sender, args) => { _viewer.ShowLast(); };
        }

        public void SetAudioDramas(IEnumerable<AudioDrama> audioDramas)
        {
            _audioDramas = audioDramas;

            foreach (var audioDrama in _audioDramas)
            {
                audioDrama.AudioDramaUserData.Changed -= OnUserDataChanged();
                audioDrama.AudioDramaUserData.Changed += OnUserDataChanged();
            }
            
            UpdateViewWithMatchingAudioDramas();

            _audioDramaListView.SetFilterInfos(_explorer.GetCurrentFilterMode());
            _audioDramaListView.SetSelectedSortMode(_explorer.GetCurrentSortMode());
        }

        private EventHandler OnRandomClicked()
        {
            return (sender, args) =>
            {
                var matchingAudioDramas = _explorer.GetMatchingAudioDramas(_audioDramas);
                var randomAudioDrama = _picker.Pick(matchingAudioDramas);

                _viewer.Show(_audioDramaView);
                _audioDramaView.SetAudioDrama(randomAudioDrama);
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

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { UpdateViewWithMatchingAudioDramas(); };
        }

        private EventHandler<Guid> OnAudioDramaClicked()
        {
            return (sender, id) =>
            {
                _viewer.Show(_audioDramaView);

                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                _audioDramaPresenter.SetAudioDrama(audioDrama);
            };
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
    }
}

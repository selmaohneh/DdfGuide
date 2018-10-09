using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Searching;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public class AudioDramaListPresenter
    {
        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;
        private readonly IEnumerable<AudioDrama> _audioDramas;
        private readonly IViewer _viewer;
        private readonly IAudioDramaPresenter _audioDramaPresenter;
        private readonly IAudioDramaFilterFactory _audioDramaFilterFactory;
        private readonly IAudioDramaSorterFactory _audioDramaSorterFactory;
        private readonly IAudioDramaSearcher _audioDramaSearcher;

        private IAudioDramaSorter _audioDramaSorter;
        private IAudioDramaFilter _audioDramaFilter;

        public AudioDramaListPresenter(
            IAudioDramaListView audioDramaListView, 
            IAudioDramaView audioDramaView,
            IEnumerable<AudioDrama> audioDramas,
            IViewer viewer, 
            IAudioDramaPresenter audioDramaPresenter,
            IAudioDramaFilterFactory audioDramaFilterFactory,
            IAudioDramaSorterFactory audioDramaSorterFactory,
            IAudioDramaSearcher audioDramaSearcher)
        {
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _audioDramas = audioDramas.ToList();
            _viewer = viewer;
            _audioDramaPresenter = audioDramaPresenter;
            
            _audioDramaSorterFactory = audioDramaSorterFactory;
            _audioDramaSearcher = audioDramaSearcher;
            _audioDramaSorter = _audioDramaSorterFactory.Create(EAudioDramaSortMode.ReleaseDateDescending);

            _audioDramaFilterFactory = audioDramaFilterFactory;
            _audioDramaFilter = _audioDramaFilterFactory.Create(EAudioDramaFilterMode.All);

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

            foreach (var audioDrama in _audioDramas)
            {
                audioDrama.AudioDramaUserData.Changed += OnUserDataChanged();
            }
            
            UpdateView();
        }

        private EventHandler OnSearchTextChanged()
        {
            return (sender, args) =>
            {
                UpdateView();
            };
        }

        private EventHandler OnFilterChanged(EAudioDramaFilterMode filterMode)
        {
            return (sender, args) =>
            {
                _audioDramaFilter = _audioDramaFilterFactory.Create(filterMode);
                UpdateView();
            };
        }

        private EventHandler OnSorterChanged(EAudioDramaSortMode sortMode)
        {
            return (sender, args) =>
            {
                _audioDramaSorter = _audioDramaSorterFactory.Create(sortMode);
                UpdateView();
            };
        }

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { UpdateView(); };
        }

        private EventHandler<Guid> OnAudioDramaClicked()
        {
            return (sender, id) =>
            {
                var audioDrama = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                _audioDramaPresenter.SetAudioDrama(audioDrama);

                _viewer.Show(_audioDramaView);
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

        private void UpdateView()
        {
            var filtered = _audioDramaFilter.Filter(_audioDramas);

            var searchText = _audioDramaListView.GetCurrentSearchText();
            var filteredAndSearched = _audioDramaSearcher.Search(filtered, searchText);

            var filteredAndSearchedAndSorted = _audioDramaSorter.Sort(filteredAndSearched);

            _audioDramaListView.SetAudioDramaInfos(filteredAndSearchedAndSorted);

            _audioDramaListView.SetFilterInfos(_audioDramaFilter.FilterMode);
            _audioDramaListView.SetSelectedSortMode(_audioDramaSorter.SortMode);
        }
    }
}

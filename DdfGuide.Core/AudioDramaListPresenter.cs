using System;
using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class AudioDramaListPresenter
    {
        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;
        private readonly IEnumerable<AudioDrama> _audioDramas;
        private readonly IViewer _viewer;
        private readonly IAudioDramaPresenter _audioDramaPresenter;
        private readonly IAudioDramaFilter _audioDramaFilter;
        private readonly IAudioDramaSorter _audioDramaSorter;

        public AudioDramaListPresenter(
            IAudioDramaListView audioDramaListView, 
            IAudioDramaView audioDramaView,
            IEnumerable<AudioDrama> audioDramas,
            IViewer viewer, 
            IAudioDramaPresenter audioDramaPresenter,
            IAudioDramaFilter audioDramaFilter,
            IAudioDramaSorter audioDramaSorter)
        {
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _audioDramas = audioDramas.ToList();
            _viewer = viewer;
            _audioDramaPresenter = audioDramaPresenter;
            _audioDramaFilter = audioDramaFilter;
            _audioDramaSorter = audioDramaSorter;

            _audioDramaListView.HeardChanged += OnHeardChanged();
            _audioDramaListView.IsFavoriteChanged += OnIsFavoriteChanged();
            _audioDramaListView.AudioDramaClicked += OnAudioDramaClicked();
            _audioDramaListView.OrderByHeardFirstClicked += OnOrderByHeardFirstClicked();
            _audioDramaListView.OrderByHeardLastClicked += OnOrderByHeardLastClicked();
            _audioDramaListView.OrderByIsFavoriteFirstClicked += OnOrderByIsFavoriteFirstClicked();
            _audioDramaListView.OrderByIsFavoriteLastClicked += OnOrderByIsFavoriteLastClicked();
            _audioDramaListView.OrderByNumberAscendingClicked += OnOrderByNumberAscendingClicked();
            _audioDramaListView.OrderByNumberDescendingClicked += OnOrderByNumberDescendingClicked();
            _audioDramaListView.OrderByReleaseDateAscendingClicked += OnOrderByReleaseDateAscendingClicked();
            _audioDramaListView.OrderByReleaseDateDescendingClicked += OnOrderByReleaseDateDescendingClicked();
            _audioDramaListView.OrderByNameAscendingClicked += OnOrderByNameAscendingClicked();
            _audioDramaListView.OrderByNameDescendingClicked += OnOrderByNameDescendingClicked();
            _audioDramaListView.FilterMainAudioDramasChanged += OnFilterMainAudioDramasChanged();

            foreach (var audioDrama in _audioDramas)
            {
                audioDrama.AudioDramaUserData.Changed += OnUserDataChanged();
            }

            UpdateViewFilteredAndSortedAudioDramas();
        }

        private EventHandler OnFilterMainAudioDramasChanged()
        {
            return (sender, args) =>
            {
                _audioDramaFilter.IncludeMainAudioDramas = !_audioDramaFilter.IncludeMainAudioDramas;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByNameDescendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.NameDescending;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByNameAscendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.NameDataAscending;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByReleaseDateDescendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.ReleaseDateDescending;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByReleaseDateAscendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.ReleaseDateAscending;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByNumberDescendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.NumberDescending;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByNumberAscendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.NumberAscending;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByIsFavoriteLastClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.IsFavoriteLast;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByIsFavoriteFirstClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.IsFavoriteFirst;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByHeardLastClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.HeardLast;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnOrderByHeardFirstClicked()
        {
            return (sender, args) =>
            {
                _audioDramaSorter.SortMode = EAudioDramaSortMode.HeardFirst;
                UpdateViewFilteredAndSortedAudioDramas();
            };
        }

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { UpdateViewFilteredAndSortedAudioDramas(); };
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

        private void UpdateViewFilteredAndSortedAudioDramas()
        {
            var filtered = _audioDramaFilter.Filter(_audioDramas);
            var filteredAndSorted = _audioDramaSorter.Sort(filtered);

            _audioDramaListView.SetAudioDramas(filteredAndSorted);
        }
    }
}

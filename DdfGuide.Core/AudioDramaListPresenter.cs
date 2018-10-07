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
        private IEnumerable<AudioDrama> _filteredAndSortedAudioDramas;
        private readonly IViewer _viewer;
        private readonly IAudioDramaPresenter _audioDramaPresenter;

        public AudioDramaListPresenter(
            IAudioDramaListView audioDramaListView, 
            IAudioDramaView audioDramaView,
            IEnumerable<AudioDrama> audioDramas,
            IViewer viewer, 
            IAudioDramaPresenter audioDramaPresenter)
        {
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
            _audioDramas = audioDramas.ToList();
            _viewer = viewer;
            _audioDramaPresenter = audioDramaPresenter;

            _filteredAndSortedAudioDramas = _audioDramas;

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
            _audioDramaListView.FilterMainAudioDramasOnlyClicked += OnFilterMainAudioDramasOnlyClicked();
            _audioDramaListView.FilterAllClicked += OnFilterAllClicked();

            foreach (var audioDrama in _audioDramas)
            {
                audioDrama.AudioDramaUserData.Changed += OnUserDataChanged();
            }

            _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
        }

        private EventHandler OnFilterAllClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.Concat(_audioDramas).Distinct();
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnFilterMainAudioDramasOnlyClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.Where(x => x.AudioDramaDto.Number.HasValue);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByNameDescendingClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderByDescending(x => x.AudioDramaDto.Name);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByNameAscendingClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderBy(x => x.AudioDramaDto.Name);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByReleaseDateDescendingClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderByDescending(x => x.AudioDramaDto.ReleaseDate);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByReleaseDateAscendingClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderBy(x => x.AudioDramaDto.ReleaseDate);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByNumberDescendingClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderByDescending(x => x.AudioDramaDto.Number);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByNumberAscendingClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderBy(x => x.AudioDramaDto.Number);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByIsFavoriteLastClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderBy(x => x.AudioDramaUserData.IsFavorite);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByIsFavoriteFirstClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderByDescending(x => x.AudioDramaUserData.IsFavorite);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByHeardLastClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderBy(x => x.AudioDramaUserData.Heard);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnOrderByHeardFirstClicked()
        {
            return (sender, args) =>
            {
                _filteredAndSortedAudioDramas = _filteredAndSortedAudioDramas.OrderByDescending(x => x.AudioDramaUserData.Heard);
                _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas);
            };
        }

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { _audioDramaListView.SetAudioDramas(_filteredAndSortedAudioDramas); };
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
    }
}

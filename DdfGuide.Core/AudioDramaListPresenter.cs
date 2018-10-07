using System;
using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class AudioDramaListPresenter
    {
        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;
        private IEnumerable<AudioDrama> _audioDramas;
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

            _audioDramaListView.SetAudioDramas(_audioDramas);
        }

        private EventHandler OnFilterAllClicked()
        {
            return (sender, args) =>
            {
                _audioDramaListView.SetAudioDramas(_audioDramas);
            };
        }

        private EventHandler OnFilterMainAudioDramasOnlyClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.Where(x => x.AudioDramaDto.Number.HasValue);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByNameDescendingClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaDto.Name);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByNameAscendingClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderBy(x => x.AudioDramaDto.Name);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByReleaseDateDescendingClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaDto.ReleaseDate);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByReleaseDateAscendingClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderBy(x => x.AudioDramaDto.ReleaseDate);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByNumberDescendingClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaDto.Number);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByNumberAscendingClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderBy(x => x.AudioDramaDto.Number);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByIsFavoriteLastClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderBy(x => x.AudioDramaUserData.IsFavorite);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByIsFavoriteFirstClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaUserData.IsFavorite);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByHeardLastClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderBy(x => x.AudioDramaUserData.Heard);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnOrderByHeardFirstClicked()
        {
            return (sender, args) =>
            {
                var audioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaUserData.Heard);
                _audioDramaListView.SetAudioDramas(audioDramas);
            };
        }

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { _audioDramaListView.SetAudioDramas(_audioDramas); };
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

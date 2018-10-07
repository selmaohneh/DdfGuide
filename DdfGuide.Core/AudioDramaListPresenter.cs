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
            _audioDramas = audioDramas;
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

            foreach (var audioDrama in _audioDramas)
            {
                audioDrama.AudioDramaUserData.Changed += OnUserDataChanged();
            }

            UpdateViewWithCurrentAudioDramas();
        }

        private EventHandler OnOrderByReleaseDateDescendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaDto.ReleaseDate);
                UpdateViewWithCurrentAudioDramas();
            };
        }

        private EventHandler OnOrderByReleaseDateAscendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramas = _audioDramas.OrderBy(x => x.AudioDramaDto.ReleaseDate);
                UpdateViewWithCurrentAudioDramas();
            };
        }

        private EventHandler OnOrderByNumberDescendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaDto.Number);
                UpdateViewWithCurrentAudioDramas();
            };
        }

        private EventHandler OnOrderByNumberAscendingClicked()
        {
            return (sender, args) =>
            {
                _audioDramas = _audioDramas.OrderBy(x => x.AudioDramaDto.Number);
                UpdateViewWithCurrentAudioDramas();
            };
        }

        private EventHandler OnOrderByIsFavoriteLastClicked()
        {
            return (sender, args) =>
            {
                _audioDramas = _audioDramas.OrderBy(x => x.AudioDramaUserData.IsFavorite);
                UpdateViewWithCurrentAudioDramas();
            };
        }

        private EventHandler OnOrderByIsFavoriteFirstClicked()
        {
            return (sender, args) =>
            {
                _audioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaUserData.IsFavorite);
                UpdateViewWithCurrentAudioDramas();
            };
        }

        private EventHandler OnOrderByHeardLastClicked()
        {
            return (sender, args) =>
            {
                _audioDramas = _audioDramas.OrderBy(x => x.AudioDramaUserData.Heard);
                UpdateViewWithCurrentAudioDramas();
            };
        }

        private EventHandler OnOrderByHeardFirstClicked()
        {
            return (sender, args) =>
            {
                _audioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaUserData.Heard);
                UpdateViewWithCurrentAudioDramas();
            };
        }

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { UpdateViewWithCurrentAudioDramas(); };
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
                var audioDrama1 = _audioDramas.Single(x => x.AudioDramaDto.Id == id);
                audioDrama1.AudioDramaUserData.IsFavorite = !audioDrama1.AudioDramaUserData.IsFavorite;
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



        private void UpdateViewWithCurrentAudioDramas()
        {
            _audioDramaListView.SetAudioDramas(_audioDramas);
        }
    }
}

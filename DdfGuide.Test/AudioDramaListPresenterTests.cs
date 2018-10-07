using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaListPresenterTests
    {
        private Mock<IAudioDramaListView> _listView;
        private Mock<IAudioDramaView> _view;
        private MultipleAudioDramaProvider _audioDramaProvider;
        private Mock<IViewer> _viewer;
        private Mock<IAudioDramaPresenter> _audioDramaPresenter;
        private List<AudioDrama> _audioDramas;
        private AudioDramaListPresenter _sut;

        [TestInitialize]
        public void Init()
        {
            _audioDramaProvider = new MultipleAudioDramaProvider();
            _audioDramas = _audioDramaProvider.Get().ToList();

            _listView = new Mock<IAudioDramaListView>();
            _view = new Mock<IAudioDramaView>();
            _viewer = new Mock<IViewer>();
            _audioDramaPresenter = new Mock<IAudioDramaPresenter>();

            _sut = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                _audioDramas,
                _viewer.Object,
                _audioDramaPresenter.Object
            );
        }
        

        [TestMethod]
        public void Construct_FillWithAudioDramas()
        {
            _listView.Verify(x => x.SetAudioDramas(_audioDramas), Times.Once);
        }

        [TestMethod]
        public void HeardChanged_UpdateModel()
        {
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.Heard);

            _listView.Raise(x => x.HeardChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsTrue(_audioDramas.First().AudioDramaUserData.Heard);

            _listView.Raise(x => x.HeardChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardChanged_UpdateView()
        {
            _listView.Invocations.Clear();

            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.Heard);
            _listView.Raise(x => x.HeardChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);

            _listView.Verify(
                x => x.SetAudioDramas(It.Is<IEnumerable<AudioDrama>>(y => y.First().AudioDramaUserData.Heard)),
                Times.Once);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateModel()
        {
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.IsFavorite);

            _listView.Raise(x => x.IsFavoriteChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsTrue(_audioDramas.First().AudioDramaUserData.IsFavorite);

            _listView.Raise(x => x.IsFavoriteChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateView()
        {
            _listView.Invocations.Clear();

            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.IsFavorite);
            _listView.Raise(x => x.IsFavoriteChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);

            _listView.Verify(
                x => x.SetAudioDramas(It.Is<IEnumerable<AudioDrama>>(y => y.First().AudioDramaUserData.IsFavorite)),
                Times.Once);
        }

        [TestMethod]
        public void AudioDramaClicked_OpenAudioDramaView()
        {
            _listView.Raise(x => x.AudioDramaClicked += null, this, _audioDramas.First().AudioDramaDto.Id);
            
            _viewer.Verify(x => x.Show(_view.Object), Times.Once);
        }

        [TestMethod]
        public void UserDataChanged_UpdateView()
        {
            _listView.Invocations.Clear();

            _listView.Verify(x => x.SetAudioDramas(_audioDramas), Times.Never);

            _audioDramas.First().AudioDramaUserData.Heard = !_audioDramas.First().AudioDramaUserData.Heard;
            _listView.Verify(x => x.SetAudioDramas(_audioDramas), Times.Once);

            _audioDramas.First().AudioDramaUserData.IsFavorite = !_audioDramas.First().AudioDramaUserData.IsFavorite;
            _listView.Verify(x => x.SetAudioDramas(_audioDramas), Times.Exactly(2));
        }

        [TestMethod]
        public void OrderByHeardFirstClicked_UpdateView()
        {
            _listView.Raise(x => x.OrderByHeardFirstClicked += null, this, EventArgs.Empty);

            var orderedAudioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaUserData.Heard);

            _listView.Verify(x => x.SetAudioDramas(orderedAudioDramas), Times.Once());
        }

        [TestMethod]
        public void OrderByHeardLastClicked_UpdateView()
        {
            _listView.Invocations.Clear();

            _listView.Raise(x => x.OrderByHeardLastClicked += null, this, EventArgs.Empty);

            var orderedAudioDramas = _audioDramas.OrderBy(x => x.AudioDramaUserData.Heard);

            _listView.Verify(x => x.SetAudioDramas(orderedAudioDramas), Times.Once());
        }

        [TestMethod]
        public void OrderByIsFavoriteFirstClicked_UpdateView()
        {
            _listView.Raise(x => x.OrderByIsFavoriteFirstClicked += null, this, EventArgs.Empty);

            var orderedAudioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaUserData.IsFavorite);

            _listView.Verify(x => x.SetAudioDramas(orderedAudioDramas), Times.Once());
        }

        [TestMethod]
        public void OrderIsFavoriteLastClicked_UpdateView()
        {
            _listView.Raise(x => x.OrderByIsFavoriteLastClicked += null, this, EventArgs.Empty);

            var orderedAudioDramas = _audioDramas.OrderBy(x => x.AudioDramaUserData.IsFavorite);

            _listView.Verify(x => x.SetAudioDramas(orderedAudioDramas), Times.Once());
        }

        [TestMethod]
        public void OrderByNumberAscendingClicked_UpdateView()
        {
            _listView.Raise(x => x.OrderByNumberAscendingClicked += null, this, EventArgs.Empty);

            var orderedAudioDramas = _audioDramas.OrderBy(x => x.AudioDramaDto.Number);

            _listView.Verify(x => x.SetAudioDramas(orderedAudioDramas), Times.Once());
        }

        [TestMethod]
        public void OrderByNumberDescendingClicked_UpdateView()
        {
            _listView.Raise(x => x.OrderByNumberDescendingClicked += null, this, EventArgs.Empty);

            var orderedAudioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaDto.Number);

            _listView.Verify(x => x.SetAudioDramas(orderedAudioDramas), Times.Once());
        }

        [TestMethod]
        public void OrderByReleaseDateAscendingClicked_UpdateView()
        {
            _listView.Raise(x => x.OrderByReleaseDateAscendingClicked += null, this, EventArgs.Empty);

            var orderedAudioDramas = _audioDramas.OrderBy(x => x.AudioDramaDto.ReleaseDate);

            _listView.Verify(x => x.SetAudioDramas(orderedAudioDramas), Times.Once());
        }

        [TestMethod]
        public void OrderByReleaseDateDescendingClicked_UpdateView()
        {
            _listView.Raise(x => x.OrderByReleaseDateDescendingClicked += null, this, EventArgs.Empty);

            var orderedAudioDramas = _audioDramas.OrderByDescending(x => x.AudioDramaDto.ReleaseDate);

            _listView.Verify(x => x.SetAudioDramas(orderedAudioDramas), Times.Once());
        }
    }
}

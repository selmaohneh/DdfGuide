using System;
using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Models;
using DdfGuide.Core.Presenters;
using DdfGuide.Core.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaViewPresenterTests
    {
        private Mock<IAudioDramaView> _view;
        private SingleAudioDramaProvider _singleAudioDramaProvider;
        private Mock<IViewer> _viewer;

        [TestInitialize]
        public void Init()
        {
            _singleAudioDramaProvider = new SingleAudioDramaProvider();

            _view = new Mock<IAudioDramaView>();
            _viewer = new Mock<IViewer>();
        }


        [TestMethod]
        public void Construct_FillWithAudioDrama()
        {
            var model = _singleAudioDramaProvider.Get().First();

            var _ = new AudioDramaViewPresenter(
                _view.Object,
                model,
                _viewer.Object);

            _view.Verify(x => x.SetAudioDrama(model), Times.Once);
        }

        [TestMethod]
        public void HeardChanged_UpdateModel()
        {
            var model = _singleAudioDramaProvider.Get().First();

            var _ = new AudioDramaViewPresenter(
                _view.Object,
                model,
                _viewer.Object);

            Assert.IsFalse(model.AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, this, EventArgs.Empty);
            Assert.IsTrue(model.AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, EventArgs.Empty);
            Assert.IsFalse(model.AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardChanged_UpdateView()
        {
            var model = _singleAudioDramaProvider.Get().First();

            var _ = new AudioDramaViewPresenter(
                _view.Object,
                model,
                _viewer.Object);

            _view.Invocations.Clear();

            Assert.IsFalse(model.AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, EventArgs.Empty);

            _view.Verify(
                x => x.SetAudioDrama(It.Is<AudioDrama>(y => y.AudioDramaUserData.Heard)),
                Times.Once);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateModel()
        {
            var model = _singleAudioDramaProvider.Get().First();

            var _ = new AudioDramaViewPresenter(
                _view.Object,
                model,
                _viewer.Object);

            Assert.IsFalse(model.AudioDramaUserData.IsFavorite);
            _view.Raise(x => x.IsFavoriteChanged += null, EventArgs.Empty);
            Assert.IsTrue(model.AudioDramaUserData.IsFavorite);
            _view.Raise(x => x.IsFavoriteChanged += null, EventArgs.Empty);
            Assert.IsFalse(model.AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateView()
        {
            var model = _singleAudioDramaProvider.Get().First();

            var _ = new AudioDramaViewPresenter(
                _view.Object,
                model,
                _viewer.Object);

            _view.Invocations.Clear();

            Assert.IsFalse(model.AudioDramaUserData.IsFavorite);
            _view.Raise(x => x.IsFavoriteChanged += null, EventArgs.Empty);

            _view.Verify(
                x => x.SetAudioDrama(It.Is<AudioDrama>(y => y.AudioDramaUserData.IsFavorite)),
                Times.Once);
        }

        [TestMethod]
        public void BackClicked_ShowLastView()
        {
            var model = _singleAudioDramaProvider.Get().First();

            var _ = new AudioDramaViewPresenter(
                _view.Object,
                model,
                _viewer.Object);

            _view.Raise(x => x.BackClicked += null, this, EventArgs.Empty);

            _viewer.Verify(x => x.ShowLast(), Times.Once);
        }
    }
}

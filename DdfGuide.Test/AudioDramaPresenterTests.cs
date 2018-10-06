using System;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaPresenterTests
    {
        private Mock<IAudioDramaView> _view;
        private SingleAudioDramaProvider _singleAudioDramaProvider;
        private Mock<IViewer> _viewer;
        private AudioDrama _audioDrama;
        private AudioDramaPresenter _sut;

        [TestInitialize]
        public void Init()
        {
            _singleAudioDramaProvider = new SingleAudioDramaProvider();

            _view = new Mock<IAudioDramaView>();
            _viewer = new Mock<IViewer>();

            _audioDrama = _singleAudioDramaProvider.Get().First();

            _sut = new AudioDramaPresenter(
                _view.Object,
                _viewer.Object);

            _sut.SetAudioDrama(_audioDrama);

        }

        [TestMethod]
        public void HeardChanged_UpdateModel()
        {
            Assert.IsFalse(_audioDrama.AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, this, EventArgs.Empty);
            Assert.IsTrue(_audioDrama.AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, EventArgs.Empty);
            Assert.IsFalse(_audioDrama.AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardChanged_UpdateView()
        {
            _view.Invocations.Clear();

            Assert.IsFalse(_audioDrama.AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, EventArgs.Empty);

            _view.Verify(
                x => x.SetAudioDrama(It.Is<AudioDrama>(y => y.AudioDramaUserData.Heard)),
                Times.Once);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateModel()
        {
            Assert.IsFalse(_audioDrama.AudioDramaUserData.IsFavorite);
            _view.Raise(x => x.IsFavoriteChanged += null, EventArgs.Empty);
            Assert.IsTrue(_audioDrama.AudioDramaUserData.IsFavorite);
            _view.Raise(x => x.IsFavoriteChanged += null, EventArgs.Empty);
            Assert.IsFalse(_audioDrama.AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateView()
        {
            _view.Invocations.Clear();

            Assert.IsFalse(_audioDrama.AudioDramaUserData.IsFavorite);
            _view.Raise(x => x.IsFavoriteChanged += null, EventArgs.Empty);

            _view.Verify(
                x => x.SetAudioDrama(It.Is<AudioDrama>(y => y.AudioDramaUserData.IsFavorite)),
                Times.Once);
        }

        [TestMethod]
        public void BackClicked_ShowLastView()
        {
            _view.Raise(x => x.BackClicked += null, this, EventArgs.Empty);

            _viewer.Verify(x => x.ShowLast(), Times.Once);
        }

        [TestMethod]
        public void UserDataChanged_UpdateView()
        {
            _view.Invocations.Clear();

            _view.Verify(x=>x.SetAudioDrama(_audioDrama), Times.Never);

            _audioDrama.AudioDramaUserData.Heard = !_audioDrama.AudioDramaUserData.Heard;
            _view.Verify(x => x.SetAudioDrama(_audioDrama), Times.Once);

            _audioDrama.AudioDramaUserData.IsFavorite = !_audioDrama.AudioDramaUserData.IsFavorite;
            _view.Verify(x => x.SetAudioDrama(_audioDrama), Times.Exactly(2));
        }

        [TestMethod]
        public void SetNewModelMultipleTimes_DontRaiseEventsMultipleTimes()
        {
            _sut.SetAudioDrama(_audioDrama);
            _sut.SetAudioDrama(_audioDrama);
            _sut.SetAudioDrama(_audioDrama);
            _sut.SetAudioDrama(_audioDrama);

            _view.Invocations.Clear();

            Assert.IsFalse(_audioDrama.AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, null, EventArgs.Empty);
            Assert.IsTrue(_audioDrama.AudioDramaUserData.Heard);

            _view.Verify(x => x.SetAudioDrama(It.IsAny<AudioDrama>()), Times.Once());
        }
    }
}

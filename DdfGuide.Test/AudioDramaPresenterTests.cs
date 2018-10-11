using System;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaPresenterTests
    {
        private SampleAudioDramaProvider _sampleAudioDramaProvider;
        private AudioDrama _audioDrama;
        private AudioDramaPresenter _sut;
        private AutoMocker _mocker;

        [TestInitialize]
        public void Init()
        {
            _sampleAudioDramaProvider = new SampleAudioDramaProvider();
            _audioDrama = _sampleAudioDramaProvider.Get().First();

            _mocker = new AutoMocker();
            _sut = _mocker.CreateInstance<AudioDramaPresenter>();

            _sut.SetAudioDrama(_audioDrama);

        }

        [TestMethod]
        public void HeardChangedOnView_UpdateModel()
        {
            var view = _mocker.GetMock<IAudioDramaView>();

            Assert.IsFalse(_audioDrama.AudioDramaUserData.Heard);

            view.Raise(x => x.HeardChanged += null, this, EventArgs.Empty);
            Assert.IsTrue(_audioDrama.AudioDramaUserData.Heard);

            view.Raise(x => x.HeardChanged += null, EventArgs.Empty);
            Assert.IsFalse(_audioDrama.AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardChangedOnModel_UpdateViewWithAudioDrama()
        {
            var view = _mocker.GetMock<IAudioDramaView>();
            view.Invocations.Clear();

            var currentValue = _audioDrama.AudioDramaUserData.Heard;
            _audioDrama.AudioDramaUserData.Heard = !currentValue;

            view.Verify(
                x => x.SetAudioDrama(It.IsAny<AudioDrama>()),
                Times.Once);
        }

        [TestMethod]
        public void IsFavoriteChangedOnView_UpdateModel()
        {
            var view = _mocker.GetMock<IAudioDramaView>();

            Assert.IsFalse(_audioDrama.AudioDramaUserData.IsFavorite);

            view.Raise(x => x.IsFavoriteChanged += null, EventArgs.Empty);
            Assert.IsTrue(_audioDrama.AudioDramaUserData.IsFavorite);

            view.Raise(x => x.IsFavoriteChanged += null, EventArgs.Empty);
            Assert.IsFalse(_audioDrama.AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteChangedOnModel_UpdateViewWithAudioDrama()
        {
            var view = _mocker.GetMock<IAudioDramaView>();
            view.Invocations.Clear();

            var currentValue = _audioDrama.AudioDramaUserData.IsFavorite;
            _audioDrama.AudioDramaUserData.IsFavorite = !currentValue;

            view.Verify(
                x => x.SetAudioDrama(It.IsAny<AudioDrama>()),
                Times.Once);
        }

        [TestMethod]
        public void BackClicked_ShowLastView()
        {
            var view = _mocker.GetMock<IAudioDramaView>();
            var viewer = _mocker.GetMock<IViewer>();

            view.Raise(x => x.BackClicked += null, this, EventArgs.Empty);

            viewer.Verify(x => x.ShowLast(), Times.Once);
        }

        [TestMethod]
        public void SetNewModelMultipleTimes_DontRaiseEventsMultipleTimes()
        {
            var view = _mocker.GetMock<IAudioDramaView>();

            _sut.SetAudioDrama(_audioDrama);
            _sut.SetAudioDrama(_audioDrama);
            _sut.SetAudioDrama(_audioDrama);
            _sut.SetAudioDrama(_audioDrama);

            view.Invocations.Clear();
            
            view.Raise(x => x.HeardChanged += null, null, EventArgs.Empty);

            view.Verify(x => x.SetAudioDrama(It.IsAny<AudioDrama>()), Times.Once());
        }
    }
}

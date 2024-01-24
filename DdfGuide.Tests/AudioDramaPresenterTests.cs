using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;

namespace DdfGuide.Tests
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

            _sut.SetModel(_audioDrama);
        }

        [TestMethod]
        public void UserClickedPlay_InvokeSpotifyUri()
        {
            var view = _mocker.GetMock<IAudioDramaView>();
            var invoker = _mocker.GetMock<IUriInvoker>();

            view.Raise(x => x.PlayClicked += null, this, EventArgs.Empty);

            invoker.Verify(x => x.Invoke(_audioDrama.AudioDramaDto.SpotifyUri));
        }

        [TestMethod]
        public void UserClickedBuy_InvokeAmazonBuyUri()
        {
            var view = _mocker.GetMock<IAudioDramaView>();
            var invoker = _mocker.GetMock<IUriInvoker>();

            view.Raise(x => x.BuyClicked += null, this, EventArgs.Empty);

            invoker.Verify(x => x.Invoke(_audioDrama.AudioDramaDto.AmazonBuyUri));
        }

        [TestMethod]
        public void HeardChangedOnView_UpdateModel()
        {
            var view = _mocker.GetMock<IAudioDramaView>();

            Assert.IsFalse(_audioDrama.AudioDramaUserData.Heard);

            view.Raise(x => x.HeardClicked += null, this, EventArgs.Empty);
            Assert.IsTrue(_audioDrama.AudioDramaUserData.Heard);

            view.Raise(x => x.HeardClicked += null, EventArgs.Empty);
            Assert.IsFalse(_audioDrama.AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardChangedOnModel_UpdateViewWithAudioDrama()
        {
            var view = _mocker.GetMock<IAudioDramaView>();
            view.Invocations.Clear();

            var currentValue = _audioDrama.AudioDramaUserData.Heard;
            _audioDrama.AudioDramaUserData.Heard = !currentValue;

            view.Verify(x => x.SetAudioDrama(It.IsAny<AudioDrama>()),
                        Times.Once);
        }

        [TestMethod]
        public void IsFavoriteChangedOnView_UpdateModel()
        {
            var view = _mocker.GetMock<IAudioDramaView>();

            Assert.IsFalse(_audioDrama.AudioDramaUserData.IsFavorite);

            view.Raise(x => x.IsFavoriteClicked += null, EventArgs.Empty);
            Assert.IsTrue(_audioDrama.AudioDramaUserData.IsFavorite);

            view.Raise(x => x.IsFavoriteClicked += null, EventArgs.Empty);
            Assert.IsFalse(_audioDrama.AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteChangedOnModel_UpdateViewWithAudioDrama()
        {
            var view = _mocker.GetMock<IAudioDramaView>();
            view.Invocations.Clear();

            var currentValue = _audioDrama.AudioDramaUserData.IsFavorite;
            _audioDrama.AudioDramaUserData.IsFavorite = !currentValue;

            view.Verify(x => x.SetAudioDrama(It.IsAny<AudioDrama>()),
                        Times.Once);
        }

        [TestMethod]
        public void SetNewModelMultipleTimes_DontRaiseEventsMultipleTimes()
        {
            var view = _mocker.GetMock<IAudioDramaView>();

            _sut.SetModel(_audioDrama);
            _sut.SetModel(_audioDrama);
            _sut.SetModel(_audioDrama);
            _sut.SetModel(_audioDrama);

            view.Invocations.Clear();

            view.Raise(x => x.HeardClicked += null, null, EventArgs.Empty);

            view.Verify(x => x.SetAudioDrama(It.IsAny<AudioDrama>()), Times.Once());
        }
    }
}
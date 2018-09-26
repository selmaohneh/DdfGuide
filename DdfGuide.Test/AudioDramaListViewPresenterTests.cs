using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaListViewPresenterTests
    {
        private Mock<IAudioDramaListView> _view;
        private SingleAudioDramaProvider _singleAudioDramaProvider;
        private MultipleAudioDramaProvider _multipleAudioDramaProvider;

        [TestInitialize]
        public void Init()
        {
            _singleAudioDramaProvider = new SingleAudioDramaProvider();
            _multipleAudioDramaProvider = new MultipleAudioDramaProvider();

            _view = new Mock<IAudioDramaListView>();
        }
        

        [TestMethod]
        public void Construct_FillWithAudioDramas()
        {
            var model = _multipleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListViewPresenter(
                _view.Object,
                model);

            _view.Verify(x => x.SetAudioDramas(model), Times.Once);
        }

        [TestMethod]
        public void HeardChanged_UpdateModel()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListViewPresenter(
                _view.Object,
                model);

            Assert.IsFalse(model.First().AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, this, model.First().AudioDramaUserData.Id);
            Assert.IsTrue(model.First().AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, this, model.First().AudioDramaUserData.Id);
            Assert.IsFalse(model.First().AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardChanged_UpdateView()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListViewPresenter(
                _view.Object,
                model);

            _view.Invocations.Clear();

            Assert.IsFalse(model.First().AudioDramaUserData.Heard);
            _view.Raise(x => x.HeardChanged += null, this, model.First().AudioDramaUserData.Id);

            _view.Verify(
                x => x.SetAudioDramas(It.Is<IEnumerable<AudioDrama>>(y => y.First().AudioDramaUserData.Heard)),
                Times.Once);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateModel()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListViewPresenter(
                _view.Object,
                model);

            Assert.IsFalse(model.First().AudioDramaUserData.IsFavorite);
            _view.Raise(x => x.IsFavoriteChanged += null, this, model.First().AudioDramaUserData.Id);
            Assert.IsTrue(model.First().AudioDramaUserData.IsFavorite);
            _view.Raise(x => x.IsFavoriteChanged += null, this, model.First().AudioDramaUserData.Id);
            Assert.IsFalse(model.First().AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateView()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListViewPresenter(
                _view.Object,
                model);

            _view.Invocations.Clear();

            Assert.IsFalse(model.First().AudioDramaUserData.IsFavorite);
            _view.Raise(x => x.IsFavoriteChanged += null, this, model.First().AudioDramaUserData.Id);

            _view.Verify(
                x => x.SetAudioDramas(It.Is<IEnumerable<AudioDrama>>(y => y.First().AudioDramaUserData.IsFavorite)),
                Times.Once);
        }

        [TestMethod]
        public void AudioDramaClicked_OpenAudioDramaView()
        {
            //_view.Raise(x => x.AudioDramaClicked += null, this,_model.First().AudioDramaDto.Id);
        }
    }
}

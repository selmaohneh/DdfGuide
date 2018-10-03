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
        private SingleAudioDramaProvider _singleAudioDramaProvider;
        private MultipleAudioDramaProvider _multipleAudioDramaProvider;
        private Mock<IViewer> _viewer;
        private Mock<IAudioDramaPresenter> _audioDramaPresenter;

        [TestInitialize]
        public void Init()
        {
            _singleAudioDramaProvider = new SingleAudioDramaProvider();
            _multipleAudioDramaProvider = new MultipleAudioDramaProvider();

            _listView = new Mock<IAudioDramaListView>();
            _view = new Mock<IAudioDramaView>();
            _viewer = new Mock<IViewer>();
            _audioDramaPresenter = new Mock<IAudioDramaPresenter>();
        }
        

        [TestMethod]
        public void Construct_FillWithAudioDramas()
        {
            var model = _multipleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                model,
                _viewer.Object,
                _audioDramaPresenter.Object
                );

            _listView.Verify(x => x.SetAudioDramas(model), Times.Once);
        }

        [TestMethod]
        public void HeardChanged_UpdateModel()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                model,
                _viewer.Object,
                _audioDramaPresenter.Object);

            Assert.IsFalse(model.First().AudioDramaUserData.Heard);
            _listView.Raise(x => x.HeardChanged += null, this, model.First().AudioDramaUserData.Id);
            Assert.IsTrue(model.First().AudioDramaUserData.Heard);
            _listView.Raise(x => x.HeardChanged += null, this, model.First().AudioDramaUserData.Id);
            Assert.IsFalse(model.First().AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardChanged_UpdateView()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                model,
                _viewer.Object,
                _audioDramaPresenter.Object);

            _listView.Invocations.Clear();

            Assert.IsFalse(model.First().AudioDramaUserData.Heard);
            _listView.Raise(x => x.HeardChanged += null, this, model.First().AudioDramaUserData.Id);

            _listView.Verify(
                x => x.SetAudioDramas(It.Is<IEnumerable<AudioDrama>>(y => y.First().AudioDramaUserData.Heard)),
                Times.Once);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateModel()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                model,
                _viewer.Object,
                _audioDramaPresenter.Object);

            Assert.IsFalse(model.First().AudioDramaUserData.IsFavorite);
            _listView.Raise(x => x.IsFavoriteChanged += null, this, model.First().AudioDramaUserData.Id);
            Assert.IsTrue(model.First().AudioDramaUserData.IsFavorite);
            _listView.Raise(x => x.IsFavoriteChanged += null, this, model.First().AudioDramaUserData.Id);
            Assert.IsFalse(model.First().AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateView()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                model,
                _viewer.Object,
                _audioDramaPresenter.Object);

            _listView.Invocations.Clear();

            Assert.IsFalse(model.First().AudioDramaUserData.IsFavorite);
            _listView.Raise(x => x.IsFavoriteChanged += null, this, model.First().AudioDramaUserData.Id);

            _listView.Verify(
                x => x.SetAudioDramas(It.Is<IEnumerable<AudioDrama>>(y => y.First().AudioDramaUserData.IsFavorite)),
                Times.Once);
        }

        [TestMethod]
        public void AudioDramaClicked_OpenAudioDramaView()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                model,
                _viewer.Object,
                _audioDramaPresenter.Object);

            _listView.Raise(x => x.AudioDramaClicked += null, this, model.First().AudioDramaDto.Id);
            
            _viewer.Verify(x => x.Show(_view.Object), Times.Once);
        }

        [TestMethod]
        public void UserDataChanged_UpdateView()
        {
            var model = _singleAudioDramaProvider.Get().ToList();

            var _ = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                model,
                _viewer.Object,
                _audioDramaPresenter.Object);

            _listView.Invocations.Clear();

            _listView.Verify(x => x.SetAudioDramas(model), Times.Never);

            model.First().AudioDramaUserData.Heard = !model.First().AudioDramaUserData.Heard;
            _listView.Verify(x => x.SetAudioDramas(model), Times.Once);

            model.First().AudioDramaUserData.IsFavorite = !model.First().AudioDramaUserData.IsFavorite;
            _listView.Verify(x => x.SetAudioDramas(model), Times.Exactly(2));
        }
    }
}

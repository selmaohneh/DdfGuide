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
        private IEnumerable<AudioDrama> _model;

        [TestInitialize]
        public void Init()
        {
            var audioDramaProvider = new AudioDramaProvider();

            _view = new Mock<IAudioDramaListView>();
            _model = audioDramaProvider.Get();

            var _ = new AudioDramaListViewPresenter(
                _view.Object,
                _model);
        }
        

        [TestMethod]
        public void Construct_FillWithAudioDramas()
        {
            _view.Verify(x => x.SetAudioDramas(_model), Times.Once);
        }

        [TestMethod]
        public void HeardChanged_UpdateModel()
        {
            Assert.IsTrue(_model.First().AudioDramaUserData.Heard);
            Assert.IsFalse(_model.Last().AudioDramaUserData.Heard);

            _view.Raise(x => x.HeardChanged += null, this, _model.First().AudioDramaUserData.Id);
            _view.Raise(x => x.HeardChanged += null, this, _model.Last().AudioDramaUserData.Id);

            Assert.IsFalse(_model.First().AudioDramaUserData.Heard);
            Assert.IsTrue(_model.Last().AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateModel()
        {
            Assert.IsTrue(_model.First().AudioDramaUserData.IsFavorite);
            Assert.IsFalse(_model.Last().AudioDramaUserData.IsFavorite);

            _view.Raise(x => x.IsFavoriteChanged += null, this, _model.First().AudioDramaUserData.Id);
            _view.Raise(x => x.IsFavoriteChanged += null, this, _model.Last().AudioDramaUserData.Id);

            Assert.IsFalse(_model.First().AudioDramaUserData.IsFavorite);
            Assert.IsTrue(_model.Last().AudioDramaUserData.IsFavorite);
        }
    }
}

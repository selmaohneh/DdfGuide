using System.Collections.Generic;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaListViewPresenterTests
    {
        private Mock<IAudioDramaListView> _view;
        private Mock<IEnumerable<AudioDrama>> _model;

        [TestInitialize]
        public void Init()
        {
            _view = new Mock<IAudioDramaListView>();
            _model = new Mock<IEnumerable<AudioDrama>>();
            var _ = new AudioDramaListViewPresenter(_view.Object, _model.Object);
        }
        

        [TestMethod]
        public void Construct_FillWithAudioDramas()
        {
            _view.Verify(x => x.SetAudioDramas(_model.Object), Times.Once);
        }
    }
}

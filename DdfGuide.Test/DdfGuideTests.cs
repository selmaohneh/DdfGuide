using System.Collections.Generic;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class DdfGuideTests
    {
        private Core.DdfGuide _systemUnderTest;

        private Mock<IAudioDramaListView> _view;
        private Mock<IProvider<IEnumerable<AudioDramaDto>>> _dtoProvider;
        private Mock<IProvider<IEnumerable<AudioDramaUserData>>> _userDataProvider;

        [TestInitialize]
        public void CreateNewDdfGuide()
        {
            _dtoProvider = new Mock<IProvider<IEnumerable<AudioDramaDto>>>();
            _userDataProvider = new Mock<IProvider<IEnumerable<AudioDramaUserData>>>();
            _view = new Mock<IAudioDramaListView>();

            _systemUnderTest = new Core.DdfGuide(
                _dtoProvider.Object,
                _userDataProvider.Object,
                _view.Object);
        }

        [TestMethod]
        public void CreationSuccessfull()
        {
            Assert.IsNotNull(_systemUnderTest);
        }

        [TestMethod]
        public void Startup_ShowAudioDramaListView()
        {
            _systemUnderTest.Start();

            _view.Verify(x => x.Show(), Times.Once);
        }
    }
}

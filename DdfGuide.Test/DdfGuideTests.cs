using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class DdfGuideTests
    {
        private Mock<IEpisodeListView> _view;
        private Core.DdfGuide _systemUnderTest;

        [TestInitialize]
        public void CreateNewDdfGuide()
        {
            _view = new Mock<IEpisodeListView>();
            _systemUnderTest = new Core.DdfGuide(_view.Object);
        }

        [TestMethod]
        public void CreationSuccessfull()
        {
            Assert.IsNotNull(_systemUnderTest);
        }

        [TestMethod]
        public void Startup_ShowEpisodeListView()
        {
            _systemUnderTest.Start();

            _view.Verify(x => x.Show(), Times.Once);
        }
    }
}

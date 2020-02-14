using System.Threading.Tasks;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;

namespace DdfGuide.Test
{
    [TestClass]
    public class DdfGuideTests
    {
        private Core.DdfGuide _systemUnderTest;
        private AutoMocker _mocker;

        [TestInitialize]
        public void CreateNewDdfGuide()
        {
            _mocker = new AutoMocker();
            _systemUnderTest = _mocker.CreateInstance<Core.DdfGuide>();
        }

        [TestMethod]
        public void CreationSuccessfull()
        {
            Assert.IsNotNull(_systemUnderTest);
        }

        [TestMethod]
        public async Task Startup_ShowUpdatingView_ShowAudioDramaListViewAsync()
        {
            var rootView = _mocker.GetMock<IRootView>();

            await _systemUnderTest.Start();

            rootView.Verify(x => x.Show(It.IsAny<IUpdatingView>()));
            rootView.Verify(x => x.Show(It.IsAny<IAudioDramaListView>()));
        }
    }
}

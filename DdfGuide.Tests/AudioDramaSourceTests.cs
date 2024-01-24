using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;

namespace DdfGuide.Tests
{
    [TestClass]
    public class AudioDramaSourceTests
    {
        [TestMethod]
        public void MakeSureToSubscribeToTheSaverWhenReturningTheAudioDramas()
        {
            var mocker = new AutoMocker();

            var sut = mocker.CreateInstance<AudioDramaSource>();

            sut.Get();

            mocker.Verify<IOnUserDataChangedInCacheSaver>(x =>
                x.SetObservedUserDatas(It.IsAny<IEnumerable<AudioDramaUserData>>()), Times.Once);
        }
    }
}

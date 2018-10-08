using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class AudioDramaFilterFactoryTests
    {
        private AudioDramaFilterFactory _sut;

        [TestInitialize]
        public void Init()
        {
            _sut = new AudioDramaFilterFactory();
        }

        [TestMethod]
        public void MainAudioDramasOnly()
        {
            var filter = _sut.Create(EAudioDramaFilterMode.MainAudioDramasOnly);
            Assert.IsInstanceOfType(filter, typeof(MainAudioDramasOnlyFilter));
        }
    }
}
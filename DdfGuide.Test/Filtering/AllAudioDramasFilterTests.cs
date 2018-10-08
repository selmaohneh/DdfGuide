using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class AllAudioDramasFilterTests
    {
        [TestMethod]
        public void TheFilterIsMappedToTheCorrectMode()
        {
            var filter = new AllAudioDramasFilter();
            Assert.AreEqual(EAudioDramaFilterMode.All, filter.FilterMode);
        }

        [TestMethod]
        public void TheFilterReturnsAllGivenAudioDramas()
        {
            var provider = new MultipleAudioDramaProvider();
            var audioDramas = provider.Get().ToList();
            var filter = new AllAudioDramasFilter();

            var filtered = filter.Filter(audioDramas).ToList();

            CollectionAssert.AreEqual(audioDramas, filtered);
        }
    }
}

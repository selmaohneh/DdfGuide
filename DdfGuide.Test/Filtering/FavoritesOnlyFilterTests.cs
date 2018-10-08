using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class FavoritesOnlyFilterTests
    {
        [TestMethod]
        public void TheFilterHasTheCorrectMode()
        {
            var filter = new FavoritesOnlyFilter();
            Assert.AreEqual(EAudioDramaFilterMode.FavoritesOnly, filter.FilterMode);
        }

        [TestMethod]
        public void TheFilterReturnsOnlyAudioDramasThatAreMarkedAsFavorite()
        {
            var provider = new MultipleAudioDramaProvider();
            var audioDramas = provider.Get().ToList();
            var filter = new FavoritesOnlyFilter();
            var expectedFiltering = audioDramas.Where(x => x.AudioDramaUserData.IsFavorite).ToList();

            var filtered = filter.Filter(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedFiltering, filtered);
        }
    }
}

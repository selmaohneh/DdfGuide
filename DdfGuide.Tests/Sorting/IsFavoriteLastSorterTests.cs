using DdfGuide.Core.Sorting;
using DdfGuide.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class IsFavoriteLastSorterTests
    {
        [TestMethod]
        public void TheSorterHasTheCorrectMode()
        {
            var sorter = new IsFavoriteLastSorter();
            Assert.AreEqual(EAudioDramaSortMode.IsFavoriteLast, sorter.SortMode);
        }

        [TestMethod]
        public void TheSorterPutsAudioDramasThatAreNotAFavoriteBeforeTheAudioDramasMarkedAsFavorite()
        {
            var provider = new SampleAudioDramaProvider();
            var sorter = new IsFavoriteLastSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderBy(x => x.AudioDramaUserData.IsFavorite).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

using System.Linq;
using DdfGuide.Core.Sorting;
using DdfGuide.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class IsFavoriteFirstSorterTests
    {
        [TestMethod]
        public void TheSorterHasTheCorrectMode()
        {
            var sorter = new IsFavoriteFirstSorter();
            Assert.AreEqual(EAudioDramaSortMode.IsFavoriteFirst, sorter.SortMode);
        }

        [TestMethod]
        public void TheSorterPutsAudioDramasMarkedAsFavoriteBeforeAudioDramasThatAreNot()
        {
            var provider = new SampleAudioDramaProvider();
            var sorter = new IsFavoriteFirstSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderByDescending(x => x.AudioDramaUserData.IsFavorite).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

using DdfGuide.Core.Sorting;
using DdfGuide.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class NameDescendingSorterTests
    {
        [TestMethod]
        public void TheSorterHasTheCorrectMode()
        {
            var sorter = new NameDescendingSorter();
            Assert.AreEqual(EAudioDramaSortMode.NameDescending, sorter.SortMode);
        }

        [TestMethod]
        public void TheSorterSortsTheAudioDramasDescendingByName()
        {
            var provider = new SampleAudioDramaProvider();
            var sorter = new NameDescendingSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderByDescending(x => x.AudioDramaDto.Title).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

using System.Linq;
using DdfGuide.Core.Sorting;
using DdfGuide.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class NumberDescendingSorterTests
    {
        [TestMethod]
        public void TheSorterHasTheCorrectMode()
        {
            var sorter = new NumberDescendingSorter();
            Assert.AreEqual(EAudioDramaSortMode.NumberDescending, sorter.SortMode);
        }

        [TestMethod]
        public void TheSorterSortsTheAudioDramasDescendingByTheirNumber()
        {
            var provider = new SampleAudioDramaProvider();
            var sorter = new NumberDescendingSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderByDescending(x => x.AudioDramaDto.NumberEuropa).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

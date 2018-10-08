using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Sorting;
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
            var provider = new MultipleAudioDramaProvider();
            var sorter = new NumberDescendingSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderByDescending(x => x.AudioDramaDto.Number).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

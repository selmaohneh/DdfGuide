using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class NumberAscendingSorterTests
    {
        [TestMethod]
        public void TheSorterHasTheCorrectMode()
        {
            var sorter = new NumberAscendingSorter();
            Assert.AreEqual(EAudioDramaSortMode.NumberAscending, sorter.SortMode);
        }

        [TestMethod]
        public void TheSorterSortsTheAudioDramasAscendingByTheirNumber()
        {
            var provider = new SampleAudioDramaProvider();
            var sorter = new NumberAscendingSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderBy(x => x.AudioDramaDto.NumberEuropa).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

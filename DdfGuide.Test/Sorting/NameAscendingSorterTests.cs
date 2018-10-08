using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class NameAscendingSorterTests
    {
        [TestMethod]
        public void TheSorterHasTheCorrectMode()
        {
            var sorter = new NameAscendingSorter();
            Assert.AreEqual(EAudioDramaSortMode.NameAscending, sorter.SortMode);
        }

        [TestMethod]
        public void TheSorterSortsTheAudioDramasAscendingByName()
        {
            var provider = new MultipleAudioDramaProvider();
            var sorter = new NameAscendingSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderBy(x => x.AudioDramaDto.Name).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

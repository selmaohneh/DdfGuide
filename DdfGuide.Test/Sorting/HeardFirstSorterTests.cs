using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class HeardFirstSorterTests
    {
        [TestMethod]
        public void TheSorterHasTheCorrectMode()
        {
            var sorter = new HeardFirstSorter();
            Assert.AreEqual(EAudioDramaSortMode.HeardFirst, sorter.SortMode);
        }

        [TestMethod]
        public void TheSorterPutsHeardAudioDramasBeforeUnheardAudioDramas()
        {
            var provider = new SampleAudioDramaProvider();
            var sorter = new HeardFirstSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderByDescending(x => x.AudioDramaUserData.Heard).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class ReleaseDateDescendingSorterTests
    {
        [TestMethod]
        public void TheSorterHasTheCorrectMode()
        {
            var sorter = new ReleaseDateDescendingSorter();
            Assert.AreEqual(EAudioDramaSortMode.ReleaseDateDescending, sorter.SortMode);
        }

        [TestMethod]
        public void TheSorterSortsDescendingByReleaseDate_NewBeforeOld()
        {
            var provider = new SampleAudioDramaProvider();
            var sorter = new ReleaseDateDescendingSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderByDescending(x => x.AudioDramaDto.ReleaseDate).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

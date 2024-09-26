using DdfGuide.Core.Sorting;
using DdfGuide.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class HeardLastSorterTests
    {
        [TestMethod]
        public void TheSorterHasTheCorrectMode()
        {
            var sorter = new HeardLastSorter();
            Assert.AreEqual(EAudioDramaSortMode.HeardLast, sorter.SortMode);
        }

        [TestMethod]
        public void TheSorterPutsAudioDramasMarkedAsHeardBeneathUnheardAudioDramas()
        {
            var provider = new SampleAudioDramaProvider();
            var sorter = new HeardLastSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderBy(x => x.AudioDramaUserData.Heard).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

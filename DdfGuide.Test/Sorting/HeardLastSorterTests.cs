using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class HeardLastSorterTests
    {
        [TestMethod]
        public void CorrectMode()
        {
            var sorter = new HeardLastSorter();
            Assert.AreEqual(EAudioDramaSortMode.HeardLast, sorter.SortMode);
        }

        [TestMethod]
        public void SortByHeardLast()
        {
            var provider = new MultipleAudioDramaProvider();
            var sorter = new HeardLastSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderBy(x => x.AudioDramaUserData.Heard).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}

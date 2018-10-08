using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class UnheardOnlyFilterTests
    {
        [TestMethod]
        public void FilterReturnsOnlyUnheardAudioDramas()
        {
            var provider = new MultipleAudioDramaProvider();
            var audioDramas = provider.Get().ToList();
            var expectedFiltered = audioDramas.Where(x => x.AudioDramaUserData.Heard == false).ToList();
            var filter = new UnheardOnlyFilter();

            var filtered = filter.Filter(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedFiltered, filtered);
        }
    }
}

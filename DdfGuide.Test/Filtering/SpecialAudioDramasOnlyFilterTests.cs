using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class SpecialAudioDramasOnlyFilterTests
    {
        [TestMethod]
        public void FilterOnlyReturnsAudioDramasThatDontHaveANumber()
        {
            var provider = new MultipleAudioDramaProvider();
            var audioDramas = provider.Get().ToList();
            var expectedFiltered = audioDramas.Where(x => x.AudioDramaDto.Number.HasValue == false).ToList();
            var filter = new SpecialAudioDramasOnlyFilter();

            var filtered = filter.Filter(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedFiltered, filtered);
        }
    }
}

using System.Linq;
using DdfGuide.Core.Filtering;
using DdfGuide.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class SpecialAudioDramasOnlyFilterTests
    {
        [TestMethod]
        public void FilterOnlyReturnsOnlyAudioDramasThatDontHaveANumber()
        {
            var provider = new SampleAudioDramaProvider();
            var audioDramas = provider.Get().ToList();
            var expectedFiltered = audioDramas.Where(x => x.AudioDramaDto.NumberEuropa.HasValue == false).ToList();
            var filter = new SpecialAudioDramasOnlyFilter();

            var filtered = filter.Filter(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedFiltered, filtered);
        }

        [TestMethod]
        public void TheFilterHasTheCorrectMode()
        {
            var filter = new SpecialAudioDramasOnlyFilter();
            Assert.AreEqual(EAudioDramaFilterMode.SpecialsOnly, filter.FilterMode);
        }
    }
}

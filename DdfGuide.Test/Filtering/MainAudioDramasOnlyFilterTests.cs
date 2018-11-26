using System.Linq;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class MainAudioDramasOnlyFilterTests
    {
        [TestMethod]
        public void TheFilterReturnsOnlyAudioDramasThatHaveANumber()
        {
            var provider = new SampleAudioDramaProvider();
            var filter = new MainAudioDramasOnlyFilter();

            var filtered = filter.Filter(provider.Get().ToList()).ToList();

            Assert.IsTrue(filtered.All(x => x.AudioDramaDto.NumberEuropa.HasValue));
        }

        [TestMethod]
        public void TheFilterHasTheCorrectMode()
        {
            var filter = new MainAudioDramasOnlyFilter();
            Assert.AreEqual(EAudioDramaFilterMode.MainsOnly, filter.FilterMode);
        }
    }
}

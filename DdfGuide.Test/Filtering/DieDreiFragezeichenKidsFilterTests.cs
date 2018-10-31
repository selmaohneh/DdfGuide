using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class DieDreiFragezeichenKidsFilterTests
    {
        [TestMethod]
        public void TheFilterHasTheCorrectMode()
        {
            var filter = new DieDreiFragezeichenKidsFilter();
            Assert.AreEqual(EAudioDramaFilterMode.DieDreiFragezeichenKids, filter.FilterMode);
        }

        [TestMethod]
        public void TheFilterReturnsOnlyAudioDramasWhereTheInterpreterIsDieDreiFragezeichenKids()
        {
            var provider = new SampleAudioDramaProvider();
            var audioDramas = provider.Get().ToList();

            var audioDrama = audioDramas.First();
            audioDrama.AudioDramaDto.Interpreter = "Die drei ??? Kids";

            var filter = new DieDreiFragezeichenKidsFilter();
            var expectedFiltering = audioDramas.Where(x => x.AudioDramaDto.Interpreter == "Die drei ??? Kids").ToList();

            var filtered = filter.Filter(audioDramas).ToList();

            Assert.IsTrue(filtered.Contains(audioDrama));
            CollectionAssert.AreEqual(expectedFiltering, filtered);
        }
    }
}

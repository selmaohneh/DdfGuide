using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class DieDreiFragezeichenFilterTests
    {
        [TestMethod]
        public void TheFilterHasTheCorrectMode()
        {
            var filter = new DieDreiFrageichenOnlyFilter();
            Assert.AreEqual(EAudioDramaFilterMode.DieDreiFragezeichen, filter.FilterMode);
        }

        [TestMethod]
        public void TheFilterReturnsOnlyAudioDramasWhereTheInterpreterIsDieDreiFragezeichen()
        {
            var provider = new SampleAudioDramaProvider();
            var audioDramas = provider.Get().ToList();

            var audioDrama =  audioDramas.First();
            audioDrama.AudioDramaDto.Interpreter = "Homer Simpson";

            var filter = new DieDreiFrageichenOnlyFilter();
            var expectedFiltering = audioDramas.Where(x => x.AudioDramaDto.Interpreter == "Die drei ???").ToList();

            var filtered = filter.Filter(audioDramas).ToList();

            Assert.IsFalse(filtered.Contains(audioDrama));
            CollectionAssert.AreEqual(expectedFiltering, filtered);
        }
    }
}

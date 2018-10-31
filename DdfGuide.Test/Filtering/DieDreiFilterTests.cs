using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class DieDreiFilterTests
    {
        [TestMethod]
        public void TheFilterHasTheCorrectMode()
        {
            var filter = new DieDreiFilter();
            Assert.AreEqual(EAudioDramaFilterMode.DieDrei, filter.FilterMode);
        }

        [TestMethod]
        public void TheFilterReturnsOnlyAudioDramasWhereTheInterpreterIsDieDrei()
        {
            var provider = new SampleAudioDramaProvider();
            var audioDramas = provider.Get().ToList();

            var audioDrama = audioDramas.First();
            audioDrama.AudioDramaDto.Interpreter = "DiE DR3i";

            var filter = new DieDreiFilter();
            var expectedFiltering = audioDramas.Where(x => x.AudioDramaDto.Interpreter == "DiE DR3i").ToList();

            var filtered = filter.Filter(audioDramas).ToList();

            Assert.IsTrue(filtered.Contains(audioDrama));
            CollectionAssert.AreEqual(expectedFiltering, filtered);
        }
    }
}

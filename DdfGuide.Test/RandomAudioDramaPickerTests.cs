using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class RandomAudioDramaPickerTests
    {
        [TestMethod]
        public void RandomlyPickedAudioDramaIsOneOfTheGivenAudioDramas()
        {
            var provider = new SampleAudioDramaProvider();
            var audioDramas = provider.Get().ToList();
            var picker = new RandomAudioDramaPicker();

           var random = picker.Pick(audioDramas);

            Assert.IsTrue(audioDramas.Contains(random));
        }
    }
}

using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Tests
{
    [TestClass]
    public class AudioDramaBuilderTests
    {
        [TestMethod]
        public void TestCorrectBuilding()
        {
            var dtoProvider = new SampleDtoProvider();
            var dtos = dtoProvider.Get().ToList();
            
            var userDataProvider = new SampleUserDataProvider();
            var userData = userDataProvider.Get().ToList();

            var audioDramas = new List<AudioDrama>();
            for (var i = 0; i < dtos.Count; i++)
            {
                var audioDrama = new AudioDrama(
                    dtos.ElementAt(i), 
                    userData.ElementAt(i));

                audioDramas.Add(audioDrama);
            }

            dtos.Reverse();

            var builder = new AudioDramaBuilder();
            var buildResult = builder.Build(dtos, userData).ToList();

            foreach (var audioDrama in audioDramas)
            {
                var buildAudioDrama = buildResult.Single(x => x.Equals(audioDrama));

                Assert.AreEqual(audioDrama.AudioDramaDto, buildAudioDrama.AudioDramaDto);
                Assert.AreEqual(audioDrama.AudioDramaUserData, buildAudioDrama.AudioDramaUserData);
            }
        }
    }
}

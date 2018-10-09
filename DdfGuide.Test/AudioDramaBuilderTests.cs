using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaBuilderTests
    {
        [TestMethod]
        public void TestCorrectBuilding()
        {
            var dtoProvider = new DtoProvider();
            var dtos = dtoProvider.Get().ToList();
            
            var userDataProvider = new UserDataProvider();
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

            var builder = new AudioDramaBuilder(dtos, userData);
            var buildResult = builder.Build().ToList();

            foreach (var audioDrama in audioDramas)
            {
                var buildAudioDrama = buildResult.Single(x => x.Equals(audioDrama));

                Assert.AreEqual(audioDrama.AudioDramaDto, buildAudioDrama.AudioDramaDto);
                Assert.AreEqual(audioDrama.AudioDramaUserData, buildAudioDrama.AudioDramaUserData);
            }
        }
    }
}

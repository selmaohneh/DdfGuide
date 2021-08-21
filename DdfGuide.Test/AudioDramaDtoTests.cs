using System;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaDtoTests
    {
        [TestMethod]
        public void GivenSpotifyId_CorrectSpotifyUri()
        {
            var sut = new AudioDramaDto(Guid.Empty,
                                        string.Empty,
                                        -1,
                                        DateTime.Now,
                                        string.Empty,
                                        string.Empty,
                                        string.Empty,
                                        Enumerable.Empty<RoleDto>(),
                                        "HomerSimpson",
                                        string.Empty,
                                        string.Empty);

            var uri = sut.SpotifyUri;

            Assert.AreEqual(@"https://open.spotify.com/album/HomerSimpson", uri.ToString());
        }
    }
}
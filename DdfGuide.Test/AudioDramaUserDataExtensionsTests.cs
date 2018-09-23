using System;
using System.Collections.Generic;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaUserDataExtensionsTests
    {
        [TestMethod]
        public void UserHasHeard()
        {
            var audioDrama1 = new AudioDrama(Guid.NewGuid());
            var audioDrama2 = new AudioDrama(Guid.NewGuid());
            var audioDrama3 = new AudioDrama(Guid.NewGuid());

            var userData1 = new AudioDramaUserData(audioDrama1.Id, true);
            var userData2 = new AudioDramaUserData(audioDrama2.Id, false);
            var userData3 = new AudioDramaUserData(audioDrama3.Id, true);
            var userData = new List<AudioDramaUserData>
            {
                userData1,
                userData2,
                userData3
            };

            Assert.IsTrue(userData.UserHasHeard(audioDrama1));
            Assert.IsFalse(userData.UserHasHeard(audioDrama2));
            Assert.IsTrue(userData.UserHasHeard(audioDrama3));
        }

        [TestMethod]
        public void UserHasHeard_NoUserData_ReturnFalse()
        {
            var audioDrama = new AudioDrama(Guid.NewGuid());

            var userData = new List<AudioDramaUserData>();

            Assert.IsFalse(userData.UserHasHeard(audioDrama));
        }
    }
}

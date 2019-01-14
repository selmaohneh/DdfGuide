using System;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class ReleaseDateServiceTests
    {
        [TestMethod]
        public void GivenDtoIsReleased_ServiceReturnsIsReleased()
        {
            var sut = new ReleaseDateService();
            var dto = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.Now - TimeSpan.FromDays(42),
                string.Empty,
                string.Empty,
                string.Empty,
                null);

            var isReleased = sut.IsReleased(dto);
            Assert.IsTrue(isReleased);
        }

        [TestMethod]
        public void GivenDtoIsNotReleased_ServiceReturnsIsNotReleased()
        {
            var sut = new ReleaseDateService();
            var dto = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.Now + TimeSpan.FromDays(42), 
                string.Empty,
                string.Empty,
                string.Empty,
                null);

            var isReleased = sut.IsReleased(dto);
            Assert.IsFalse(isReleased);
        }

        [TestMethod]
        public void GivenDtoIsReleasedToday_ServiceReturnsIsReleased()
        {
            var sut = new ReleaseDateService();
            var dto = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.Now,
                string.Empty,
                string.Empty,
                string.Empty,
                null);

            var isReleased = sut.IsReleased(dto);
            Assert.IsTrue(isReleased);
        }
    }
}

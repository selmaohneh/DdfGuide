using System;
using System.Collections.Generic;
using System.Linq;
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
                null,
                string.Empty);

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
                null,
                string.Empty);

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
                null,
                string.Empty);

            var isReleased = sut.IsReleased(dto);
            Assert.IsTrue(isReleased);
        }

        [TestMethod]
        public void GetDtosReleasedToday_None_ReturnsEmptyList()
        {
            var dtoBefore = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.MinValue.Date,
                string.Empty,
                string.Empty,
                string.Empty,
                new List<RoleDto>(),
                string.Empty);

            var dtoAfter = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.MaxValue.Date,
                string.Empty,
                string.Empty,
                string.Empty,
                new List<RoleDto>(),
                string.Empty);
            
            var dtos = new List<AudioDramaDto> {dtoBefore, dtoAfter};

            var sut = new ReleaseDateService();

            var todaysReleases = sut.GetTodaysReleasesFrom(dtos);

            Assert.IsFalse(todaysReleases.Any());
        }

        [TestMethod]
        public void GetDtosReleasedToday_Single_ReturnsCorrectList()
        {
            var dtoBefore = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.MinValue.Date,
                string.Empty,
                string.Empty,
                string.Empty,
                new List<RoleDto>(),
                string.Empty);

            var dtoToday = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.Now.Date,
                string.Empty,
                string.Empty,
                string.Empty,
                new List<RoleDto>(),
                string.Empty);

            var dtoAfter = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.MaxValue.Date,
                string.Empty,
                string.Empty,
                string.Empty,
                new List<RoleDto>(),
                string.Empty);

            var dtos = new List<AudioDramaDto> {dtoBefore, dtoToday, dtoAfter};

            var sut = new ReleaseDateService();

            var todaysReleases = sut.GetTodaysReleasesFrom(dtos).ToList();

            Assert.AreEqual(1, todaysReleases.Count);
            Assert.IsTrue(todaysReleases.Contains(dtoToday));
        }

        [TestMethod]
        public void GetDtosReleasedToday_Multiple_ReturnsCorrectList()
        {
            var dtoBefore = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.MinValue.Date,
                string.Empty,
                string.Empty,
                string.Empty,
                new List<RoleDto>(),
                string.Empty);

            var dtoToday1 = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.Now.Date,
                string.Empty,
                string.Empty,
                string.Empty,
                new List<RoleDto>(),
                string.Empty);

            var dtoToday2 = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.Now.Date,
                string.Empty,
                string.Empty,
                string.Empty,
                new List<RoleDto>(),
                string.Empty);

            var dtoAfter = new AudioDramaDto(
                Guid.Empty,
                string.Empty,
                null,
                DateTime.MaxValue.Date,
                string.Empty,
                string.Empty,
                string.Empty,
                new List<RoleDto>(),
                string.Empty);

            var dtos = new List<AudioDramaDto> {dtoBefore, dtoToday1, dtoToday2, dtoAfter};

            var sut = new ReleaseDateService();

            var todaysReleases = sut.GetTodaysReleasesFrom(dtos).ToList();

            Assert.AreEqual(2, todaysReleases.Count);
            Assert.IsTrue(todaysReleases.Contains(dtoToday1));
            Assert.IsTrue(todaysReleases.Contains(dtoToday2));
        }
    }
}

using System;
using System.Collections.Generic;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaAsSearchItemTests
    {
        [TestMethod]
        public void TitleCanBeSearched()
        {
            var dto = new AudioDramaDto(Guid.Empty,
                                        "Homer Simpson",
                                        -1,
                                        DateTime.MinValue,
                                        string.Empty,
                                        string.Empty,
                                        string.Empty,
                                        new List<RoleDto>(),
                                        string.Empty,
                                        string.Empty,
                                        string.Empty);

            var userData = new AudioDramaUserData(Guid.Empty, false, false);

            var audioDrama = new AudioDrama(dto, userData);
            var searchString = audioDrama.ToSearchString();

            Assert.IsTrue(searchString.Contains("Homer Simpson"));
        }

        [TestMethod]
        public void NumberEuropaCanBeSearched()
        {
            var dto = new AudioDramaDto(Guid.Empty,
                                        string.Empty,
                                        42,
                                        DateTime.MinValue,
                                        string.Empty,
                                        string.Empty,
                                        string.Empty,
                                        new List<RoleDto>(),
                                        string.Empty,
                                        string.Empty,
                                        string.Empty);

            var userData = new AudioDramaUserData(Guid.Empty, false, false);

            var audioDrama = new AudioDrama(dto, userData);
            var searchString = audioDrama.ToSearchString();

            Assert.IsTrue(searchString.Contains("42"));
        }

        [TestMethod]
        public void ReleaseDateCanBeSearched()
        {
            var dto = new AudioDramaDto(Guid.Empty,
                                        string.Empty,
                                        -1,
                                        new DateTime(2000, 11, 29),
                                        string.Empty,
                                        string.Empty,
                                        string.Empty,
                                        new List<RoleDto>(),
                                        string.Empty,
                                        string.Empty,
                                        string.Empty);

            var userData = new AudioDramaUserData(Guid.Empty, false, false);

            var audioDrama = new AudioDrama(dto, userData);
            var searchString = audioDrama.ToSearchString();

            Assert.IsTrue(searchString.Contains("29.11.2000"));
        }

        [TestMethod]
        public void InterpreterCanBeSearched()
        {
            var dto = new AudioDramaDto(Guid.Empty,
                                        string.Empty,
                                        -1,
                                        DateTime.MinValue,
                                        string.Empty,
                                        "Homer Simpson",
                                        string.Empty,
                                        new List<RoleDto>(),
                                        string.Empty,
                                        string.Empty,
                                        string.Empty);

            var userData = new AudioDramaUserData(Guid.Empty, false, false);

            var audioDrama = new AudioDrama(dto, userData);
            var searchString = audioDrama.ToSearchString();

            Assert.IsTrue(searchString.Contains("Homer Simpson"));
        }

        [TestMethod]
        public void AuthorCanBeSearched()
        {
            var dto = new AudioDramaDto(Guid.Empty,
                                        string.Empty,
                                        -1,
                                        DateTime.MinValue,
                                        string.Empty,
                                        string.Empty,
                                        string.Empty,
                                        new List<RoleDto>(),
                                        string.Empty,
                                        string.Empty,
                                        "Homer Simpson, Marge Simpson");

            var userData = new AudioDramaUserData(Guid.Empty, false, false);

            var audioDrama = new AudioDrama(dto, userData);
            var searchString = audioDrama.ToSearchString();

            Assert.IsTrue(searchString.Contains("Homer Simpson, Marge Simpson"));
        }

        [TestMethod]
        public void DescriptionCanBeSearched()
        {
            var dto = new AudioDramaDto(Guid.Empty,
                                        string.Empty,
                                        -1,
                                        DateTime.MinValue,
                                        string.Empty,
                                        string.Empty,
                                        "Homer Simpson",
                                        new List<RoleDto>(),
                                        string.Empty,
                                        string.Empty,
                                        string.Empty);

            var userData = new AudioDramaUserData(Guid.Empty, false, false);

            var audioDrama = new AudioDrama(dto, userData);
            var searchString = audioDrama.ToSearchString();

            Assert.IsTrue(searchString.Contains("Homer Simpson"));
        }

        [TestMethod]
        public void RolesCanBeSearched()
        {
            var dto = new AudioDramaDto(Guid.Empty,
                                        string.Empty,
                                        -1,
                                        DateTime.MinValue,
                                        string.Empty,
                                        string.Empty,
                                        string.Empty,
                                        new List<RoleDto>
                                        {
                                            new RoleDto("Homer Simpson", "Marge Simpson"),
                                            new RoleDto("Springfield", "Duff Beer")
                                        },
                                        string.Empty,
                                        string.Empty,
                                        string.Empty);

            var userData = new AudioDramaUserData(Guid.Empty, false, false);

            var audioDrama = new AudioDrama(dto, userData);
            var searchString = audioDrama.ToSearchString();

            Assert.IsTrue(searchString.Contains("Homer Simpson"));
            Assert.IsTrue(searchString.Contains("Marge Simpson"));
            Assert.IsTrue(searchString.Contains("Springfield"));
            Assert.IsTrue(searchString.Contains("Duff Beer"));
        }
    }
}
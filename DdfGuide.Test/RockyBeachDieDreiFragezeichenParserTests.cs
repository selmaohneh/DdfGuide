using System;
using System.Linq;
using DdfGuide.Parser;
using DdfGuide.Test.Properties;
using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class RockyBeachDieDreiFragezeichenParserTests
    {
        private RockyBeachDieDreiFragezeichenParser _parser;

        [TestInitialize]
        public void Init()
        {
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(Resources.RockyBeachUndDerSuperPapagei);

            _parser = new RockyBeachDieDreiFragezeichenParser(htmlDocument);
        }

        [TestMethod]
        public void ValidTitle()
        {
            Assert.IsTrue(_parser.TryParseTitle(out var title));
            Assert.AreEqual("... und der Super-Papagei", title);
        }

        [TestMethod]
        public void ValidCoverUrl()
        {
            Assert.IsTrue(_parser.TryParseCoverUrl(out var coverUrl));
            Assert.AreEqual("http://www.rocky-beach.com/hoerspiel/cover/001.jpg", coverUrl);
        }

        [TestMethod]
        public void ValidDescription()
        {
            Assert.IsTrue(_parser.TryParseDescription(out var description));
            Assert.AreEqual(Resources.UndDerSuperPapageiDescription, description);
        }

        [TestMethod]
        public void ValidInterpreter()
        {
            Assert.IsTrue(_parser.TryParseInterpreter(out var interpreter));
            Assert.AreEqual("Die drei ???", interpreter);
        }

        [TestMethod]
        public void ValidNumber()
        {
            Assert.IsTrue(_parser.TryParseNumber(out var number));
            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void ValidReleaseDate()
        {
            Assert.IsTrue(_parser.TryParseReleaseDate(out var releaseDate));
            Assert.AreEqual(new DateTime(1979, 10, 12), releaseDate);
        }

        [TestMethod]
        public void ValidRoles()
        {
            Assert.IsTrue(_parser.TryParseRoles(out var roles));

            roles = roles.ToList();

            Assert.AreEqual(12, roles.Count());

            Assert.AreEqual("Oliver Rohrbeck", roles
                .Single(x => x.Character.Equals("Justus Jonas, Erster Detektiv"))
                .Speaker);
            Assert.AreEqual("Andreas von der Meden", roles
                .Single(x => x.Character.Equals("Morton"))
                .Speaker);
        }

        [TestMethod]
        public void AssertNoParseMethodThrowsException()
        {
            try
            {
                var htmlDocument = new HtmlDocument();
                _parser = new RockyBeachDieDreiFragezeichenParser(htmlDocument);

                Assert.IsFalse(_parser.TryParseCoverUrl(out _));
                Assert.IsFalse(_parser.TryParseDescription(out _));
                Assert.IsFalse(_parser.TryParseNumber(out _));
                Assert.IsFalse(_parser.TryParseReleaseDate(out _));
                Assert.IsFalse(_parser.TryParseTitle(out _));
                Assert.IsFalse(_parser.TryParseRoles(out _));

                // Ignore interpreter, since it is not actually parsing but returning
                // "Die drei ???" hardcoded and therefore would fail this test.
            }
            catch (Exception)
            {
                Assert.Fail("No exception allowed in a TryStuff() method.");
            }
        }
    }
}

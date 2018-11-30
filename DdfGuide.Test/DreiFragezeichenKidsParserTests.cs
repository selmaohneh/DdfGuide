using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using DdfGuide.Parser;
using DdfGuide.Test.Properties;
using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class DreiFragezeichenKidsParserTests
    {
        private DreiFragezeichenKidsParser _parser;

        [TestInitialize]
        public void Init()
        {
            var htmlDocument = new HtmlDocument();

            using (var client = new WebClient())
            {
                var html = client.DownloadData(
                    "https://www.hoerspiel.de/hoerspiel/Serien/Die-drei-Fragezeichen-Kids/Hoerspiel/Gefahr-aus-dem-All/AD1F058A6B9B433E40E93F8FFBCE2F23/");

                var htmlCode = Encoding.UTF8.GetString(html);
                htmlDocument.LoadHtml(htmlCode);
            }

            _parser = new DreiFragezeichenKidsParser(htmlDocument);
        }

        [TestMethod]
        public void ValidTitle()
        {
            Assert.IsTrue(_parser.TryParseTitle(out var title));
            Assert.AreEqual("Gefahr aus dem All", title);
        }

        [TestMethod]
        public void ValidCoverUrl()
        {
            Assert.IsTrue(_parser.TryParseCoverUrl(out var coverUrl));
            Assert.AreEqual("https://www.hoerspiel.de/MacsService/Macs/ContentService/102/5011456.jpeg", coverUrl);
        }

        [TestMethod]
        public void ValidDescription()
        {
            Assert.IsTrue(_parser.TryParseDescription(out var description));
            Assert.AreEqual(Resources.GefahrAusDemAllDescription, description);
        }

        [TestMethod]
        public void ValidInterpreter()
        {
            Assert.IsTrue(_parser.TryParseInterpreter(out var interpreter));
            Assert.AreEqual("Die drei ??? Kids", interpreter);
        }

        [TestMethod]
        public void ValidNumber()
        {
            Assert.IsTrue(_parser.TryParseNumber(out var number));
            Assert.AreEqual(14, number);
        }

        [TestMethod]
        public void ValidReleaseDate()
        {
            Assert.IsTrue(_parser.TryParseReleaseDate(out var releaseDate));
            Assert.AreEqual(new DateTime(2010, 03, 12), releaseDate);
        }

        [TestMethod]
        public void ValidRoles()
        {
            Assert.IsTrue(_parser.TryParseRoles(out var roles));

            roles = roles.ToList();

            Assert.AreEqual(15, roles.Count());

            Assert.AreEqual("Jannik Schümann", roles
                .Single(x => x.Character.Equals("Justus Jonas"))
                .Speaker);
            Assert.AreEqual("Tim Kreuer", roles
                .Single(x => x.Character.Equals("Skinny Norris"))
                .Speaker);
        }

        [TestMethod]
        public void AssertNoParseMethodThrowsException()
        {
            try
            {
                var htmlDocument = new HtmlDocument();
                _parser = new DreiFragezeichenKidsParser(htmlDocument);

                Assert.IsFalse(_parser.TryParseCoverUrl(out _));
                Assert.IsFalse(_parser.TryParseDescription(out _));
                Assert.IsFalse(_parser.TryParseNumber(out _));
                Assert.IsFalse(_parser.TryParseReleaseDate(out _));
                Assert.IsFalse(_parser.TryParseTitle(out _));
                Assert.IsFalse(_parser.TryParseRoles(out _));

                // Ignore interpreter, since it is not actually parsing but returning
                // "Die drei ??? Kids" hardcoded and therefore would fail this test.
            }
            catch (Exception)
            {
                Assert.Fail("No exception allowed in a TryStuff() method.");
            }
        }
    }
}

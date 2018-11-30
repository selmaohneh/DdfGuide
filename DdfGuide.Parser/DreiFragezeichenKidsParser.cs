using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using DdfGuide.Core;
using HtmlAgilityPack;

namespace DdfGuide.Parser
{
    public class DreiFragezeichenKidsParser : IAudioDramaDtoParser
    {
        private readonly HtmlDocument _htmlDocument;

        public DreiFragezeichenKidsParser(HtmlDocument htmlDocument)
        {
            _htmlDocument = htmlDocument;
        }

        public bool TryParseNumber(out int? number)
        {
            try
            {
                const string xPath = "//ul[@class='meta']/li";

                var listItems = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath);

                foreach (var listItem in listItems)
                {
                    if (listItem
                        .ChildNodes["b"]
                        .InnerText
                        .Contains("Folge"))
                    {
                        var numberString = listItem
                            .ChildNodes["span"]
                            .InnerText
                            .Decode();

                        var success = int.TryParse(numberString, out var parsedNumber);
                        number = success
                            ? new int?(parsedNumber)
                            : null;

                        return success;
                    }
                }

                number = null;
                return false;
            }
            catch (Exception)
            {
                number = null;
                return false;
            }
        }

        public bool TryParseTitle(out string title)
        {
            try
            {
                const string xPath = "//div[@class='titles']/h2";

                title = _htmlDocument
                    .DocumentNode
                    .SelectSingleNode(xPath)
                    .InnerText
                    .Decode();

                return true;
            }
            catch (Exception)
            {
                title = null;
                return false;
            }
        }

        public bool TryParseReleaseDate(out DateTime releaseDate)
        {
            try
            {
                const string xPath = "//ul[@class='meta']/li";

                var listItems = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath);

                foreach (var listItem in listItems)
                {
                    if (listItem
                        .ChildNodes["b"]
                        .InnerText
                        .Contains("Erscheinungsdatum"))
                    {
                        var dateString = listItem
                            .ChildNodes["span"]
                            .InnerText
                            .Decode();

                        var dateStrings = dateString.Split(' ');

                        var oldestDate = DateTime.MaxValue;
                        foreach (var date in dateStrings)
                        {
                            var currentDate = DateTime.MinValue;
                            DateTime.TryParseExact(
                                date,
                                "dd.MM.yyyy",
                                CultureInfo.InvariantCulture,
                                DateTimeStyles.None, out currentDate);

                            if (currentDate < oldestDate)
                            {
                                oldestDate = currentDate;
                            }
                        }

                        releaseDate = oldestDate;
                        return true;
                    }
                }

                releaseDate = DateTime.MinValue;
                return false;
            }
            catch (Exception)
            {
                releaseDate = DateTime.MinValue;
                return false;
            }
        }

        public bool TryParseCoverUrl(out string coverUrl)
        {
            try
            {
                const string xPath = "//div[@class='productDetailImage']/div/img";

                var subUrl = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath)
                    .First()
                    .Attributes["src"]
                    .Value;

                coverUrl = "https://www.hoerspiel.de" + subUrl;
                return true;
            }
            catch (Exception)
            {
                coverUrl = null;
                return false;
            }
        }

        public bool TryParseDescription(out string description)
        {
            try
            {
                const string xPath = "//div[@class='panel open']/div[@class='p']";
                
                description = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath)
                    .First()
                    .InnerHtml
                    .Decode();

                description = HtmlEntity.DeEntitize(description);

                return true;
            }
            catch (Exception)
            {
                description = null;
                return false;
            }
        }

        public bool TryParseRoles(out IEnumerable<RoleDto> roles)
        {
            try
            {
                const string xPath = "(//ul[@id='productpage-accordion-panel']/li/ol[@class='panel '])[1]/li";
                
                var rows = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath);

                var roleDtos = new List<RoleDto>();
                foreach (var row in rows)
                {
                    var text = row
                        .InnerText
                        .Decode();

                    var splitText = text.Split(new[] { " - " }, StringSplitOptions.None);

                    var character = splitText[0];
                    var speaker = splitText[1];

                    var role = new RoleDto(character, speaker);
                    roleDtos.Add(role);
                }

                roles = roleDtos;
                return true;
            }
            catch (Exception)
            {
                roles = new List<RoleDto>();
                return false;
            }
        }

        public bool TryParseInterpreter(out string interpreter)
        {
            try
            {
                const string xPath = "//div[@class='titles']/a/h1";

                var interpreterString = _htmlDocument
                    .DocumentNode
                    .SelectSingleNode(xPath)
                    .InnerText
                    .Decode();

                var interpreters = interpreterString.Split(new[] {" - "}, StringSplitOptions.None);

                interpreter = interpreters.Last();

                return true;
            }
            catch (Exception)
            {
                interpreter = null;
                return false;
            }
        }
    }
}

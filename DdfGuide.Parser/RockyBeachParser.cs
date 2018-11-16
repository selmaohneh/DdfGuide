using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using HtmlAgilityPack;

namespace DdfGuide.Parser
{
    public class RockyBeachParser : IAudioDramaDtoParser
    {
        private readonly HtmlDocument _htmlDocument;

        public RockyBeachParser(HtmlDocument htmlDocument)
        {
            _htmlDocument = htmlDocument;
        }

        public bool TryParseNumber(out int? number)
        {
            try
            {
                const string xPath = "/html/body/table/tr[1]/td[2]/center[1]/table/tr[1]/td[1]/center/span";

                var numberString = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath)
                    .First()
                    .InnerText
                    .Replace("#", "")
                    .Decode();

                var success = int.TryParse(numberString, out var parsedNumber);
                number = parsedNumber;

                return success;
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
                const string xPath = "/html/body/table/tr[1]/td[2]/center[1]/table/tr[1]/td[3]/center/span";

                title = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath)
                    .First()
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
                const string xPath = "/html/body/table/tr[1]/td[2]/center[4]/table/tr[2]/td/table//tr";

                var rows = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath);

                foreach (var row in rows)
                {
                    var columns = row.SelectNodes("td");
                    if (columns == null) continue;

                    var leftColumn = columns[0].InnerText.Decode();
                    var rightColumn = columns[1].InnerText.Decode();

                    if (leftColumn == "Erscheinungsdatum:")
                    {
                        releaseDate = DateTime.Parse(rightColumn);
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
                const string xPath = "/html/body/table/tr[1]/td[2]/center[2]/table/tr[2]/td/img";

                var subUrl = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath)
                    .First()
                    .Attributes["src"]
                    .Value
                    .Substring(2);

                coverUrl = "http://www.rocky-beach.com/hoerspiel" + subUrl;
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
                const string xPath = "/html/body/table/tr[1]/td[2]/center[2]/table/tr[2]/td";

                description = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath)
                    .First()
                    .InnerText
                    .Decode();

                return true;
            }
            catch (Exception )
            {
                description = null;
                return false;
            }
        }

        public bool TryParseRoles(out IEnumerable<RoleDto> roles)
        {
            try
            {
                const string xPath = "/html/body/table/tr[1]/td[2]/center[3]/table/tr[2]/td/table//tr";

                var rows = _htmlDocument
                    .DocumentNode
                    .SelectNodes(xPath);

                var roleDtos = new List<RoleDto>();
                foreach (var row in rows)
                {
                    var columns = row.SelectNodes("td");
                    var character = columns[0].InnerText.Decode();
                    var speaker = columns[1].InnerText.Decode();

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
            interpreter = "Die drei ???";
            return true;
        }
    }
}

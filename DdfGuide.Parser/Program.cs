using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DdfGuide.Core;
using Newtonsoft.Json;

namespace DdfGuide.Parser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var downloader = new HtmlDocumentDownloader();
            var html = downloader.DownloadHtmlDocumentFrom(args.First());
            var parser = new RockyBeachDieDreiFragezeichenParser(html);

            parser.TryParseInterpreter(out var interpreter);
            parser.TryParseTitle(out var title);
            parser.TryParseNumber(out var number);
            parser.TryParseReleaseDate(out var releaseDate);
            parser.TryParseDescription(out var description);
            parser.TryParseCoverUrl(out var coverUrl);
            parser.TryParseRoles(out var roles);

            var dto = new AudioDramaDto(
                Guid.NewGuid(), 
                title,
                number,
                releaseDate, 
                coverUrl, 
                interpreter,
                description,
                roles);

            var json = JsonConvert.SerializeObject(dto, Formatting.Indented);

            Console.WriteLine(json);

            Console.ReadLine();
        }

        private static void SetConsoleColor(bool success)
        {
            Console.ForegroundColor = success 
                ? ConsoleColor.DarkGreen 
                : ConsoleColor.DarkRed;
        }
    }
}

using System;
using System.Linq;

namespace DdfGuide.Parser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var downloader = new HtmlDocumentDownloader();
            var html = downloader.DownloadHtmlDocumentFrom(args.First());
            var parser = new RockyBeachDieDreiFragezeichenParser(html);

            var success = parser.TryParseInterpreter(out var interpreter);
            SetConsoleColor(success);
            Console.WriteLine($@"Interpreter: {interpreter}");

            success = parser.TryParseInterpreter(out var title);
            SetConsoleColor(success);
            Console.WriteLine($@"Title: {title}");

            success = parser.TryParseNumber(out var number);
            SetConsoleColor(success);
            Console.WriteLine($@"Number: {number}");

            success = parser.TryParseReleaseDate(out var releaseDate);
            SetConsoleColor(success);
            Console.WriteLine($@"ReleaseDate: {releaseDate}");

            success = parser.TryParseDescription(out var description);
            SetConsoleColor(success);
            Console.WriteLine($@"Description: {description}");

            success = parser.TryParseCoverUrl(out var coverUrl);
            SetConsoleColor(success);
            Console.WriteLine($@"CoverUrl: {coverUrl}");

            success = parser.TryParseRoles(out var roles);
            SetConsoleColor(success);
            Console.WriteLine(@"Roles:");
            foreach (var role in roles)
            {
                Console.WriteLine($@"{role.Character}: {role.Speaker}");
            }
        }

        private static void SetConsoleColor(bool success)
        {
            Console.ForegroundColor = success 
                ? ConsoleColor.DarkGreen 
                : ConsoleColor.DarkRed;
        }
    }
}

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
            Console.WriteLine(interpreter);
            Console.WriteLine();

            success = parser.TryParseTitle(out var title);
            SetConsoleColor(success);
            Console.WriteLine(title);
            Console.WriteLine();

            success = parser.TryParseNumber(out var number);
            SetConsoleColor(success);
            Console.WriteLine(number);
            Console.WriteLine();

            success = parser.TryParseReleaseDate(out var releaseDate);
            SetConsoleColor(success);
            Console.WriteLine(releaseDate.ToString("dd.MM.yyyy"));
            Console.WriteLine();

            success = parser.TryParseDescription(out var description);
            SetConsoleColor(success);
            Console.WriteLine(description);
            Console.WriteLine();

            success = parser.TryParseCoverUrl(out var coverUrl);
            SetConsoleColor(success);
            Console.WriteLine(coverUrl);
            Console.WriteLine();

            success = parser.TryParseRoles(out var roles);
            SetConsoleColor(success);
            foreach (var role in roles)
            {
                Console.WriteLine($@"{role.Character}: {role.Speaker}");
            }
            Console.WriteLine();

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

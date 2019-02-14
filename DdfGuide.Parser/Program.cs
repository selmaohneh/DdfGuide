using System;
using System.Net;
using DdfGuide.Core;
using Newtonsoft.Json;

namespace DdfGuide.Parser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var downloader = new HtmlDocumentDownloader();
            
            foreach (var arg in args)
            {
                var html = downloader.DownloadHtmlDocumentFrom(arg);
                var parser = new HoerspielDeParser(html);

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


                using (var client = new WebClient())
                {
                    client.DownloadFile(coverUrl, "../../../Covers/" + dto.Id + ".jpg");
                }

                dto.CoverUrl = $"https://github.com/selmaohneh/DdfGuide/raw/master/Covers/{dto.Id}.jpg";

                var json = JsonConvert.SerializeObject(dto, Formatting.Indented);

                Console.WriteLine(json);
            }
        }
    }
}

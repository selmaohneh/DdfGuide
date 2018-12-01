using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                var parser = new DreiFragezeichenKidsParser(html);

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

                var allJson = File.ReadAllText("../../../dtos.json");
                var allAudioDramas = JsonConvert.DeserializeObject<IList<AudioDramaDto>>(allJson);

                if (allAudioDramas.Any(x => x.Title == dto.Title))
                {
                    Console.WriteLine($"Audio drama with title {dto.Title} does already exist.");
                    Console.ReadKey();
                    return;
                }

                allAudioDramas.Add(dto);
                allJson = JsonConvert.SerializeObject(allAudioDramas, Formatting.Indented);
                File.WriteAllText("../../../dtos.json", allJson);
            }
            Console.ReadLine();
        }
    }
}

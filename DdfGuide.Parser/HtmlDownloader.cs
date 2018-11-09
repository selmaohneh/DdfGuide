using HtmlAgilityPack;

namespace DdfGuide.Parser
{
    public class HtmlDocumentDownloader
    {
        public HtmlDocument DownloadHtmlDocumentFrom(string url)
        {
            var web = new HtmlWeb();
            var doc = web.Load(url);

            return doc;
        }
    }
}

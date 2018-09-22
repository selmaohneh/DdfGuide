namespace DdfGuide.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var episodeListView = new EpisodeListView();
            var ddfGuide = new Core.DdfGuide(episodeListView);

            ddfGuide.Start();

            System.Console.ReadKey();
        }
    }
}

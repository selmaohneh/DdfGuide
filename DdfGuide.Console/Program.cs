using DdfGuide.Core;

namespace DdfGuide.Console
{
    internal class Program
    {
        private static void Main()
        {
            var dtoProvider = new MultipleDtoProvider();
            var userDataProvider = new MultipleUserDataProvider();

            var audioDramaView = new AudioDramaView();
            var audioDramaListView = new AudioDramaListView();

            var ddfGuide = new Core.DdfGuide(
                dtoProvider,
                userDataProvider,
                audioDramaListView,
                audioDramaView);

            ddfGuide.Start();

            System.Console.ReadKey();
        }
    }
}

using DdfGuide.Core;

namespace DdfGuide.Console
{
    internal class Program
    {
        private static void Main()
        {
            var dtoProvider = new DtoProvider();
            var userDataProvider = new UserDataProvider();

            var audioDramaListView = new AudioDramaListView();

            var ddfGuide = new Core.DdfGuide(
                dtoProvider,
                userDataProvider,
                audioDramaListView);

            ddfGuide.Start();

            System.Console.ReadKey();
        }
    }
}

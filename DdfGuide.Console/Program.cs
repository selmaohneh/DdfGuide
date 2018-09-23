using System;
using System.Threading.Tasks;
using DdfGuide.Core;
using Repository.Memory;

namespace DdfGuide.Console
{
    internal class Program
    {
        private static async Task Main()
        {
            var localRepository = new MemoryRepository<AudioDrama>();

            var audioDrama1 = new AudioDrama(Guid.NewGuid());
            var audioDrama2 = new AudioDrama(Guid.NewGuid());
            var audioDrama3 = new AudioDrama(Guid.NewGuid());
            await localRepository.Insert(audioDrama1);
            await localRepository.Insert(audioDrama2);
            await localRepository.Insert(audioDrama3);

            var audioDramaListView = new AudioDramaListView();

            var ddfGuide = new Core.DdfGuide(
                localRepository,
                audioDramaListView);

            await ddfGuide.Start();

            System.Console.ReadKey();
        }
    }
}

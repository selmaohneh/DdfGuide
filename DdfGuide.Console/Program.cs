using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DdfGuide.Core;
using Repository.Memory;

namespace DdfGuide.Console
{
    internal class Program
    {
        private static async Task Main()
        {
            var audioDramaRepository = new MemoryRepository<AudioDrama>();

            // Add sample items.
            var audioDrama1 = new AudioDrama(Guid.NewGuid());
            var audioDrama2 = new AudioDrama(Guid.NewGuid());
            var audioDrama3 = new AudioDrama(Guid.NewGuid());
            await audioDramaRepository.Insert(audioDrama1);
            await audioDramaRepository.Insert(audioDrama2);
            await audioDramaRepository.Insert(audioDrama3);

            var userDataRepository = new MemoryRepository<AudioDramaUserData>();

            // Add sample items
            var userData1 = new AudioDramaUserData(audioDrama1.Id, true, false);
            var userData2 = new AudioDramaUserData(audioDrama2.Id, false, true);
            var userData3 = new AudioDramaUserData(audioDrama3.Id, true, true);
            await userDataRepository.Insert(userData1);
            await userDataRepository.Insert(userData2);
            await userDataRepository.Insert(userData3);

            var audioDramaListView = new AudioDramaListView();

            var ddfGuide = new Core.DdfGuide(
                audioDramaRepository,
                userDataRepository,
                audioDramaListView);

            await ddfGuide.Start();

            System.Console.ReadKey();
        }
    }
}

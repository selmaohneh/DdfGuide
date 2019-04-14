using System;
using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class ReleaseDateService : IReleaseDateService
    {
        public bool IsReleased(AudioDramaDto dto)
        {
            return dto.ReleaseDate.Date <= DateTime.Now.Date;
        }

        public IEnumerable<AudioDramaDto> GetTodaysReleasesFrom(IEnumerable<AudioDramaDto> dtos)
        {
            var todaysReleases = dtos.Where(x => x.ReleaseDate.Date == DateTime.Now.Date);

            return todaysReleases;
        }
    }
}

using System;

namespace DdfGuide.Core
{
    public class ReleaseDateService : IReleaseDateService
    {
        public bool IsReleased(AudioDramaDto dto)
        {
            return dto.ReleaseDate.Date <= DateTime.Now.Date;
        }
    }
}

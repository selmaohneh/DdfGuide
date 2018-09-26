using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core.Models;

namespace DdfGuide.Core
{
    public static class AudioDramaExtensions
    {
        public static AudioDrama GetById(
            this IEnumerable<AudioDrama> audioDramas,
            Guid id)
        {
            var audioDrama = audioDramas.Single(x => x.AudioDramaDto.Id == id);
            return audioDrama;
        }
    }
}
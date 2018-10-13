using System;
using System.Collections.Generic;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class AndroidDtoProvider : IProvider<IEnumerable<AudioDramaDto>>
    {
        public IEnumerable<AudioDramaDto> Get()
        {
           return new List<AudioDramaDto>();
        }
    }
}
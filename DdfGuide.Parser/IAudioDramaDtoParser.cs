using System;
using System.Collections.Generic;
using DdfGuide.Core;

namespace DdfGuide.Parser
{
    public interface IAudioDramaDtoParser
    {
        bool TryParseNumber(out int? number);
        bool TryParseTitle(out string title);
        bool TryParseReleaseDate(out DateTime releaseDate);
        bool TryParseCoverUrl(out string coverUrl);
        bool TryParseDescription(out string description);
        bool TryParseRoles(out IEnumerable<RoleDto> roles);
        bool TryParseInterpreter(out string interpreter);
    }
}

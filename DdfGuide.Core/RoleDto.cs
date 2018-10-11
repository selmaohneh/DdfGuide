using DdfGuide.Core.Searching;

namespace DdfGuide.Core
{
    public class RoleDto : ISearchable
    {
        public string Character { get; set; }
        public string Speaker { get; set; }

        public RoleDto(string character, string speaker)
        {
            Character = character;
            Speaker = speaker;
        }

        public string ToSearchString()
        {
            return Character + Speaker;
        }
    }
}

namespace DdfGuide.Core
{
    public class RoleDto
    {
        public string Character { get; set; }
        public string Speaker { get; set; }

        public RoleDto(string character, string speaker)
        {
            Character = character;
            Speaker = speaker;
        }
    }
}

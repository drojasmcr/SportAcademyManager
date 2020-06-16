using System.Collections.Generic;

namespace SportAcademyManager.Domain
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PlayerSkill> PlayersSkills { get; set; }
    }
}
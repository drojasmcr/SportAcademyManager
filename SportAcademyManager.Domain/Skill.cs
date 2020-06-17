using System;
using System.Collections.Generic;

namespace SportAcademyManager.Domain
{
    public class Skill : IEquatable<Skill>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PlayerSkill> PlayersSkills { get; set; }

        public bool Equals(Skill other)
        {
            return ( Name == other.Name);
        }
    }
}
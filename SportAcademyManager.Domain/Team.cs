using System;
using System.Collections.Generic;

namespace SportAcademyManager.Domain
{
    public class Team : IEquatable<Team>
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }

        public ICollection<PlayerTeam> PlayerTeams { get; set; }

        public bool Equals(Team other)
        {
            return Name == other.Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public class Team : IEquatable<Team>
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }

        public bool Equals(Team other)
        {
            return Name == other.Name;
        }
    }
}

using System;
using System.Collections.Generic;

namespace SportAcademyManager.Domain
{
    public class Academy : IEquatable<Academy>
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<Category> Categories { get; set; }
        public List<Team> Teams { get; set; }
        public String Address { get; set; }

        public bool Equals(Academy other)
        {
            return Name == other.Name;
        }
    }
}

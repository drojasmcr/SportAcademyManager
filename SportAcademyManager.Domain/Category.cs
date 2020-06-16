using System;
using System.Collections.Generic;

namespace SportAcademyManager.Domain
{
    public class Category : IEquatable<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }
        public List<Team> Teams { get; set; }

        public Category()
        {
            Teams = new List<Team>();
        }

        public bool Equals(Category other)
        {
            return Name == other.Name;
        }
    }
}
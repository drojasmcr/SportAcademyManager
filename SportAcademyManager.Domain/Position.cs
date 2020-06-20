using System;
using System.Collections.Generic;

namespace SportAcademyManager.Domain
{
    public class Position : IEquatable<Position>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PlayerPosition> PlayersPositions { get; set; }

        public bool Equals(Position other)
        {
            return (Name == other.Name);
        }
    }
}
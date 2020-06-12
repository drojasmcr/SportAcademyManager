using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public class Player : Persona
    {
        public Player()
        {
            PlayerPositions = new List<PlayerPosition>();
            Skills = new List<Skill>();
        }
        List<PlayerPosition> PlayerPositions { get; set; }
        public StroongFoot StroongFoot { get; set; }
        public List<Skill> Skills { get; set; }
    }
}

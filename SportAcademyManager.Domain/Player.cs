using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public class Player : Persona
    {
        public List<PlayerPosition> PlayerPositions { get; set; }
        public StrongFoot StrongFoot { get; set; }
        public ICollection<PlayerSkill> PlayersSkills { get; set; }
        public Player(string name, string lastName, string secondLastName,
            string identification, string homeAddress, string phone, StrongFoot strongFoot) 
            : base(name, lastName, secondLastName, identification, homeAddress, phone)
        {
            PlayerPositions = new List<PlayerPosition>();
            StrongFoot = strongFoot;
        }

    }
}

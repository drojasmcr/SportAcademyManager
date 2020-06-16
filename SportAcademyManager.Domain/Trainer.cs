using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public class Trainer : Persona
    {
        public List<Team> TeamsInCharge { get; set; }
        public Trainer(string name, string lastName, string secondLastName,
            string identification, string homeAddress, string phone)
            : base(name, lastName, secondLastName, identification, homeAddress, phone)
        {
            TeamsInCharge = new List<Team>();
        }
    }
}

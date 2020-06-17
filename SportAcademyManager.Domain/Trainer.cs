using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public class Trainer : Persona
    {
        public List<Team> TeamsInCharge { get; set; }
        public Trainer(string name, string lastName, string secondLastName,
            string identification, string homeAddress, string phone, string email)
            : base(name, lastName, secondLastName, identification, homeAddress, phone, email)
        {
            TeamsInCharge = new List<Team>();
        }
    }
}

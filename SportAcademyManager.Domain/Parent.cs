using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public class Parent: Persona
    {
        public Parent(string name, string lastName, string secondLastName,
            string identification, string homeAddress, string phone, string email)
            : base(name, lastName, secondLastName, identification, homeAddress, phone, email)
        {

        }
    }
}

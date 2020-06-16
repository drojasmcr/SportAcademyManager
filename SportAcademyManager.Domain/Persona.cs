using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public abstract class Persona : IEquatable<Persona>
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String SecondLastName { get; set; }
        public String Identification { get; set; }
        public String HomeAddress { get; set; }
        public String Phone { get; set; }

        public Persona(string name, string lastName, string secondLastName, 
            string identification, string homeAddress, string phone)
        {
            Name = name;
            LastName = lastName;
            SecondLastName = secondLastName;
            Identification = identification;
            HomeAddress = homeAddress;
            Phone = phone;
        }

        public Persona()
        {

        }
        public virtual bool Equals(Persona other)
        {
            return (Identification == other.Identification);
        }
    }
}

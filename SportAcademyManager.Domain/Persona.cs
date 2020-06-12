using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String SecondLastName { get; set; }
        public String Identification { get; set; }
        public String HomeAddress { get; set; }
        public String Phone { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace SportAcademyManager.Domain
{
    public class Academy
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<Category> Categories { get; set; }
        public List<Team> Teams { get; set; }
    }
}

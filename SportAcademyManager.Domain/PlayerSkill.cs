using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public class PlayerSkill
    {
        public int PlayerId { get; set; }
        public Player CurrentPlayer { get; set; }
        public int SkillId { get; set; }
        public Skill CurrentSkill { get; set; }
    }
}

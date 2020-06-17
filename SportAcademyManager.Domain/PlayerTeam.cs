using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public class PlayerTeam
    {
        public Player CurrentPlayer { get; set; }
        public int PlayerId { get; set; }
        public Team CurrentTeam { get; set; }
        public int TeamId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Domain
{
    public class PlayerPosition
    {
        public int PlayerId { get; set; }
        public Player CurrentPlayer { get; set; }
        public int PositionId { get; set; }
        public Position CurrentPosition { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public partial class OpenPositions
    {
        public OpenPositions()
        {
            Applications = new HashSet<Applications>();
        }

        public int OpenPositionId { get; set; }
        public int LocationId { get; set; }
        public int PositionId { get; set; }

        public Locations Location { get; set; }
        public Positions Position { get; set; }
        public ICollection<Applications> Applications { get; set; }
    }
}

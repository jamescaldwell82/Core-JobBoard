using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public partial class Positions
    {
        public Positions()
        {
            OpenPositions = new HashSet<OpenPositions>();
        }

        public int PositionId { get; set; }
        public string Title { get; set; }
        public string JobDescription { get; set; }

        public ICollection<OpenPositions> OpenPositions { get; set; }
    }
}

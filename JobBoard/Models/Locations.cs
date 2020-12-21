using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public partial class Locations
    {
        public Locations()
        {
            OpenPositions = new HashSet<OpenPositions>();
        }

        public int LocationId { get; set; }
        public string StoreNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ManagerId { get; set; }

        public UserDetails Manager { get; set; }
        public ICollection<OpenPositions> OpenPositions { get; set; }
    }
}

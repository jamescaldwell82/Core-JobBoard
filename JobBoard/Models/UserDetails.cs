using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public partial class UserDetails
    {
        public UserDetails()
        {
            Applications = new HashSet<Applications>();
            Locations = new HashSet<Locations>();
        }

        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ResumeFileName { get; set; }

        public AspNetUsers User { get; set; }
        public ICollection<Applications> Applications { get; set; }
        public ICollection<Locations> Locations { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public partial class ApplicationStatus
    {
        public ApplicationStatus()
        {
            Applications = new HashSet<Applications>();
        }

        public int ApplicationStatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }

        public ICollection<Applications> Applications { get; set; }
    }
}

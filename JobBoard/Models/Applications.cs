using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public partial class Applications
    {
        public int ApplicationId { get; set; }
        public string UserId { get; set; }
        public int OpenPositionId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string ManagerNotes { get; set; }
        public int ApplicationStatusId { get; set; }
        public string ResumeFileName { get; set; }

        public ApplicationStatus ApplicationStatus { get; set; }
        public OpenPositions OpenPosition { get; set; }
        public UserDetails User { get; set; }
    }
}

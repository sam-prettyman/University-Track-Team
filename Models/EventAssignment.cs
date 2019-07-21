using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityRunningTeam.Models
{
    public class EventAssignment
    {
        public int CoachID { get; set; }
        public int EventID { get; set; }
        public Coach Coach { get; set; }
        public Event Event { get; set; }
    }
}

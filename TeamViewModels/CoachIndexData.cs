using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityRunningTeam.Models;

namespace UniversityRunningTeam.TeamViewModels
{
    public class CoachIndexData
    {

        public IEnumerable<Coach> Coaches{ get; set; }
        public IEnumerable<Event> Event { get; set; }
        public IEnumerable<Trial> Trials { get; set; }
    }
}

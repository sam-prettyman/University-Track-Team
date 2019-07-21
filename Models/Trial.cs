using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityRunningTeam.Models
{
    public enum Place
    {
        First, Second, Third
    }
    public class Trial
    {

        public int TrialID { get; set; }
        public int AthleteID { get; set; }
        public int EventID { get; set; }
        [DisplayFormat(NullDisplayText = "Did not place")]
        public Place? Place { get; set; }
        public Athlete Athlete;
        public Event Event;



    }
}

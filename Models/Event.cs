using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityRunningTeam.Models
{
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int EventID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        public int FieldID { get; set; }
        public Field Field { get; set; }
        public ICollection<Trial> Trials { get; set; }
        public ICollection<EventAssignment> EventAssignments { get; set; }

    }
}

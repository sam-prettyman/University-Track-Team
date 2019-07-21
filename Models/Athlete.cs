using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityRunningTeam.Models
{
    public enum Gender
    {
        Male, Female
    }
    public class Athlete
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }


        public DateTime Dob { get; set; }
        public Gender? Gender { get; set; }
        public int Weight { get; set; }
        public int Height {  get; set; }

        public ICollection<Trial> Trials { get; set; }



    }
}

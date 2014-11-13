using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkScheduleSystem.Entities
{
    
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "The value FirstName is a required field")]
        [StringLength(50, ErrorMessage="FirstName cannot be more than 50 characters")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "The value LastName is a required field")]
        [StringLength(50, ErrorMessage = "LastName cannot be more than 50 characters")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "The value HomePhone is a required field")]
        [StringLength(12, ErrorMessage = "HomePhone cannot be more than 12")]
        public String HomePhone { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }

    }
}

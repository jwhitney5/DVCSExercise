﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSystem.Entities
{
    [Key]
    public class EmployeeSkills
    {
        public int EmployeeSkillID { get; set; }

        [Required(ErrorMessage = "The value EmployeeID is a required field")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "The value SkillID is a required field")]
        public int SkillID { get; set; }

        [Required(ErrorMessage = "The value Level is a required field")]
        public int Level { get; set; }

        [Required(ErrorMessage = "The value YearsOfExperience is a required field")]
        public int YearsOfExperience { get; set; }

        public virtual Skill Skills { get; set; }
        public virtual Employee Employees { get; set; }
    }
}
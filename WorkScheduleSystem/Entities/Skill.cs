﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSystem.Entities
{
    
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }

        [Required(ErrorMessage="Description is required")]
        [StringLength(100, ErrorMessage="Description cannot be more than 100 characters")]
        public String Description { get; set; }

        [Required(ErrorMessage="RequiresTicket is required")]
        public bool RequiresTicket { get; set; }

        public virtual ICollection<EmployeeSkills> EmployeeSkills { get; set; }

    }
}

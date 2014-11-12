using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSystem.POCOs
{
    public class EmployeeSkill
    {
        public String SkillDescription { get; set; }
        public String Name { get; set; }
        public String Phone { get; set; }
        public enum SkillLevel
        {
            Novice,
            Proficent,
            Expert
        }
        public SkillLevel Level { get; set; }
        public int? YearsOfExperience { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using WorkScheduleSystem.Entities;
using WorkScheduleSystem.DAL;
using System.ComponentModel;
using WorkScheduleSystem.POCOs;
#endregion

namespace WorkScheduleSystem.BLL
{
    [DataObject]
    public class ReportController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<EmployeeSkillPOCO> GetEmployeeSKillLevels()
        {
            using (var context = new WorkScheduleContext())
            {
                var results = from cat in context.EmployeeSkills
                              orderby cat.Skill.Description
                              select new EmployeeSkillPOCO()
                              {
                                  SkillDescription = cat.Skill.Description,
                                  Name = cat.Employees.LastName + ", " + cat.Employees.FirstName,
                                  Phone = cat.Employees.HomePhone,
                                  Level = cat.Level.ToString(),
                                  YearsOfExperience = cat.YearsOfExperience
                              };

                return results.ToList(); // this was .Dump() in Linqpad
            }
        }
    }
}

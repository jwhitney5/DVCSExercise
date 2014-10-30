using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using WorkScheduleSystem.Entities;
using System.Data.Entity;
#endregion

namespace WorkScheduleSystem.DAL
{
    public class WorkScheduleContext : DbContext
    {
        public WorkScheduleContext() : base("name=WorkSchedule") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSkills> EmployeeSkills { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PlacementContract> PlacementContracts { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSystem.Entities
{
    [Key]
    public class Schedule
    {
        public int ScheduleID { get; set; }

        [Required(ErrorMessage = "The value Date is a required field")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "The value ShiftID is a required field")]
        public int ShiftID { get; set; }

        [Required(ErrorMessage = "The value EmployeeID is a required field")]
        public int EmployeeID { get; set; }

        public virtual Employee Employees { get; set; }
        public virtual Shift Shifts { get; set; }

    }
}

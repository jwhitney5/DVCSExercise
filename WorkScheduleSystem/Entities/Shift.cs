using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSystem.Entities
{
    
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }

        [Required(ErrorMessage = "PlacementContractID is required")]
        public int PlacementContractID { get; set; }

        [Required(ErrorMessage = "DayOfWeek is required")]
        public int DayOfWeek { get; set; }

        [Required(ErrorMessage = "StartTime is required")]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "EndTime is required")]
        public TimeSpan EndTime { get; set; }

        [Required(ErrorMessage = "NumberOfEmployees is required")]
        public byte NumberOfEmployees { get; set; }

        public bool Active { get; set; }

        [Required(ErrorMessage = "Notes is required")]
        [StringLength(100, ErrorMessage = "Notes cannot be more than 100 characters")]
        public String Notes { get; set; }

        public virtual ICollection<Shift> Shifts { get; set; }
        public virtual PlacementContract PlacementContracts { get; set; }

    }
}

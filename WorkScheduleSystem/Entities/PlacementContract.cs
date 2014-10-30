using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSystem.Entities
{
    [Key]
    public class PlacementContract
    {
        public int PlacementContractID { get; set; }

        [Required(ErrorMessage = "StartDate is required")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "EndDate is required")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "LocationID is required")]
        public int LocationID { get; set; }

        public virtual ICollection<Shift> Shifts { get; set; }
        public virtual Location Locations { get; set; }
    }
}

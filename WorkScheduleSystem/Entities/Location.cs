using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSystem.Entities
{
    
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be more than 50 characters")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Street is required")]
        [StringLength(50, ErrorMessage = "Street cannot be more than 50 characters")]
        public String Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(30, ErrorMessage = "City cannot be more than 30 characters")]
        public String City { get; set; }

        [Required(ErrorMessage = "Province is required")]
        [StringLength(2, ErrorMessage = "Province cannot be more than 2 characters")]
        public String Province { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        [StringLength(50, ErrorMessage = "Contact cannot be more than 50 characters")]
        public String Contact { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [StringLength(12, MinimumLength=12, ErrorMessage = "Phone cannot be more than 12 characters")]
        public String Phone { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<PlacementContract> PlacementContracts { get; set; }
    }
}

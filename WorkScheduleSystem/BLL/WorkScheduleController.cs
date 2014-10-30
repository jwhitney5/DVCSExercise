using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using WorkScheduleSystem.Entities;
using WorkScheduleSystem.DAL;
using System.ComponentModel;
#endregion

namespace WorkScheduleSystem.BLL
{
    [DataObject]
    public class WorkScheduleController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Location> Location_List()
        {
            //interfacing with our Context class
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                // using Context DbSet to get entity data
                //return context.SpecialEvents.ToList();

                //get a list of instances for entity using LINQ
                var results = from item in context.Locations
                              select item;
                return results.ToList();

            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Location LocationByLocationID(int locationid)
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                return context.Locations.Find(locationid);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void Location_Add(Location item)
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                Location added = null;
                added = context.Locations.Add(item);
                // commits the add to the database
                // evaluates the annotations (validations) on your entity
                // [Required],[StringLength],[Range],...
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Location_Update(Location item)
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                context.Entry<Location>(context.Locations.Attach(item)).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

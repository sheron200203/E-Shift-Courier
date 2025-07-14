using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public class Job
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public string Status { get; set; }
        public string AdminNote { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime ScheduledDate { get; set; }
        public DateTime ScheduledTime { get; set; }
        public int ApprovedByAdminID { get; set; }
        public DateTime ApprovedDate { get; set; }
    }

}

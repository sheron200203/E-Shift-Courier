using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public int CustomerId { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime RequestedDate { get; set; }

        public Job() { }

        public Job(int customerId, string start, string end, DateTime date)
        {
            CustomerId = customerId;
            StartLocation = start;
            EndLocation = end;
            RequestedDate = date;
        }
    }


}

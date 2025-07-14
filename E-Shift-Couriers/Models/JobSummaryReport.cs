using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public class JobSummaryReport
    {
        public string JobCode { get; set; }
        public string CustomerName { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Status { get; set; }
    }

}

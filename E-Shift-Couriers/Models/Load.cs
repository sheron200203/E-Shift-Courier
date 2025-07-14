using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public class Load
    {
        public int ID { get; set; }
        public int JobID { get; set; }
        public int ProductID { get; set; }
        public int CreatedByAdminID { get; set; }
    }
}

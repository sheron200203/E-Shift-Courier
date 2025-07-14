using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public class LoadView
    {
        public int LoadId { get; set; }
        public int JobId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string LorryNumber { get; set; }
        public string DriverName { get; set; }
        public string AssistantName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public class TransportUnit
    {
        public int UnitId { get; set; }
        public string LorryNumber { get; set; }
        public string DriverName { get; set; }
        public string AssistantName { get; set; }
        public string ContainerType { get; set; }
    }
}

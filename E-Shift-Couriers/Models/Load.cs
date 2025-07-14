using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public class Load
    {
        public int LoadId { get; set; }
        public int JobId { get; set; }
        public int ProductId { get; set; }
        public int TransportUnitId { get; set; }
        public int Quantity { get; set; }
    }
}

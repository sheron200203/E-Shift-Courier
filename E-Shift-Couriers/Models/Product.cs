using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
        public string Description { get; set; }
        public bool IsFragile { get; set; }
    }
}

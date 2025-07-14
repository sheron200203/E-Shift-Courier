using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Utils
{
    public static class CodeGenerator
    {
        public static string GenerateJobCode()
        {
            string prefix = "JOB";
            string datePart = DateTime.Now.ToString("yyyyMMdd");
            string randomPart = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
            return $"{prefix}-{datePart}-{randomPart}";
        }

        public static string GenerateLoadCode()
        {
            return $"LOAD-{DateTime.Now:yyyyMMdd}-{Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper()}";
        }
    }

}

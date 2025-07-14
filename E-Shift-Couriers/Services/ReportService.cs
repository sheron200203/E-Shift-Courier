using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Services
{
    public class ReportService
    {
        private readonly ReportRepository repo = new ReportRepository();

        public List<JobSummaryReport> GetJobSummaries() => repo.GetJobSummaries();
        public List<CustomerJobCountReport> GetCustomerJobCounts() => repo.GetCustomerJobCounts();
        public List<TransportUtilizationReport> GetTransportUtilizations() => repo.GetTransportUtilizations();
    }
}

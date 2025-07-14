using E_Shift_Couriers.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Repositories
{
    public class ReportRepository
    {
        public List<JobSummaryReport> GetJobSummaries()
        {
            var results = new List<JobSummaryReport>();
            var conn = DbConnection.GetConnection();

            string query = @"
            SELECT j.JobCode, c.Name AS CustomerName, j.RequestedDate, j.Status
            FROM Jobs j
            JOIN Customers c ON j.CustomerId = c.CustomerId
        ";

            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                results.Add(new JobSummaryReport
                {
                    JobCode = reader["JobCode"].ToString(),
                    CustomerName = reader["CustomerName"].ToString(),
                    RequestedDate = Convert.ToDateTime(reader["RequestedDate"]),
                    Status = reader["Status"].ToString()
                });
            }

            reader.Close();
            conn.Close();
            return results;
        }

        public List<CustomerJobCountReport> GetCustomerJobCounts()
        {
            var results = new List<CustomerJobCountReport>();
            var conn = DbConnection.GetConnection();

            string query = @"
            SELECT c.Name AS CustomerName, COUNT(j.JobId) AS JobCount
            FROM Jobs j
            JOIN Customers c ON j.CustomerId = c.CustomerId
            GROUP BY j.CustomerId
        ";

            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                results.Add(new CustomerJobCountReport
                {
                    CustomerName = reader["CustomerName"].ToString(),
                    JobCount = Convert.ToInt32(reader["JobCount"])
                });
            }

            reader.Close();
            conn.Close();
            return results;
        }

        public List<TransportUtilizationReport> GetTransportUtilizations()
        {
            var results = new List<TransportUtilizationReport>();
            var conn = DbConnection.GetConnection();

            string query = @"
            SELECT tu.LorryNumber, COUNT(l.LoadId) AS TotalLoads
            FROM Loads l
            JOIN TransportUnits tu ON l.TransportUnitId = tu.UnitId
            GROUP BY l.TransportUnitId
        ";

            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                results.Add(new TransportUtilizationReport
                {
                    LorryNumber = reader["LorryNumber"].ToString(),
                    TotalLoads = Convert.ToInt32(reader["TotalLoads"])
                });
            }

            reader.Close();
            conn.Close();
            return results;
        }
    }
}

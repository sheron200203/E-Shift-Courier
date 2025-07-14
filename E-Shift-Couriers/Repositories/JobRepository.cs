using E_Shift_Couriers.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shift_Couriers.Utils;

namespace E_Shift_Couriers.Repositories
{
    public class JobRepository
    {
        public void Add(Job job)
        {
            var conn = DbConnection.GetConnection();
            string query = "INSERT INTO Jobs  (JobCode, CustomerId, StartLocation, EndLocation, RequestedDate, Status) " +
                            "VALUES (@code, @cid, @start, @end, @date, @status)";
            var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@code", CodeGenerator.GenerateJobCode());
            cmd.Parameters.AddWithValue("@cid", job.CustomerId);
            cmd.Parameters.AddWithValue("@start", job.StartLocation);
            cmd.Parameters.AddWithValue("@end", job.EndLocation);
            cmd.Parameters.AddWithValue("@date", job.RequestedDate);
            cmd.Parameters.AddWithValue("@status", job.Status);
            cmd.ExecuteNonQuery();

        }



        public List<JobView> GetAll(int userId, bool isAdmin)
        {
            var jobs = new List<JobView>();
            var conn = DbConnection.GetConnection();
            MySql.Data.MySqlClient.MySqlDataReader reader = null;

            string query = @"
SELECT 
    j.JobId,
    j.JobCode,
    j.StartLocation,
    j.EndLocation,
    j.RequestedDate,
    j.Status,
    c.Name AS CustomerName
FROM Jobs j
JOIN Customers c ON j.CustomerId = c.CustomerId";

            if (!isAdmin)
            {
                query += " WHERE j.CustomerId = @userId";
            }

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            if (!isAdmin)
            {
                cmd.Parameters.AddWithValue("@userId", userId);
            }

            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jobs.Add(new JobView
                    {
                        JobCode = reader["JobCode"].ToString(),
                        JobId = Convert.ToInt32(reader["JobId"]),
                        CustomerName = reader["CustomerName"].ToString(),
                        StartLocation = reader["StartLocation"].ToString(),
                        EndLocation = reader["EndLocation"].ToString(),
                        RequestedDate = Convert.ToDateTime(reader["RequestedDate"]),
                        Status = reader["Status"].ToString()
                    });
                }
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }

            return jobs;
        }



        public void UpdateStatus(int jobId, string status)
        {
            var conn = DbConnection.GetConnection();
            string query = "UPDATE Jobs SET Status = @status WHERE JobId = @id";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", jobId);
            cmd.ExecuteNonQuery();
        }

    }
}

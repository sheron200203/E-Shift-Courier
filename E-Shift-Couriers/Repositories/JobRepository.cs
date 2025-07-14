using E_Shift_Couriers.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Repositories
{
    public class JobRepository
    {
        public void Add(Job job)
        {
            var conn = DbConnection.GetConnection();
            string query = "INSERT INTO Jobs (CustomerId, StartLocation, EndLocation, RequestedDate) " +
                            "VALUES (@cid, @start, @end, @date)";
            var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@cid", job.CustomerId);
            cmd.Parameters.AddWithValue("@start", job.StartLocation);
            cmd.Parameters.AddWithValue("@end", job.EndLocation);
            cmd.Parameters.AddWithValue("@date", job.RequestedDate);
            cmd.ExecuteNonQuery();

        }

        public List<Job> GetAll()
        {
            var jobs = new List<Job>();
            var conn = DbConnection.GetConnection();
            string query = "SELECT * FROM Jobs";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Job job = new Job();
                job.JobId = Convert.ToInt32(reader["JobId"]);
                job.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                job.StartLocation = reader["StartLocation"].ToString();
                job.EndLocation = reader["EndLocation"].ToString();
                job.RequestedDate = Convert.ToDateTime(reader["RequestedDate"]);

                jobs.Add(job);
            }
            return jobs;
        }
    }

}

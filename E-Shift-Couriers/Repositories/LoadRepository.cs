using E_Shift_Couriers.Models;
using E_Shift_Couriers.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Repositories
{
    public class LoadRepository
    {
        public void Add(Load load)
        {
            var conn = DbConnection.GetConnection();
            string query = "INSERT INTO Loads  (LoadCode, JobId, ProductId, TransportUnitId, Quantity) " +
                              "VALUES (@code, @job, @product, @unit, @qty)";
            var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@code", CodeGenerator.GenerateLoadCode());
            cmd.Parameters.AddWithValue("@job", load.JobId);
            cmd.Parameters.AddWithValue("@product", load.ProductId);
            cmd.Parameters.AddWithValue("@unit", load.TransportUnitId);
            cmd.Parameters.AddWithValue("@qty", load.Quantity);
            cmd.ExecuteNonQuery();

        }


        public List<LoadView> GetAll(int userId, bool isAdmin)
        {
            var loads = new List<LoadView>();
            var conn = DbConnection.GetConnection();

            string query = @"
        SELECT 
            l.LoadId,
            l.LoadCode,
            l.JobId,
            p.Name AS ProductName,
            l.Quantity,
            u.LorryNumber,
            u.DriverName,
            u.AssistantName,
            j.JobCode
        FROM Loads l
        JOIN Products p ON l.ProductId = p.ProductId
        LEFT JOIN TransportUnits u ON l.TransportUnitId = u.UnitId
        JOIN Jobs j ON l.JobId = j.JobId
    ";

            if (!isAdmin)
            {
                query += " WHERE j.CustomerId = @userId";
            }

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            if (!isAdmin)
            {
                cmd.Parameters.AddWithValue("@userId", userId);
            }

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                loads.Add(new LoadView
                {
                    LoadCode = reader["LoadCode"].ToString(),
                    LoadId = Convert.ToInt32(reader["LoadId"]),
                    JobCode = reader["JobCode"].ToString(),
                    ProductName = reader["ProductName"].ToString(),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    LorryNumber = reader["LorryNumber"].ToString(),
                    DriverName = reader["DriverName"].ToString(),
                    AssistantName = reader["AssistantName"].ToString()
                });
            }

            reader.Close();
            conn.Close();

            return loads;
        }


    }

}
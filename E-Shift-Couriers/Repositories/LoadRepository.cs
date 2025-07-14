using E_Shift_Couriers.Models;
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
            string query = "INSERT INTO Loads (JobId, ProductId, TransportUnitId, Quantity) " +
                              "VALUES (@job, @product, @unit, @qty)";
            var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@job", load.JobId);
            cmd.Parameters.AddWithValue("@product", load.ProductId);
            cmd.Parameters.AddWithValue("@unit", load.TransportUnitId);
            cmd.Parameters.AddWithValue("@qty", load.Quantity);
            cmd.ExecuteNonQuery();

        }

        public List<Load> GetAllRaw()
        {
            var loads = new List<Load>();
            var conn = DbConnection.GetConnection();
            string query = "SELECT * FROM Loads";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Load load = new Load();
                load.LoadId = Convert.ToInt32(reader["LoadId"]);
                load.JobId = Convert.ToInt32(reader["JobId"]);
                load.ProductId = Convert.ToInt32(reader["ProductId"]);
                load.TransportUnitId = Convert.ToInt32(reader["TransportUnitId"]);
                load.Quantity = Convert.ToInt32(reader["Quantity"]);

                loads.Add(load);
            }

            return loads;
        }

        public List<LoadView> GetAll()
        {
            var loads = new List<LoadView>();
            var conn = DbConnection.GetConnection();
            string query = @"SELECT 
                        l.LoadId,
                        l.Quantity,
                        j.JobId,
                        p.Name AS ProductName,
                        t.LorryNumber,
                        t.DriverName,
                        t.AssistantName
                    FROM Loads l
                    JOIN Jobs j ON l.JobId = j.JobId
                    JOIN Products p ON l.ProductId = p.ProductId
                    JOIN TransportUnits t ON l.TransportUnitId = t.UnitId";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                var load = new LoadView
                {
                    LoadId = Convert.ToInt32(reader["LoadId"]),
                    JobId = Convert.ToInt32(reader["JobId"]),
                    ProductName = reader["ProductName"].ToString(),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    LorryNumber = reader["LorryNumber"].ToString(),
                    DriverName = reader["DriverName"].ToString(),
                    AssistantName = reader["AssistantName"].ToString()
                };

                loads.Add(load);
            }

            reader.Close();
            conn.Close();

            return loads;
        }

    }

}
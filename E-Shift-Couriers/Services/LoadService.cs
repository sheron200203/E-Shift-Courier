using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shift_Couriers.Auth;
using E_Shift_Couriers.Enums;

namespace E_Shift_Couriers.Services
{
    public class LoadService
    {
        private readonly LoadRepository repo = new LoadRepository();

        public void AddLoad(Load load)
        {
            repo.Add(load);
        }

        public List<LoadView> GetAllLoads()
        {
            var userId = Session.CurrentUser.Id;
            var isAdmin = Session.CurrentUser.Role == UserRole.Admin;
            return repo.GetAll(userId,isAdmin);
        }


        public List<LoadView> GetAll(int userId, bool isAdmin)
        {
            var loads = new List<LoadView>();
            var conn = DbConnection.GetConnection();

            string query = @"
        SELECT 
            l.LoadId,
            l.JobId,
            p.Name AS ProductName,
            l.Quantity,
            u.LorryNumber,
            u.DriverName,
            u.AssistantName
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
                    LoadId = Convert.ToInt32(reader["LoadId"]),
                    JobId = Convert.ToInt32(reader["JobId"]),
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

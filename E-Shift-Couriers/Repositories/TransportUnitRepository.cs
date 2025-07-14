using E_Shift_Couriers.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Repositories
{
    public class TransportUnitRepository
    {
        public void Add(TransportUnit unit)
        {
            var conn = DbConnection.GetConnection();
            string query = "INSERT INTO TransportUnits (LorryNumber, DriverName, AssistantName, ContainerType) " +
                             "VALUES (@lorry, @driver, @assistant, @container)";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@lorry", unit.LorryNumber);
            cmd.Parameters.AddWithValue("@driver", unit.DriverName);
            cmd.Parameters.AddWithValue("@assistant", unit.AssistantName);
            cmd.Parameters.AddWithValue("@container", unit.ContainerType);
            cmd.ExecuteNonQuery();
        }

        public List<TransportUnit> GetAll()
        {
            var units = new List<TransportUnit>();
            var conn = DbConnection.GetConnection();
            string query = "SELECT * FROM TransportUnits";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TransportUnit unit = new TransportUnit();
                unit.UnitId = Convert.ToInt32(reader["UnitId"]);
                unit.LorryNumber = reader["LorryNumber"].ToString();
                unit.DriverName = reader["DriverName"].ToString();
                unit.AssistantName = reader["AssistantName"].ToString();
                unit.ContainerType = reader["ContainerType"].ToString();
                units.Add(unit);
            }

            return units;
        }
    }

}

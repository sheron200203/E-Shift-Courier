using E_Shift_Couriers.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace E_Shift_Couriers.Repositories
{
    public class AdminRepository
    {
        private readonly string connectionString;

        public AdminRepository(string connStr)
        {
            connectionString = connStr;
        }

        public Admin GetByUsername(string username)
        {
            var conn = DbConnection.GetConnection();
            var cmd = new MySqlCommand("SELECT * FROM Admins WHERE Username = @username", conn);
            cmd.Parameters.AddWithValue("@username", username);

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Admin
                {
                    Id = reader.GetInt32(reader.GetOrdinal("AdminId")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    PasswordHash = reader.GetString(reader.GetOrdinal("passwordHash")),                                                                
                };
            }
            return null;
        }
    }
}

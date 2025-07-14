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

        public bool UpdateAdmin(Admin admin)
        {
            using (var conn = DbConnection.GetConnection())
            {
                string query = "UPDATE Admins SET Username = @username, passwordHash = @password WHERE AdminId = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", admin.Username);
                    cmd.Parameters.AddWithValue("@password", admin.PasswordHash);
                    cmd.Parameters.AddWithValue("@id", admin.Id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public Admin GetById(int id)
        {
            using (var conn = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Admins WHERE AdminId = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Admin
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("AdminId")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                PasswordHash = reader.GetString(reader.GetOrdinal("passwordHash"))
                                
                            };
                        }
                    }
                }
            }
            return null; 
        }

    }
}

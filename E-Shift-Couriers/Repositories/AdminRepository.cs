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
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();

                var cmd = new MySqlCommand("SELECT * FROM Admin WHERE userName = @username", conn);
                cmd.Parameters.AddWithValue("@username", username);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Admin
                    {
                        ID = reader.GetInt32("ID"),
                        UserName = reader.GetString("userName"),
                        Password = reader.GetString("password"),
                        Name = reader.GetString("name")
                    };
                }

                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }
    }
}

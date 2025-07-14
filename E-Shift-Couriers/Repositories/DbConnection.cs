using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Repositories
{
    public static class DbConnection
    {
        /// <summary>
        /// Gets a new open MySQL connection using the connection string from App.config
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            var connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                throw new Exception("MySQL connection failed: " + ex.Message);
            }
        }
    }
}

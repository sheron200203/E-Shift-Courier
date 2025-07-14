using E_Shift_Couriers.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace E_Shift_Couriers.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> GetAll()
        {
            var customers = new List<Customer>();
            var conn = DbConnection.GetConnection();
            string query = "SELECT CustomerId, Name, Email, Phone FROM Customers";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    ID = reader.GetInt32("CustomerId"),
                    Name = reader.GetString("Name"),
                    Email = reader.GetString("Email"),
                    Phone = reader.GetString("Phone")
                });
            }
            return customers;
        }

        public Customer GetById(int id)
        {
            var conn = DbConnection.GetConnection();
            string query = "SELECT CustomerId, Name, Email, Phone FROM Customers WHERE CustomerId = @id";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Customer
                {
                    ID = reader.GetInt32("CustomerId"),
                    Name = reader.GetString("Name"),
                    Email = reader.GetString("Email"),
                    Phone = reader.GetString("Phone")
                };
            }
            return null;
        }

        public void Add(Customer customer)
        {
            var conn = DbConnection.GetConnection();
            string query = "INSERT INTO Customers (Name, Email, Phone) VALUES (@name, @email, @phone)";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", customer.Name);
            cmd.Parameters.AddWithValue("@email", customer.Email);
            cmd.Parameters.AddWithValue("@phone", customer.Phone);
            cmd.ExecuteNonQuery();

            // Optionally fetch last inserted ID and assign to customer.ID
            customer.ID = (int)cmd.LastInsertedId;
        }
    }
}

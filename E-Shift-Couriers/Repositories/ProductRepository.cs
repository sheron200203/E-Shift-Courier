using E_Shift_Couriers.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Repositories
{
    public class ProductRepository
    {
        public void Add(Product product)
        {
            var conn = DbConnection.GetConnection();
            string query = "INSERT INTO Products (Name, Description) VALUES (@name, @desc)";
            var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@desc", product.Description);
            cmd.ExecuteNonQuery();

        }

        public List<Product> GetAll()
        {
            var products = new List<Product>();
            var conn = DbConnection.GetConnection();
            string query = "SELECT * FROM Products";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.Name = reader["Name"].ToString();
                product.Description = reader["Description"].ToString();
                products.Add(product);
            }

            return products;
        }
    }
}

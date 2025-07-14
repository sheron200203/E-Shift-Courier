using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Services
{
    public class ProductService
    {
        private readonly ProductRepository repo = new ProductRepository();

        public void AddProduct(Product product)
        {
            repo.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return repo.GetAll();
        }
    }
}

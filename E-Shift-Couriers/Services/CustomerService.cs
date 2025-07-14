using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
using System.Collections.Generic;

namespace E_Shift_Couriers.Services
{
    public class CustomerService : Interfaces.ICustomerService
    {
        private readonly CustomerRepository _repo = new CustomerRepository();

        public void AddCustomer(Customer customer)
        {
            _repo.Add(customer);
        }

        public Customer GetCustomerById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Customer> GetAllCustomers()
        {
            return _repo.GetAll();
        }
    }
}

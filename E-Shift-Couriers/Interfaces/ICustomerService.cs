using E_Shift_Couriers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Interfaces
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        Customer GetCustomerById(int id);
        List<Customer> GetAllCustomers();
    }
}

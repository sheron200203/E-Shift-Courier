using E_Shift_Couriers.Interfaces;
using E_Shift_Couriers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shift_Couriers.Utils;

namespace E_Shift_Couriers.Services
{
    public class AuthService
    {
        private AdminRepository _adminRepo;
        private CustomerRepository _customerRepo;

        public AuthService(AdminRepository adminRepo, CustomerRepository customerRepo)
        {
            _adminRepo = adminRepo;
            _customerRepo = customerRepo;
        }

        public IUser Login(string username, string password)
        {
         
            var admin = _adminRepo.GetByUsername(username);
            if (admin != null && PasswordHasher.Verify(password, admin.PasswordHash))
            {
                return admin;
            }

         
            var customer = _customerRepo.GetByUsername(username);
            if (customer != null && PasswordHasher.Verify(password, customer.PasswordHash))
            {
                return customer;
            }

            return null; 
        }
    }

}

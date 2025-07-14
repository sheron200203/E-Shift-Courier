using E_Shift_Couriers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{

    public class Customer : E_Shift_Couriers.Interfaces.IUser
    {
        public int Id { get; set; }
        public string Username { get; set; } 
        public string PasswordHash { get; set; }
        public UserRole Role => UserRole.Customer;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public Customer() { }
        public Customer(int id, string name, string email, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}

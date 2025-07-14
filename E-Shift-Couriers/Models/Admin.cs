using E_Shift_Couriers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public class Admin: E_Shift_Couriers.Interfaces.IUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role => UserRole.Admin;
    }
}

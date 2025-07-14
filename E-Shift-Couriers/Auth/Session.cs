using E_Shift_Couriers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Auth
{
    public static class Session
    {
        public static User CurrentUser { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public UserRole Role { get; set; } 
    }
}

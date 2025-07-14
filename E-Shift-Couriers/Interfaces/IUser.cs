using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shift_Couriers.Enums;

namespace E_Shift_Couriers.Interfaces
{
    public interface IUser
    {
        int Id { get; }
        string Username { get; }
        UserRole Role { get; }
    }
}

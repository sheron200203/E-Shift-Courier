using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Services
{
    public class AdminService
    {
        private readonly AdminRepository _repo = new AdminRepository();

        public bool UpdateAdmin(Admin admin)
        {
            return _repo.UpdateAdmin(admin);
        }
    }
}

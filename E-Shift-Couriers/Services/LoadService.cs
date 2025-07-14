using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shift_Couriers.Auth;
using E_Shift_Couriers.Enums;

namespace E_Shift_Couriers.Services
{
    public class LoadService
    {
        private readonly LoadRepository repo = new LoadRepository();

        public void AddLoad(Load load)
        {
            repo.Add(load);
        }

        public List<LoadView> GetAllLoads()
        {
            var userId = Session.CurrentUser.Id;
            var isAdmin = Session.CurrentUser.Role == UserRole.Admin;
            return repo.GetAll(userId, isAdmin);
        }

        public void AssignTransportUnit(int loadId, int unitId)
        {
            repo.AssignTransportUnit(loadId, unitId);
        }
    }
}

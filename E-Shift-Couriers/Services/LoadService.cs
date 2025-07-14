using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Services
{
    public class LoadService
    {
        private readonly LoadRepository repo = new LoadRepository();

        public void AddLoad(Load load)
        {
            repo.Add(load);
        }

        public List<Load> GetAllLoads()
        {
            return repo.GetAll();
        }
    }
}

using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Services
{

    public class TransportUnitService
    {
        private readonly TransportUnitRepository repo = new TransportUnitRepository();

        public void AddUnit(TransportUnit unit)
        {
            repo.Add(unit);
        }

        public List<TransportUnit> GetAllUnits()
        {
            return repo.GetAll();
        }
    }
}

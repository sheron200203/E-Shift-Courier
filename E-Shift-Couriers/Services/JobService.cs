using E_Shift_Couriers.Enums;
using E_Shift_Couriers.Models;
using E_Shift_Couriers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shift_Couriers.Auth;

namespace E_Shift_Couriers.Services
{
    public class JobService
    {
        private readonly JobRepository repo = new JobRepository();

        public void AddJob(Job job)
        {
            repo.Add(job);
        }

        public List<JobView> GetAllJobs()
        {
            var userId = Session.CurrentUser.Id;
            var isAdmin = Session.CurrentUser.Role == UserRole.Admin;
            return repo.GetAll(userId, isAdmin);
        }

        public void UpdateStatus(int jobId, string status)
        {
            var userId = Session.CurrentUser.Id;
            var isAdmin = Session.CurrentUser.Role == UserRole.Admin;
            if(!isAdmin)
            {
                throw new UnauthorizedAccessException("Only admins can update job status.");
            }
            repo.UpdateStatus(jobId, status);
        }
    }
}

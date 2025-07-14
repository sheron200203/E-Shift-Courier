using E_Shift_Couriers.Enums;
using E_Shift_Couriers.Interfaces;
using E_Shift_Couriers.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Models
{
    public abstract class UserBase : IUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public UserRole Role { get; set; }

        public string PasswordHash { get; protected set; }

        // Internal constructor for loading from DB
        internal UserBase(string passwordHash)
        {
            PasswordHash = passwordHash;
        }

        protected UserBase() { }

        public void SetPassword(string plainTextPassword)
        {
            PasswordHash = PasswordHasher.Hash(plainTextPassword);
        }

        public bool VerifyPassword(string input)
        {
            return PasswordHasher.Verify(input, PasswordHash);
        }
    }

}

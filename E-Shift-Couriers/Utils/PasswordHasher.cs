using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift_Couriers.Utils
{
    public static class PasswordHasher
    {
        public static string Hash(string password)
        {
            var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        public static bool Verify(string input, string storedHash)
        {
            string inputHash = Hash(input).Trim();
            return inputHash == storedHash.Trim(); 
        }
    }
}

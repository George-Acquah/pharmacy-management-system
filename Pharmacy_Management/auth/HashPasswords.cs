using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Pharmacy_Management.auth
{
    public static class HashPasswords
    {
        public static string HashFunction(string password)
        {
            using (SHA256 hashAlgorithm = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = hashAlgorithm.ComputeHash(passwordBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
             }
        }
    }
}

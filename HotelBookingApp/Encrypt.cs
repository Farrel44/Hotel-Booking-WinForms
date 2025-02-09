using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp
{
    class Encrypt
    {
        public string PashHash(string data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashData = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(hashData).Replace("-", "").ToLower();
            }
        }
    }
}

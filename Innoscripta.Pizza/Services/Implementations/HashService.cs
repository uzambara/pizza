using System;
using System.Security.Cryptography;
using System.Text;
using Innoscripta.Pizza.Services.Interfaces;

namespace Innoscripta.Pizza.Services.Implementations
{
    public class HashService: IHashService
    {
        public bool VerifyPassword(string hashedPassword, string password)
        {
            var hash = HashPassword(password);
            return hashedPassword == hash;
        }

        public string HashPassword(string password)
        {
            var data = Encoding.ASCII.GetBytes(password);
            var md5 = new MD5CryptoServiceProvider();
            var hashed = md5.ComputeHash(data);
            return Convert.ToBase64String(hashed);
        }
    }
}
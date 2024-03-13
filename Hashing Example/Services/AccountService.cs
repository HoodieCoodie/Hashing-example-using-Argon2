using System;
using System.Security.Cryptography;
using System.Text;
using Isopoh.Cryptography.Argon2;

namespace Hashing_Example.Services
{

    public class AccountService
    {
        public string GetHash(string input)
        {
            var hash = Argon2.Hash(input);

            return hash.ToString();
        }
    }
}

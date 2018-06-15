using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RPAPI.Models;

namespace RPAPI.Data
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            _context = context;
        }
        public void SeedUsers()
        {
            //_context.Users.RemoveRange(_context.Users); //Remove users
           // _context.SaveChanges(); // Update database

            // seed users
            var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
            var users = JsonConvert.DeserializeObject<List<User>>(userData);
            foreach (var user in users)
            {
                // create the password hash
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash("paswword", out passwordHash, out passwordSalt);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.Username=user.Username.ToLower();
                _context.Users.Add(user);
                Console.WriteLine("Creating User: "+user.Username);
            }
            _context.SaveChanges();
        }
         private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt=hmac.Key;
                passwordHash=hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }   
    }
}
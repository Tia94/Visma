using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visma.Core.Application;
using Visma.Core.Domain;

namespace Visma.Core.DataStore
{
   public class UserRepository : IUserRepository
    {
        public List<User> users = new List<User>();  //should be private but here I put it public for testing purposes 

        public bool AddUser(User user)
        {
            if (users.Any(u => u.Email == user.Email)) return false;

            users.Add(user);

            return true;
        }

        public User GetUser(string userEmail)
        {
            return users.FirstOrDefault(u => u.Email == userEmail);
        }
    }
}

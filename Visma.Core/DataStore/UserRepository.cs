using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visma.Core.Domain;

namespace Visma.Core.Application
{
    class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>();

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

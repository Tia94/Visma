using System;
using System.Collections.Generic;
using System.Text;
using Visma.Core.Domain;

namespace Visma.Core.Application
{
    public class UserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void RegisterUser(string name, string email, string department, string password)
        {
            var user = new User(name, email, department, password);

            userRepository.AddUser(user);
        }

        public void AssignRoleToUser(Role role, string userEmail)
        {
            var user = userRepository.GetUser(userEmail);

            if (role == null)
            {
                throw new ArgumentException("The role does not exist");
            }
            if (user == null)
            {
                throw new ArgumentException("The user does not exist");
            }

            user.AssignRoles(role);
        }

        public List<Permission> DetermineUserPermissions(string userEmail)
        {
            var user = userRepository.GetUser(userEmail);
            var permissions = user.DeterminePermissions();
            return permissions;
        }
    }
}

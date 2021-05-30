using System;
using System.Collections.Generic;
using System.Text;
using Visma.Core.Application;
using Visma.Core.DataStore;
using Visma.Core.Domain;
using Xunit;

namespace Visma.Core.Tests.Application
{
   public class UserServiceTests
    {
        [Fact]
        public void CanRegisterUser()
        {
            const string name = "name";
            const string email = "email";
            const string department = "department";
            const string password = "password";
            var userRepo = new UserRepository();
            var userService = new UserService(userRepo);

            userService.RegisterUser(name, email, department, password);

            Assert.Contains(userRepo.users, item => item.Name == name);
            Assert.Contains(userRepo.users, item => item.Email == email);
            Assert.Contains(userRepo.users, item => item.Department == department);
            Assert.Contains(userRepo.users, item => item.Password == password);

        }

        [Fact]
        public void AssignRoleToUser()
        {
            const string name = "name";
            const string email = "email";
            const string department = "department";
            const string password = "password";
            var userRepo = new UserRepository();
            var userService = new UserService(userRepo);
            var role = new Role("RoleName", new List<Permission>());
            var user = new User(name, email, department, password);

            userRepo.AddUser(user);
            userService.AssignRoleToUser(role, email);
            var userFromRepo = userRepo.GetUser(email);

            Assert.Contains(role, userFromRepo.Roles);

        }
    }
}

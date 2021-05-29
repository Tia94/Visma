using System;
using System.Collections.Generic;
using System.Text;
using Visma.Core.Domain;
using Xunit;

namespace Visma.Core.Tests.Domain
{
    public class UserTests
    {
        [Fact]
        public void CanCreateUser()
        {
            // Arrange
            const string name = "name";
            const string email = "email";
            const string department = "department";
            const string password = "password";

            //Act
            var user = new User(name, email, department, password);

            //Assert
            Assert.Equal(name, user.Name);
            Assert.Equal(email, user.Email);
            Assert.Equal(department, user.Department);
            Assert.Equal(password, user.Password);
        }

        [Fact]
        public void CanAdoptOneRole()
        {
            // Arrange
            var user = new User("name", "email", "department", "password");
            var role = new Role("Employee", new List<Permission>());

            // Act
            user.AssignRoles(role);

            //Assert
            Assert.Contains(role, user.Roles);
        }

        [Fact]
        public void CanAdoptMltipleRoles()
        {
            var user = new User("name", "email", "department", "password");
            var firstRole = new Role("firstRole", new List<Permission>());
            var secondRole = new Role("secondRole", new List<Permission>());

            user.AssignRoles(firstRole, secondRole);
            
            Assert.Contains(firstRole, user.Roles);
            Assert.Contains(secondRole, user.Roles);

        }

        [Fact]
        public void DeterminePermission()
        {
            var user = new User("name", "email", "department", "password");
            var firstRole = new Role("firstRole", new List<Permission> { Permission.Delete });
            var secondRole = new Role("secondRole", new List<Permission> { Permission.Add });

            user.AssignRoles(firstRole, secondRole);
            var perm = user.DeterminePermissions();

            Assert.Contains(Permission.Delete, perm);
            Assert.Contains(Permission.Add, perm);

        }
    }
}

using System;
using System.Text;
using Visma.Core.DataStore;
using Visma.Core.Domain;
using Xunit;

namespace Visma.Core.Tests.DataStore
{
   public class UserRepositoryTests
    {
        [Fact]
        public void CanAddUser()
        {
            var usrerRepository = new UserRepository();
            var user = new User("name", "email", "department", "password");

            usrerRepository.AddUser(user);

            Assert.Contains(user, usrerRepository.users);
        }

        [Fact]
        public void CanNotAddUsersWithSameEmail()
        {
            var usrerRepository = new UserRepository();
            var user = new User("name", "email", "department", "password");
            var secondUser = new User("secondName", "email", "secondDepartment", "secondePassword");

            usrerRepository.AddUser(user);
            usrerRepository.AddUser(secondUser);

            Assert.DoesNotContain(secondUser, usrerRepository.users);
        }

        [Fact]
        public void CanGetUser()
        {
            var usrerRepository = new UserRepository();
            var user = new User("name", "email", "department", "password");
            
            usrerRepository.AddUser(user);
            var userFromRepo = usrerRepository.GetUser(user.Email);

            Assert.Equal(userFromRepo, user);
            Assert.Null(usrerRepository.GetUser("other email"));
        }
    }
}

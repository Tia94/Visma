using System;
using System.Collections.Generic;
using System.Text;
using Visma.Core.DataStore;
using Visma.Core.Domain;
using Xunit;

namespace Visma.Core.Tests.DataStore
{
    public class RoleRepositoryTests
    {
        [Fact]
        public void CanAddRole()
        {
            var roleRepository = new RoleRepository();
            var role = new Role("roleName", new List<Permission>());

            roleRepository.AddRole(role);

            Assert.Contains(role, roleRepository.roles);
        }

        [Fact]
        public void CanGetRole()
        {
            var roleRepository = new RoleRepository();
            var role = new Role("roleName", new List<Permission>());

            roleRepository.AddRole(role);
            var roleFromRepo = roleRepository.GetRole("roleName");

            Assert.Equal(roleFromRepo, role);
            Assert.Null(roleRepository.GetRole("nameRole"));
        }
    }
}

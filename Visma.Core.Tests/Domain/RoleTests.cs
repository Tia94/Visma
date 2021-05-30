using System;
using System.Collections.Generic;
using System.Text;
using Visma.Core.Domain;
using Xunit;

namespace Visma.Core.Tests.Domain
{
    public class RoleTests
    {
        [Fact]
        public void CanCreateRole()
        {
            const string roleName = "roleName";
            List<Permission> permission = new List<Permission>();

            var role = new Role(roleName, permission);

            Assert.Equal(roleName, role.Name);
        }

        [Fact]
        public void AnyRoleCanRead()
        {
            var role = new Role("Role", new List<Permission> { Permission.Update });

            Assert.Contains(Permission.Read, role.Permissions);
        }

        [Fact]
        public void CanAssignPermission()
        {
            var permission = new List<Permission> { Permission.Read, Permission.Delete };
            var role = new Role("Role Name", new List<Permission>());

            role.AssignPermission(permission);

            Assert.Contains(Permission.Read, role.Permissions);
            Assert.Contains(Permission.Delete, role.Permissions);
        }
    }
}

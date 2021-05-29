﻿using Visma.Core.Domain;
using Xunit;
using System.Collections.Generic;

namespace Visma.Core.Tests.Domain
{
    public class ManagerRoleTests
    {
        [Theory]
        [InlineData(Permission.Read)]
        [InlineData(Permission.Update)]
        [InlineData(Permission.Add)]
        [InlineData(Permission.Delete)]
        public void ManagerHasPermission(Permission permission)
        {
            var manager = new ManagerRole();
            Assert.Contains(permission, manager.Permissions);
        }
    }

    public class RoleTests
    {
        [Fact]
        public void AnyRoleCanRead()
        {
            var role = new Role("Role", new List<Permission> { Permission.Update });
            Assert.Contains(Permission.Read, role.Permissions);
        }
    }

}

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
        public void AnyRoleCanRead()
        {
            var role = new Role("Role", new List<Permission> { Permission.Update });
            Assert.Contains(Permission.Read, role.Permissions);
        }
    }

}

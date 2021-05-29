using System;
using System.Collections.Generic;
using System.Text;
using Visma.Core.Domain;
using Xunit;

namespace Visma.Core.Tests.Domain
{
    public class EmployeeRoleTests
    {
        [Fact]
        public void EmployeeRoleCanRead()
        {
            var employee = new EmployeeRole();
            Assert.Contains(Permission.Read, employee.Permissions);
        }
    }

}

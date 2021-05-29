using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visma.Core.Domain
{
    public class EmployeeRole
    {
        public string Name { get; set; } 
        public List<Permission> Permissions = new List<Permission> { Permission.Read };

        public EmployeeRole() : this("Employee", new List<Permission>())
        {
        }

        protected EmployeeRole(string Name, List<Permission> permissions)
        {
            this.Name = Name;
            this.Permissions = this.Permissions.Union(permissions).ToList();
        }
    }
}

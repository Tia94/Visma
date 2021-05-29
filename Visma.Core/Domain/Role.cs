using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visma.Core.Domain
{
    public class Role : EmployeeRole
    {
        public Role(string name, List<Permission> permissions) : base(name, permissions)
        {

        }

        public void AssignPermission(List<Permission> permission)
        {
            Permissions.Clear();
            foreach (var perm in permission)
            {
                if (!Permissions.Contains(perm))
                {
                     Permissions.Add(perm);
                }
            }
        }
    }
}

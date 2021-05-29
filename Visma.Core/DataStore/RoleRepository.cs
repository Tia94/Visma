using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visma.Core.Domain;

namespace Visma.Core.DataStore
{
    public class RoleRepository
    {
        private List<Role> roles = new List<Role>();

        public bool AddRole(Role role)
        {
            if (roles.Any(r => r.Name == role.Name)) return false;
            roles.Add(role);
            return true;
        }

        public Role GetRole(string name)
        {
            return roles.FirstOrDefault(r => r.Name == name);
        }
    }
}

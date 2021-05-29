using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visma.Core.Domain
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }
        public List<Role> Roles = new List<Role>();

        public User(string name, string email, string department, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Department = department;
            this.Password = password;
        }

        public void AssignRole(Role role)
        {
            Roles.Add(role);
        }

        public void AssignRoles(params Role[] roles)
        {
            foreach (var r in roles)
            {
                AssignRole(r);
            }
        }

        public List<Permission> DeterminePermissions()
        {
            var result = new List<Permission>();

            foreach (var role in Roles)
            {
                result = result.Union(role.Permissions).ToList();
            }
            return result;
        }
    }
}

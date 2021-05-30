using System;
using System.Collections.Generic;
using System.Text;
using Visma.Core.Domain;

namespace Visma.Core.Application
{
    public class RoleService
    {
        private readonly IRoleRepository roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public void RegisterRole(string name, List<Permission> permissions)
        {
            var role = new Role(name, permissions);
            roleRepository.AddRole(role);

        }

        public void AssignPermissions(string roleName, List<Permission> permissions)
        {
            var role = roleRepository.GetRole(roleName);
            if (role == null)
            {
                throw new ArgumentException("The role does not exist");
            }
            role.AssignPermission(permissions);
        }

    }
}

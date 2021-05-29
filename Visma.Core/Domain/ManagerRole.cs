using System;
using System.Collections.Generic;
using System.Text;

namespace Visma.Core.Domain
{
   public class ManagerRole : EmployeeRole
    {
        public ManagerRole() : base("Manager", new List<Permission> { Permission.Add, Permission.Update, Permission.Delete })
        {

        }

        public void Notify()
        {

        }
    }
}

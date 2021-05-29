using System;
using System.Collections.Generic;
using System.Text;
using Visma.Core.Domain;

namespace Visma.Core.Application
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        User GetUser(string userEmail);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using Visma.Core.Domain;

namespace Visma.Core.Application
{
   public interface IRoleRepository
    {
        bool AddRole(Role role);
        Role GetRole(string name);
    }
}

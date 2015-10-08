using Kylinariia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Service
{
    public class RoleService
    {
        List<Role> roles = new List<Role>();

        public void Add(Role item)
        { roles.Add(item); }
        public bool Remove(Role item)
        { return roles.Remove(item); }
    }
}

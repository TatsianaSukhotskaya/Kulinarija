using Kylinariia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Service
{
    public class CommonUserService
    {
        private List<CommonUser> users = new List<CommonUser>();

        public void Add(object NewUser)
        {
            users.Add((CommonUser)NewUser);
        }


        public void Delete(object User)
        {
            users.Remove((CommonUser)User);
        }

        public List<CommonUser> GetAll()
        {
            return users;
        }

        public bool Contains(CommonUser item)
        {
            return users.Contains(item);
        }
    }
}

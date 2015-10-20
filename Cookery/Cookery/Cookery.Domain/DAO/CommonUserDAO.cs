using Kylinariia.Domain.Model;
using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.Cookery.Domain.DAO
{
    public class CommonUserDAO:BaseModel
    {
        private List<CommonUserDao> _users = new List<CommonUserDao>();

        public void Add(CommonUserDao item)
        { _users.Add(item); }

        public bool Remove (CommonUserDao item)
        { return _users.Remove(item); }

        public CommonUserDao Get(int id)
        {
            return _users.SingleOrDefault((CommonUserDao a) => a.Id == id);
        }

        public List<CommonUserDao> GetAll()
        { return _users; }

        public void Clear()
        { _users.Clear(); }


    }
}

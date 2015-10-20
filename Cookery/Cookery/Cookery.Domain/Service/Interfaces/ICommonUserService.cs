using Kylinariia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Service
{
    public interface ICommonUserService
    {
        
        void Add(CommonUserDao item);
        void Get(CommonUserDao item);
        List<CommonUserDao> Get();
        void Update(CommonUserDao item);
        void Delete(int id);
    }
}

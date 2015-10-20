using Kylinariia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Service
{
    public interface ICommonUserService
    {
        
        void Add(CommonUser item);
        void Get(CommonUser item);
        List<CommonUser> Get();
        void Update(CommonUser item);
        void Delete(int id);
    }
}

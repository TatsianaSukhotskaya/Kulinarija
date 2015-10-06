using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Service
{
    public interface IService
    {
         void Add(object item);
        void Delete(object a);
        
        void Update();

    }
}

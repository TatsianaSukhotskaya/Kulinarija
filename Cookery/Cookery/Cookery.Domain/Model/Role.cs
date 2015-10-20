using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Role:BaseModel
    {
        private string name;

        public Role(string v)
        {
            this.name = v;
        }

        
        
    }
}

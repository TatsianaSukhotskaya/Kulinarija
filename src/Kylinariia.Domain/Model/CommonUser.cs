using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public abstract class CommonUser:BaseModel
    {
        public string name { get;set; }
        public DateTime date { get; set; }
    }
}

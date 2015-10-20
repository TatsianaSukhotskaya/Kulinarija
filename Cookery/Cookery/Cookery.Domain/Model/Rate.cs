using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Rate:BaseModel
    {
        public int RateInformation { get; set; }

        public CommonUserDao User { get; set; }
    }
}

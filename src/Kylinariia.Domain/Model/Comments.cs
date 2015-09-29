using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Comments:BaseModel
    {
        public string comment { get; set; }
        public DateTime date { get; set; }
        public Rate rate { get; set; }
    }
}

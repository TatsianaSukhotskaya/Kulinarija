using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Comment:BaseModel
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public List<Rate> Rate { get; set; }
    }
}

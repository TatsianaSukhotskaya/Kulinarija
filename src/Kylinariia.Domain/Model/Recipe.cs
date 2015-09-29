using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Recipe:BaseModel
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Rate> Rate { get; set; }
    }
}

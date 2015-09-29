using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Recipe:BaseModel
    {
        public string name { get; set; }
        public List<string> ingredients { get; set; }
        public string description { get; set; }
        public List<Comments> comment { get; set; }
        public Rate rate { get; set; }
    }
}

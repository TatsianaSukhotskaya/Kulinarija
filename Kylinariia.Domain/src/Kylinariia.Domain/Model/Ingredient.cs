using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Ingredient:BaseModel
    {
        public string name { get; set; }
        public int weight { get; set; }
        public TypesOfIngredients type { get; set; }
    }
}

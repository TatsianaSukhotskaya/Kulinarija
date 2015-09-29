using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Ingredient:BaseModel
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public TypesOfIngredient Type { get; set; }
    }
}

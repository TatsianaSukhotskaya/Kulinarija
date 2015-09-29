using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Favorite
    {
        public string name { get; set; }
        public DateTime date_of_add { get; set; }
        public List<Recipe> myFavorites { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Favorite
    {
        public string Name { get; set; }
        public DateTime DateOfAdd { get; set; }
        public Recipe Recipe { get; set; }
    }
}

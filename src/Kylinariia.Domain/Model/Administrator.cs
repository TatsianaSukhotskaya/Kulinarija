using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public class Administrator:CommonUser
    {
        public new string name { get; set; }
        public string pass { get; set; }
        public new DateTime date { get; set; }
        public DateTime last_date { get; set; }
        public Recipe new_recipe { get; set; }
        public Favorite my_favorites { get; set; }
    }
}

using Kylinariia.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Model
{
    public abstract class CommonUser:BaseModel
    {
        public string Name { get;set; }
        public string Password { get; set; }
        public DateTime DateOfAdd { get; set; }
        public DateTime LastVisit { get; set; }
        public List<Role> Roles { get; set; }
        public List<Favorite> MyFavorites { get; set; }
        public List<Comments> Comments { get; set; }

    }
}

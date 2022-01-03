using MVC_1.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.ViewModel
{
    public class UserAndListRoles
    {
        public User User { get; set; }
        public List<Role> Roles { get; set; }
    }
}

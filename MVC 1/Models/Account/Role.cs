using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.Account
{
    public class Role
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите Вашу роль")]
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
}

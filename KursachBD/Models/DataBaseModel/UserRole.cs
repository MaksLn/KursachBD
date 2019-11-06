using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class UserRole : IdentityRole
    {
        public UserRole()
        {
        }

        public UserRole(string roleName) : base(roleName)
        {
        }
    }
}

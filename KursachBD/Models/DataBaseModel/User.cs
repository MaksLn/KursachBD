using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class User:IdentityUser
    {
        public DateTime? Year { get; set; }
        public byte[] Photo { get; set; }
        public int StatusComentId { get; set; }
        public StatusComent StatusComent { get; set; }
        public List<Coment> Coments { get; set; }
        public List<UserStar> UserStars { get; set; }
    }
}

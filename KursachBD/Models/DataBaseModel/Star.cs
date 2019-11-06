using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class UserStar
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public float? Star { get; set; }
        public int UserFilmId { get; set; }
        public UserFilm UserFilm { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}

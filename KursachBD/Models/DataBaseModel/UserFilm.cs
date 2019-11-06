using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class UserFilm
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Discription { get; set; }
        public int StatusViewId { get; set; }
        public StatusView StatusView { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public List<UserStar> UserStars { get; set; }
    }
}

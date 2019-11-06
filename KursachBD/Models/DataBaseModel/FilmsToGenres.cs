using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class FilmsToGenres
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int GenreId { get; set; }
    }
}

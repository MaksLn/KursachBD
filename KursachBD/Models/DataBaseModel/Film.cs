using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class Film
    {
        public Film()
        {
            FilmsToCountrys = new List<FilmsToCountrys>();
        }

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Budget { get; set; }
        public DateTime Time { get; set; }
        public int CreateYearId { get; set; }
        public CreateYear Year { get; set; }
        public List<FilmsToCountrys> FilmsToCountrys { get; set; }
        public int? MPAAId { get; set; }
        public MPAA MPAA { get; set; }
        public string Photo { get; set; }
        public int RetingId { get; set; }
        public Reting Reting { get; set; }
        public List<FilmsToGenres> FilmsToGenres { get; set; }
        public List<ParticipantsBuffer> ParticipantsBuffers { get; set; }
        public List<UserFilm> UserFilms { get; set; }
        public List<Coment> Coments { get; set; }
    }
}

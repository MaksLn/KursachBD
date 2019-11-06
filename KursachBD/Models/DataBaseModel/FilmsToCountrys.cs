using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models.DataBaseModel
{
    public class FilmsToCountrys
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
